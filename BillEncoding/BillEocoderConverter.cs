using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillEncoding
{
    public class BillEocoderConverter
    {
        private string stringCode;
        private byte[][] imageCodeArray;

        public BillEocoderConverter()
        {
            imageCodeArray = new byte[4][];
            for (int i = 0; i < 4; i++) { imageCodeArray[i] = new byte[12]; }
        }

        public string ConvertStringToImage(string stringcode)
        {
            if (!StringCodeValidation(stringcode)) { return "Invalid Input"; }
            this.stringCode = stringcode;
            int numFlag = 0;
            int letterFlag = 0;
            for (int i = 0; i < 10; i++)
            {
                if (char.IsDigit(stringcode, i))
                {
                    EncodingNumber(stringcode[i], numFlag);
                    numFlag++;
                }
                else
                {
                    EncodingLetter(stringcode[i], i, letterFlag);
                    letterFlag++;
                }
            }
            return ImageCodeArrayToString();
        }

        public string ConvertImageToStringByFisrtBlock(string imagecode)
        {
            if (!ImageCodeValidation(imagecode, true)) { return "Invalid"; }
            return ConvertImageToStringByOneBlock(imagecode);
        }

        public List<string> ConvertImageToStringByAllBlock(string imagecode)
        {
            if (!ImageCodeValidation(imagecode, false)) { return new List<string> { "Invalid" }; }
            List<string> resultSet = new List<string>();
            List<string> usefulSet = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                string blockCode = imagecode.Substring(48 * i, 48);
                string blockResult = ConvertImageToStringByOneBlock(blockCode);
                resultSet.Add(blockResult);
                if (!blockResult.Contains('?')) { usefulSet.Add(blockResult); }
            }
            int[] vote = new int[usefulSet.Count];
            for (int i = 0; i < usefulSet.Count; i++)
            {
                for (int j = i + 1; j < usefulSet.Count; j++)
                {
                    if (usefulSet[j] == usefulSet[i])
                    {
                        vote[i]++;
                        vote[j]++;
                    }
                }
            }

            return resultSet;
        }

        private string ConvertImageToStringByOneBlock(string imagecode)
        {
            ImageCodeStringToArray(imagecode);
            char[] resultChar = new char[10] { '?', '?', '?', '?', '?', '?', '?', '?', '?', '?' };

            //Solve Letter Part
            int letterPos1 = imageCodeArray[3][0] * 2 + imageCodeArray[3][1];
            int letterPos2 = imageCodeArray[3][10] * 2 + imageCodeArray[3][11];
            byte[] letter1 = new byte[] { imageCodeArray[0][1], imageCodeArray[1][0], imageCodeArray[2][0], imageCodeArray[1][1], imageCodeArray[2][1] };
            byte[] letter2 = new byte[] { imageCodeArray[0][10], imageCodeArray[1][10], imageCodeArray[2][10], imageCodeArray[1][11], imageCodeArray[2][11] };
            resultChar[letterPos1] = DecodingLetter(letter1);
            resultChar[letterPos2] = DecodingLetter(letter2);

            //Solve Number Part
            int numPos = 0;
            for (int i = 1; i < 9; i++)
            {
                while (resultChar[numPos] != '?') { numPos++; }
                int row = i > 4 ? 1 : 0;
                int coloum = i - 4 * row;
                byte[] numberI = new byte[] { imageCodeArray[2 * row][2 * coloum], imageCodeArray[2 * row + 1][2 * coloum], imageCodeArray[2 * row][2 * coloum + 1], imageCodeArray[2 * row + 1][2 * coloum + 1] };
                resultChar[numPos] = DecodingNumber(numberI);
            }

            string resultString = "";
            for (int i = 0; i < 10; i++)
            {
                resultString += resultChar[i];
            }
            return resultString;
        }

        private Boolean StringCodeValidation(string stringcode)
        {
            if (stringcode.Length != 10) { return false; }
            for (int i = 0; i < 10; i++)
            {
                if (!char.IsLetterOrDigit(stringcode[i])) { return false; }
            }
            int letterCount = 0;
            for (int i = 0; i < 4; i++)
            {
                if (!char.IsDigit(stringcode[i]))
                {
                    letterCount++;
                }
            }
            if (letterCount != 2) { return false; }
            return true;
        }

        private Boolean ImageCodeValidation(string imagecode, bool isSingleLine)
        {
            int lengthLimit = isSingleLine ? 48 : 240;
            if (imagecode.Length != lengthLimit) { return false; }
            for (int i = 0; i < lengthLimit; i++)
            {
                if (imagecode[i] != '0' && imagecode[i] != '1') { return false; }
            }
            return true;
        }

        private void EncodingLetter(char letter, int order, int letterflag)
        {
            int letterNumber = Convert.ToInt32(letter - 'A');
            int[] singleCode = new int[5];
            int[] singlePosCode = new int[2];
            singleCode[0] = letterNumber % 2;
            singleCode[1] = letterNumber > 12 ? 1 : 0;
            singleCode[2] = letterNumber > singleCode[1] * 14 + 5 ? 1 : 0;
            int reverseNum = singleCode[1] == 0 ? letterNumber : 25 - letterNumber;
            int serialCode = Convert.ToInt32(reverseNum / 2) - singleCode[1] * 4 + 1;
            singleCode[3] = Convert.ToInt32(serialCode / 2);
            singleCode[4] = serialCode % 2;
            if (singleCode[1] == 1)
            {
                singleCode[3] = 1 - singleCode[3];
                singleCode[4] = 1 - singleCode[4];
            }
            singlePosCode[0] = (int)order / 2;
            singlePosCode[1] = order % 2;
            imageCodeArray[0][1 + 9 * letterflag] = Convert.ToByte(singleCode[0]);
            imageCodeArray[1][10 * letterflag] = Convert.ToByte(singleCode[1]);
            imageCodeArray[1][10 * letterflag + 1] = Convert.ToByte(singleCode[3]);
            imageCodeArray[2][10 * letterflag] = Convert.ToByte(singleCode[2]);
            imageCodeArray[2][10 * letterflag + 1] = Convert.ToByte(singleCode[4]);
            imageCodeArray[3][10 * letterflag] = Convert.ToByte(singlePosCode[0]);
            imageCodeArray[3][10 * letterflag + 1] = Convert.ToByte(singlePosCode[1]);
        }

        private void EncodingNumber(char num, int order)
        {
            int number = Convert.ToInt32(num) - 48;
            int row = order > 3 ? 1 : 0;
            int col = order - row * 4;
            int[] singleCode = new int[4];
            singleCode[0] = number % 2;
            singleCode[1] = number > 4 ? 1 : 0;
            singleCode[2] = number > (singleCode[1] * 6 + 1) ? 1 : 0;
            if (number == 4 || number == 5)
            {
                singleCode[3] = singleCode[2];
            }
            else
            {
                singleCode[3] = 1 - singleCode[2];
            }
            imageCodeArray[row * 2][col * 2 + 2] = Convert.ToByte(singleCode[0]);
            imageCodeArray[row * 2][col * 2 + 3] = Convert.ToByte(singleCode[2]);
            imageCodeArray[row * 2 + 1][col * 2 + 2] = Convert.ToByte(singleCode[1]);
            imageCodeArray[row * 2 + 1][col * 2 + 3] = Convert.ToByte(singleCode[3]);
        }

        private char DecodingLetter(byte[] inputSet)
        {
            int orderCode = inputSet[3] * 2 + inputSet[4];
            int regionShift = inputSet[1] * 12 + inputSet[2] * 8;
            int resultLetter = regionShift + orderCode * 2 - 2 + inputSet[0];
            return Convert.ToChar(resultLetter + 'A');
        }

        private char DecodingNumber(byte[] inputSet)
        {
            int orderCode = inputSet[2] * 2 + inputSet[3];
            int resultNumber = orderCode * 2 - 2 + 6 * inputSet[1] + inputSet[0];
            return Convert.ToChar(resultNumber + '0');
        }

        protected string ImageCodeArrayToString()
        {
            String output = "";
            String singleLineOutput = "";
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    singleLineOutput += imageCodeArray[i][j].ToString();
                }
            }
            //return singleLineOutput;
            for (int i = 0; i < 5; i++) { output += singleLineOutput; }
            return output;
        }

        private void ImageCodeStringToArray(string imagecode)
        {
            for (int i = 0; i < imagecode.Length; i++)
            {
                imageCodeArray[Convert.ToInt32(i / 12)][i % 12] = Convert.ToByte(imagecode[i] - '0');
            }
        }
    }
}

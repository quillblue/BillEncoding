using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace BillEncoding
{
    public class ImageDrawer
    {
        private int dotLength;
        private int shiftLength;
        private Bitmap imagePic;

        public ImageDrawer()
        {
            dotLength = 6;
            shiftLength = 4;
        }

        public Bitmap DrawImage(string imageCode, bool isBlankDotVisible)
        {
            int line = imageCode.Length / 12;
            imagePic = new Bitmap(13 * shiftLength + 12 * dotLength, (line + 1) * shiftLength + line * dotLength);
            imagePic.SetResolution(300, 300);
            for (int i = 0; i < imageCode.Length; i++)
            {
                if (imageCode[i] == '1')
                {
                    int row = i / 12;
                    int col = i % 12;
                    for (int x = shiftLength * (col + 1) + dotLength * col; x < (shiftLength + dotLength) * (col + 1); x++)
                    {
                        for (int y = shiftLength * (row + 1) + dotLength * row; y < (shiftLength + dotLength) * (row + 1); y++)
                        {
                            imagePic.SetPixel(x, y, Color.Black);
                        }
                    }
                }
                else 
                {
                    if (isBlankDotVisible) 
                    {
                        int row = i / 12;
                        int col = i % 12;
                        for (int x = shiftLength * (col + 1) + dotLength * col; x < (shiftLength + dotLength) * (col + 1); x++)
                        {
                            for (int y = shiftLength * (row + 1) + dotLength * row; y < (shiftLength + dotLength) * (row + 1); y++)
                            {
                                imagePic.SetPixel(x, y, Color.LightGray);
                            }
                        }
                    }
                }
            }
            return imagePic;
        }
    }
}

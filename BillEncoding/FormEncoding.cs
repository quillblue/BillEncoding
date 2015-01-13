using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BillEncoding
{
    public partial class FormEncoding : Form
    {
        BillEocoderConverter converter = new BillEocoderConverter();
        //String lastFilePath = "";

        public FormEncoding()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            inputBox.Text=inputBox.Text.ToUpper();
            resultTextBox.Text = converter.ConvertStringToImage(inputBox.Text);
            ImageDrawer drawer = new ImageDrawer();
            if (resultTextBox.Text != "Invalid Input")
            {
                pictureBox.Image = drawer.DrawImage(resultTextBox.Text, false);
                btnSave.Enabled = true;
            }
            else 
            {
                pictureBox.Image = null;
                btnSave.Enabled = false;
            }
        }

        private void DecodingSingleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDecodingSingleLine fds = new FormDecodingSingleLine();
            this.Hide();
            fds.ShowDialog();
            this.Close();
        }

        private void DecodingMultipleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDecodingMultiple fdm = new FormDecodingMultiple();
            this.Hide();
            fdm.ShowDialog();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "图片文件|*.png|所有文件|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.FileName = inputBox.Text;
            //if (lastFilePath != "") { saveFileDialog.InitialDirectory = lastFilePath; }
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image.Save(saveFileDialog.FileName);
            }
        }
    }
}

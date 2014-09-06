using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BillEncoding
{
    public partial class FormDecodingSingleLine : Form
    {
        public FormDecodingSingleLine()
        {
            InitializeComponent();
        }

        private void EncodingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEncoding fe = new FormEncoding();
            this.Hide();
            fe.ShowDialog();
            this.Close();
        }

        private void DecodingMultipleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDecodingMultiple fdm = new FormDecodingMultiple();
            this.Hide();
            fdm.ShowDialog();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            BillEocoderConverter bec = new BillEocoderConverter();
            ImageDrawer drawer = new ImageDrawer();
            string result = bec.ConvertImageToStringByFisrtBlock(inputTextBox.Text);
            if (result == "Invalid")
            {
                resultTextBox.Text = "----------";
                statusTextBox.Text = "长度或格式错误";
                statusTextBox.BackColor = Color.LightCoral;
                pictureBox1.Image = null;
            }
            else 
            {
                pictureBox1.Image=drawer.DrawImage(inputTextBox.Text,true);
                resultTextBox.Text = result;
                if (result.Contains("?"))
                {
                    resultTextBox.Text = "----------";
                    statusTextBox.Text = "序列无效";
                    statusTextBox.BackColor = Color.LightCoral;
                }
                else 
                {
                    statusTextBox.Text = "序列有效";
                    statusTextBox.BackColor = Color.LightGreen;
                }
            }
        }
    }
}

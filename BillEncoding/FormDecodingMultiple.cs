using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BillEncoding
{
    public partial class FormDecodingMultiple : Form
    {
        public FormDecodingMultiple()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            BillEocoderConverter bec = new BillEocoderConverter();
            List<string> result = bec.ConvertImageToStringByAllBlock(inputTextBox.Text);
            if (result[0] == "Invalid")
            {
                finalResultBox.Text = "----------";
                statusFinal.Text = "序列长度或格式不正确";
                resetStatus(statusBox1);
                resetStatus(statusBox2);
                resetStatus(statusBox3);
                resetStatus(statusBox4);
                resetStatus(statusBox5);
                resultBox1.Text = "";
                resultBox2.Text = "";
                resultBox3.Text = "";
                resultBox4.Text = "";
                resultBox5.Text = "";
                statusFinal.BackColor = Color.LightCoral;
                return;
            }
            resultBox1.Text = result[0].Contains("?") ? "----------" : result[0];
            resultBox2.Text = result[1].Contains("?") ? "----------" : result[1];
            resultBox3.Text = result[2].Contains("?") ? "----------" : result[2];
            resultBox4.Text = result[3].Contains("?") ? "----------" : result[3];
            resultBox5.Text = result[4].Contains("?") ? "----------" : result[4];
            if (result[0].Contains("?")) { setStatusInvalid(statusBox1); }
            else { setStatusValid(statusBox1); }
            if (result[1].Contains("?")) { setStatusInvalid(statusBox2); }
            else { setStatusValid(statusBox2); }
            if (result[2].Contains("?")) { setStatusInvalid(statusBox3); }
            else { setStatusValid(statusBox3); }
            if (result[3].Contains("?")) { setStatusInvalid(statusBox4); }
            else { setStatusValid(statusBox4); }
            if (result[4].Contains("?")) { setStatusInvalid(statusBox5); }
            else { setStatusValid(statusBox5); }

            if (result[5] == "None is valid" || result[5] == "dudge") 
            {
                finalResultBox.Text = "----------";
                statusFinal.BackColor = Color.LightCoral;
                if (result[5] == "None is valid")
                {
                    statusFinal.Text = "序列无效";
                }
                else 
                {
                    statusFinal.Text = "平票,无法确定";
                }
            }
            else
            {
                finalResultBox.Text = result[5];
                statusFinal.Text = "识别成功";
                statusFinal.BackColor = Color.LightGreen;
            }
        }

        private void setStatusValid(TextBox statusbox)
        {
            statusbox.Text = "有效";
            statusbox.BackColor = Color.LightGreen;
        }

        private void setStatusInvalid(TextBox statusbox)
        {
            statusbox.Text = "无效";
            statusbox.BackColor = Color.LightCoral;
        }

        private void resetStatus(TextBox statusbox)
        {
            statusbox.Text = "";
            statusbox.BackColor = Color.LightGray;
        }

        private void EncodingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEncoding fe = new FormEncoding();
            this.Hide();
            fe.ShowDialog();
            this.Close();
        }

        private void DecodingSingleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDecodingSingleLine fds = new FormDecodingSingleLine();
            this.Hide();
            fds.ShowDialog();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BillEncoding
{
    public partial class FormEncoding : Form
    {
        BillEocoderConverter converter = new BillEocoderConverter();
        
        public FormEncoding()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            inputBox.Text=inputBox.Text.ToUpper();
            resultTextBox.Text = converter.ConvertStringToImage(inputBox.Text);
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

        



    }
}

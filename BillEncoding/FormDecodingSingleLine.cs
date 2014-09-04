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
    }
}

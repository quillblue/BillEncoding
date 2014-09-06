namespace BillEncoding
{
    partial class FormDecodingMultiple
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.EncodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.解析编码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DecodingSingleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DecodingMultipleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.labelInput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resultBox1 = new System.Windows.Forms.TextBox();
            this.statusBox1 = new System.Windows.Forms.TextBox();
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.statusBox2 = new System.Windows.Forms.TextBox();
            this.resultBox2 = new System.Windows.Forms.TextBox();
            this.statusBox3 = new System.Windows.Forms.TextBox();
            this.resultBox3 = new System.Windows.Forms.TextBox();
            this.statusBox4 = new System.Windows.Forms.TextBox();
            this.resultBox4 = new System.Windows.Forms.TextBox();
            this.statusBox5 = new System.Windows.Forms.TextBox();
            this.resultBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.finalResultBox = new System.Windows.Forms.TextBox();
            this.statusFinal = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EncodingToolStripMenuItem,
            this.解析编码ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 25);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // EncodingToolStripMenuItem
            // 
            this.EncodingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncodingToolStripMenuItem.Name = "EncodingToolStripMenuItem";
            this.EncodingToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.EncodingToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.EncodingToolStripMenuItem.Text = "生成编码";
            this.EncodingToolStripMenuItem.Click += new System.EventHandler(this.EncodingToolStripMenuItem_Click);
            // 
            // 解析编码ToolStripMenuItem
            // 
            this.解析编码ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DecodingSingleToolStripMenuItem,
            this.DecodingMultipleToolStripMenuItem});
            this.解析编码ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.解析编码ToolStripMenuItem.Name = "解析编码ToolStripMenuItem";
            this.解析编码ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.解析编码ToolStripMenuItem.Text = "解析编码";
            // 
            // DecodingSingleToolStripMenuItem
            // 
            this.DecodingSingleToolStripMenuItem.Name = "DecodingSingleToolStripMenuItem";
            this.DecodingSingleToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.DecodingSingleToolStripMenuItem.Text = "单行模式";
            this.DecodingSingleToolStripMenuItem.Click += new System.EventHandler(this.DecodingSingleToolStripMenuItem_Click);
            // 
            // DecodingMultipleToolStripMenuItem
            // 
            this.DecodingMultipleToolStripMenuItem.Name = "DecodingMultipleToolStripMenuItem";
            this.DecodingMultipleToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.DecodingMultipleToolStripMenuItem.Text = "多行模式";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmit.Location = new System.Drawing.Point(13, 308);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(194, 38);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "识 别";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelInput.Location = new System.Drawing.Point(9, 35);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(105, 20);
            this.labelInput.TabIndex = 99;
            this.labelInput.Text = "输入多行序列";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(236, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "识读结果";
            // 
            // resultBox1
            // 
            this.resultBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox1.Location = new System.Drawing.Point(301, 63);
            this.resultBox1.Name = "resultBox1";
            this.resultBox1.ReadOnly = true;
            this.resultBox1.Size = new System.Drawing.Size(105, 29);
            this.resultBox1.TabIndex = 45;
            this.resultBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusBox1
            // 
            this.statusBox1.BackColor = System.Drawing.Color.LightGray;
            this.statusBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusBox1.Location = new System.Drawing.Point(413, 64);
            this.statusBox1.Name = "statusBox1";
            this.statusBox1.ReadOnly = true;
            this.statusBox1.Size = new System.Drawing.Size(75, 28);
            this.statusBox1.TabIndex = 46;
            this.statusBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(13, 58);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(194, 232);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.Text = "";
            // 
            // statusBox2
            // 
            this.statusBox2.BackColor = System.Drawing.Color.LightGray;
            this.statusBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusBox2.Location = new System.Drawing.Point(413, 100);
            this.statusBox2.Name = "statusBox2";
            this.statusBox2.ReadOnly = true;
            this.statusBox2.Size = new System.Drawing.Size(75, 28);
            this.statusBox2.TabIndex = 48;
            this.statusBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resultBox2
            // 
            this.resultBox2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox2.Location = new System.Drawing.Point(301, 99);
            this.resultBox2.Name = "resultBox2";
            this.resultBox2.ReadOnly = true;
            this.resultBox2.Size = new System.Drawing.Size(105, 29);
            this.resultBox2.TabIndex = 47;
            this.resultBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusBox3
            // 
            this.statusBox3.BackColor = System.Drawing.Color.LightGray;
            this.statusBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusBox3.Location = new System.Drawing.Point(413, 137);
            this.statusBox3.Name = "statusBox3";
            this.statusBox3.ReadOnly = true;
            this.statusBox3.Size = new System.Drawing.Size(75, 28);
            this.statusBox3.TabIndex = 50;
            this.statusBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resultBox3
            // 
            this.resultBox3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox3.Location = new System.Drawing.Point(301, 136);
            this.resultBox3.Name = "resultBox3";
            this.resultBox3.ReadOnly = true;
            this.resultBox3.Size = new System.Drawing.Size(105, 29);
            this.resultBox3.TabIndex = 49;
            this.resultBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusBox4
            // 
            this.statusBox4.BackColor = System.Drawing.Color.LightGray;
            this.statusBox4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusBox4.Location = new System.Drawing.Point(413, 174);
            this.statusBox4.Name = "statusBox4";
            this.statusBox4.ReadOnly = true;
            this.statusBox4.Size = new System.Drawing.Size(75, 28);
            this.statusBox4.TabIndex = 52;
            this.statusBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resultBox4
            // 
            this.resultBox4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox4.Location = new System.Drawing.Point(301, 173);
            this.resultBox4.Name = "resultBox4";
            this.resultBox4.ReadOnly = true;
            this.resultBox4.Size = new System.Drawing.Size(105, 29);
            this.resultBox4.TabIndex = 51;
            this.resultBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusBox5
            // 
            this.statusBox5.BackColor = System.Drawing.Color.LightGray;
            this.statusBox5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusBox5.Location = new System.Drawing.Point(413, 211);
            this.statusBox5.Name = "statusBox5";
            this.statusBox5.ReadOnly = true;
            this.statusBox5.Size = new System.Drawing.Size(75, 28);
            this.statusBox5.TabIndex = 54;
            this.statusBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resultBox5
            // 
            this.resultBox5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox5.Location = new System.Drawing.Point(301, 210);
            this.resultBox5.Name = "resultBox5";
            this.resultBox5.ReadOnly = true;
            this.resultBox5.Size = new System.Drawing.Size(105, 29);
            this.resultBox5.TabIndex = 53;
            this.resultBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(238, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "第1组";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(238, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "第2组";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(238, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "第3组";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(238, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 58;
            this.label5.Text = "第4组";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(238, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "第5组";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(236, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "识别结论";
            // 
            // finalResultBox
            // 
            this.finalResultBox.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalResultBox.ForeColor = System.Drawing.Color.Red;
            this.finalResultBox.Location = new System.Drawing.Point(240, 307);
            this.finalResultBox.Name = "finalResultBox";
            this.finalResultBox.ReadOnly = true;
            this.finalResultBox.Size = new System.Drawing.Size(248, 38);
            this.finalResultBox.TabIndex = 61;
            this.finalResultBox.Text = "A0A1234567";
            this.finalResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusFinal
            // 
            this.statusFinal.BackColor = System.Drawing.Color.LightGray;
            this.statusFinal.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusFinal.Location = new System.Drawing.Point(318, 266);
            this.statusFinal.Name = "statusFinal";
            this.statusFinal.ReadOnly = true;
            this.statusFinal.Size = new System.Drawing.Size(170, 28);
            this.statusFinal.TabIndex = 100;
            this.statusFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormDecodingMultiple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 371);
            this.Controls.Add(this.statusFinal);
            this.Controls.Add(this.finalResultBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusBox5);
            this.Controls.Add(this.resultBox5);
            this.Controls.Add(this.statusBox4);
            this.Controls.Add(this.resultBox4);
            this.Controls.Add(this.statusBox3);
            this.Controls.Add(this.resultBox3);
            this.Controls.Add(this.statusBox2);
            this.Controls.Add(this.resultBox2);
            this.Controls.Add(this.statusBox1);
            this.Controls.Add(this.resultBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "FormDecodingMultiple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编码管理工具";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EncodingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 解析编码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DecodingSingleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DecodingMultipleToolStripMenuItem;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultBox1;
        private System.Windows.Forms.TextBox statusBox1;
        private System.Windows.Forms.RichTextBox inputTextBox;
        private System.Windows.Forms.TextBox statusBox2;
        private System.Windows.Forms.TextBox resultBox2;
        private System.Windows.Forms.TextBox statusBox3;
        private System.Windows.Forms.TextBox resultBox3;
        private System.Windows.Forms.TextBox statusBox4;
        private System.Windows.Forms.TextBox resultBox4;
        private System.Windows.Forms.TextBox statusBox5;
        private System.Windows.Forms.TextBox resultBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox finalResultBox;
        private System.Windows.Forms.TextBox statusFinal;
    }
}
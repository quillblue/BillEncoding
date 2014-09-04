namespace BillEncoding
{
    partial class FormDecodingSingleLine
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
            this.labelInput = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.labelImage = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.EncodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.解析编码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DecodingSingleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DecodingMultipleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelInput.Location = new System.Drawing.Point(12, 37);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(106, 21);
            this.labelInput.TabIndex = 33;
            this.labelInput.Text = "输入单行序列";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(16, 60);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(115, 126);
            this.inputTextBox.TabIndex = 34;
            this.inputTextBox.Text = "";
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelImage.Location = new System.Drawing.Point(143, 145);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(74, 21);
            this.labelImage.TabIndex = 35;
            this.labelImage.Text = "模拟图像";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.Location = new System.Drawing.Point(147, 61);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(140, 35);
            this.resultTextBox.TabIndex = 36;
            this.resultTextBox.Text = "A0A1234567";
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EncodingToolStripMenuItem,
            this.解析编码ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(314, 25);
            this.menuStrip1.TabIndex = 37;
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
            // 
            // DecodingMultipleToolStripMenuItem
            // 
            this.DecodingMultipleToolStripMenuItem.Name = "DecodingMultipleToolStripMenuItem";
            this.DecodingMultipleToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.DecodingMultipleToolStripMenuItem.Text = "多行模式";
            this.DecodingMultipleToolStripMenuItem.Click += new System.EventHandler(this.DecodingMultipleToolStripMenuItem_Click);
            // 
            // statusTextBox
            // 
            this.statusTextBox.BackColor = System.Drawing.Color.LightGray;
            this.statusTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusTextBox.Location = new System.Drawing.Point(147, 102);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(140, 28);
            this.statusTextBox.TabIndex = 38;
            this.statusTextBox.Text = "序列长度不正确";
            this.statusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(105, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 39;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmit.Location = new System.Drawing.Point(16, 210);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(115, 39);
            this.btnSubmit.TabIndex = 40;
            this.btnSubmit.Text = "识别";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelResult.Location = new System.Drawing.Point(143, 37);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(74, 21);
            this.labelResult.TabIndex = 41;
            this.labelResult.Text = "识别结果";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(147, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 84);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // FormDecodingSingleLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 281);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.labelInput);
            this.MaximizeBox = false;
            this.Name = "FormDecodingSingleLine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编码管理工具";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.RichTextBox inputTextBox;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EncodingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 解析编码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DecodingSingleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DecodingMultipleToolStripMenuItem;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace BillEncoding
{
    partial class FormEncoding
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.labelImageCode = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.labelImage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.生成编码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.解析编码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DecodingSingleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DecodingMultipleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.Location = new System.Drawing.Point(22, 112);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(194, 229);
            this.resultTextBox.TabIndex = 3;
            this.resultTextBox.Text = "";
            // 
            // labelImageCode
            // 
            this.labelImageCode.AutoSize = true;
            this.labelImageCode.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelImageCode.Location = new System.Drawing.Point(18, 89);
            this.labelImageCode.Name = "labelImageCode";
            this.labelImageCode.Size = new System.Drawing.Size(74, 21);
            this.labelImageCode.TabIndex = 25;
            this.labelImageCode.Text = "编码序列";
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelInput.Location = new System.Drawing.Point(18, 46);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(106, 21);
            this.labelInput.TabIndex = 26;
            this.labelInput.Text = "输入冠字号码";
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(129, 40);
            this.inputBox.MaxLength = 10;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(160, 29);
            this.inputBox.TabIndex = 27;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmit.Location = new System.Drawing.Point(315, 38);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 32);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "生成编码";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelImage.Location = new System.Drawing.Point(234, 89);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(74, 21);
            this.labelImage.TabIndex = 29;
            this.labelImage.Text = "编码图像";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(238, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 176);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.生成编码ToolStripMenuItem,
            this.解析编码ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(426, 25);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 生成编码ToolStripMenuItem
            // 
            this.生成编码ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.生成编码ToolStripMenuItem.Name = "生成编码ToolStripMenuItem";
            this.生成编码ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.生成编码ToolStripMenuItem.Text = "生成编码";
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
            this.DecodingMultipleToolStripMenuItem.Click += new System.EventHandler(this.DecodingMultipleToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(273, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "保存图像";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormEncoding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(426, 359);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.labelImageCode);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormEncoding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编码管理工具";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.Label labelImageCode;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 生成编码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 解析编码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DecodingSingleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DecodingMultipleToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}


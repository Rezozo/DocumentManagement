namespace documentManagement
{
    partial class SelectFormats
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
            this.label1 = new System.Windows.Forms.Label();
            this.pdfBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.fileNameTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(116, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Выберите формат файла";
            // 
            // pdfBtn
            // 
            this.pdfBtn.AutoSize = true;
            this.pdfBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pdfBtn.Depth = 0;
            this.pdfBtn.Location = new System.Drawing.Point(75, 174);
            this.pdfBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pdfBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.pdfBtn.Name = "pdfBtn";
            this.pdfBtn.Primary = false;
            this.pdfBtn.Size = new System.Drawing.Size(122, 36);
            this.pdfBtn.TabIndex = 36;
            this.pdfBtn.Text = "Pdf формат";
            this.pdfBtn.UseVisualStyleBackColor = true;
            this.pdfBtn.Click += new System.EventHandler(this.pdfBtn_Click);
            // 
            // txtBtn
            // 
            this.txtBtn.AutoSize = true;
            this.txtBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtBtn.Depth = 0;
            this.txtBtn.Location = new System.Drawing.Point(302, 174);
            this.txtBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBtn.Name = "txtBtn";
            this.txtBtn.Primary = false;
            this.txtBtn.Size = new System.Drawing.Size(122, 36);
            this.txtBtn.TabIndex = 37;
            this.txtBtn.Text = "Txt формат";
            this.txtBtn.UseVisualStyleBackColor = true;
            this.txtBtn.Click += new System.EventHandler(this.txtBtn_Click);
            // 
            // fileNameTxt
            // 
            this.fileNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileNameTxt.Location = new System.Drawing.Point(109, 126);
            this.fileNameTxt.MaxLength = 70;
            this.fileNameTxt.Multiline = true;
            this.fileNameTxt.Name = "fileNameTxt";
            this.fileNameTxt.Size = new System.Drawing.Size(281, 39);
            this.fileNameTxt.TabIndex = 38;
            this.fileNameTxt.Text = "Введите название файла";
            this.fileNameTxt.Enter += new System.EventHandler(this.fileNameTxt_Enter);
            this.fileNameTxt.Leave += new System.EventHandler(this.fileNameTxt_Leave);
            // 
            // SelectFormats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 244);
            this.Controls.Add(this.fileNameTxt);
            this.Controls.Add(this.txtBtn);
            this.Controls.Add(this.pdfBtn);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(502, 244);
            this.MinimumSize = new System.Drawing.Size(502, 244);
            this.Name = "SelectFormats";
            this.Text = "Выберите формат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialFlatButton pdfBtn;
        private MaterialSkin.Controls.MaterialFlatButton txtBtn;
        private System.Windows.Forms.TextBox fileNameTxt;
    }
}
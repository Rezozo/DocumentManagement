namespace documentManagement
{
    partial class GenerateFile
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
            this.txtBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.paymentPdfBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.pdfBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.fileNameTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBtn
            // 
            this.txtBtn.AutoSize = true;
            this.txtBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtBtn.Depth = 0;
            this.txtBtn.Location = new System.Drawing.Point(137, 182);
            this.txtBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBtn.Name = "txtBtn";
            this.txtBtn.Primary = false;
            this.txtBtn.Size = new System.Drawing.Size(327, 36);
            this.txtBtn.TabIndex = 39;
            this.txtBtn.Text = "Выгрузить договор в TXT формат";
            this.txtBtn.UseVisualStyleBackColor = true;
            this.txtBtn.Click += new System.EventHandler(this.txtBtn_Click);
            // 
            // paymentPdfBtn
            // 
            this.paymentPdfBtn.AutoSize = true;
            this.paymentPdfBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.paymentPdfBtn.Depth = 0;
            this.paymentPdfBtn.Location = new System.Drawing.Point(67, 134);
            this.paymentPdfBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.paymentPdfBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.paymentPdfBtn.Name = "paymentPdfBtn";
            this.paymentPdfBtn.Primary = false;
            this.paymentPdfBtn.Size = new System.Drawing.Size(457, 36);
            this.paymentPdfBtn.TabIndex = 40;
            this.paymentPdfBtn.Text = "Выгрузить квитанцию на оплату в PDF формат";
            this.paymentPdfBtn.UseVisualStyleBackColor = true;
            this.paymentPdfBtn.Click += new System.EventHandler(this.paymentPdfBtn_Click);
            // 
            // pdfBtn
            // 
            this.pdfBtn.AutoSize = true;
            this.pdfBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pdfBtn.Depth = 0;
            this.pdfBtn.Location = new System.Drawing.Point(137, 230);
            this.pdfBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pdfBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.pdfBtn.Name = "pdfBtn";
            this.pdfBtn.Primary = false;
            this.pdfBtn.Size = new System.Drawing.Size(327, 36);
            this.pdfBtn.TabIndex = 38;
            this.pdfBtn.Text = "Выгрузить договор в PDF формат";
            this.pdfBtn.UseVisualStyleBackColor = true;
            this.pdfBtn.Click += new System.EventHandler(this.pdfBtn_Click);
            // 
            // fileNameTxt
            // 
            this.fileNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileNameTxt.Location = new System.Drawing.Point(137, 86);
            this.fileNameTxt.MaxLength = 70;
            this.fileNameTxt.Multiline = true;
            this.fileNameTxt.Name = "fileNameTxt";
            this.fileNameTxt.Size = new System.Drawing.Size(327, 39);
            this.fileNameTxt.TabIndex = 42;
            this.fileNameTxt.Text = "Введите название файла";
            // 
            // GenerateFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.fileNameTxt);
            this.Controls.Add(this.paymentPdfBtn);
            this.Controls.Add(this.txtBtn);
            this.Controls.Add(this.pdfBtn);
            this.MaximumSize = new System.Drawing.Size(600, 300);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "GenerateFile";
            this.Text = "Выберите действие";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton txtBtn;
        private MaterialSkin.Controls.MaterialFlatButton paymentPdfBtn;
        private MaterialSkin.Controls.MaterialFlatButton pdfBtn;
        private System.Windows.Forms.TextBox fileNameTxt;
    }
}
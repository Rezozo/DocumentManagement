namespace documentManagement
{
    partial class ResetPasswordForm
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
            this.LoginLabel = new System.Windows.Forms.Label();
            this.resetBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.ResetLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.PasswordTxtB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTxtB2 = new System.Windows.Forms.TextBox();
            this.infoLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(599, 85);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(68, 25);
            this.LoginLabel.TabIndex = 20;
            this.LoginLabel.Text = "Логин";
            // 
            // resetBtn
            // 
            this.resetBtn.AutoSize = true;
            this.resetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetBtn.Depth = 0;
            this.resetBtn.Location = new System.Drawing.Point(282, 314);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.resetBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Primary = false;
            this.resetBtn.Size = new System.Drawing.Size(176, 36);
            this.resetBtn.TabIndex = 26;
            this.resetBtn.Text = "Сбросить пароль";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // ResetLabel
            // 
            this.ResetLabel.AutoSize = true;
            this.ResetLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetLabel.Location = new System.Drawing.Point(276, 85);
            this.ResetLabel.Name = "ResetLabel";
            this.ResetLabel.Size = new System.Drawing.Size(197, 31);
            this.ResetLabel.TabIndex = 21;
            this.ResetLabel.Text = "Сброс  пароля";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLabel.Location = new System.Drawing.Point(227, 136);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(141, 25);
            this.passLabel.TabIndex = 28;
            this.passLabel.Text = "Новый пароль";
            // 
            // PasswordTxtB
            // 
            this.PasswordTxtB.Location = new System.Drawing.Point(232, 170);
            this.PasswordTxtB.MaxLength = 15;
            this.PasswordTxtB.Multiline = true;
            this.PasswordTxtB.Name = "PasswordTxtB";
            this.PasswordTxtB.PasswordChar = '*';
            this.PasswordTxtB.Size = new System.Drawing.Size(281, 39);
            this.PasswordTxtB.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(227, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Повторите пароль";
            // 
            // PasswordTxtB2
            // 
            this.PasswordTxtB2.Location = new System.Drawing.Point(232, 252);
            this.PasswordTxtB2.MaxLength = 15;
            this.PasswordTxtB2.Multiline = true;
            this.PasswordTxtB2.Name = "PasswordTxtB2";
            this.PasswordTxtB2.PasswordChar = '*';
            this.PasswordTxtB2.Size = new System.Drawing.Size(281, 39);
            this.PasswordTxtB2.TabIndex = 29;
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.infoLbl.Location = new System.Drawing.Point(12, 92);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(191, 15);
            this.infoLbl.TabIndex = 31;
            this.infoLbl.Text = "Узнать требования к паролю 🛈";
            this.infoLbl.Click += new System.EventHandler(this.labl_info_Click);
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 380);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTxtB2);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.PasswordTxtB);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.ResetLabel);
            this.Controls.Add(this.LoginLabel);
            this.MaximumSize = new System.Drawing.Size(755, 380);
            this.MinimumSize = new System.Drawing.Size(755, 380);
            this.Name = "ResetPasswordForm";
            this.Text = "Сброс пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLabel;
        private MaterialSkin.Controls.MaterialFlatButton resetBtn;
        private System.Windows.Forms.Label ResetLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox PasswordTxtB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordTxtB2;
        private System.Windows.Forms.Label infoLbl;
    }
}
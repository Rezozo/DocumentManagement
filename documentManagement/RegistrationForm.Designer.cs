namespace documentManagement
{
    partial class RegistrationForm
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
            this.backBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.createAccBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginTxt = new System.Windows.Forms.TextBox();
            this.RegistLabel = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.infoLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.AutoSize = true;
            this.backBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backBtn.Depth = 0;
            this.backBtn.Location = new System.Drawing.Point(23, 82);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.backBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.backBtn.Name = "backBtn";
            this.backBtn.Primary = false;
            this.backBtn.Size = new System.Drawing.Size(90, 36);
            this.backBtn.TabIndex = 25;
            this.backBtn.Text = "<- Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // createAccBtn
            // 
            this.createAccBtn.AutoSize = true;
            this.createAccBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createAccBtn.Depth = 0;
            this.createAccBtn.Location = new System.Drawing.Point(320, 377);
            this.createAccBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createAccBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.createAccBtn.Name = "createAccBtn";
            this.createAccBtn.Primary = false;
            this.createAccBtn.Size = new System.Drawing.Size(175, 36);
            this.createAccBtn.TabIndex = 24;
            this.createAccBtn.Text = "Создать аккаунт";
            this.createAccBtn.UseVisualStyleBackColor = true;
            this.createAccBtn.Click += new System.EventHandler(this.createAccBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(265, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Пароль";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(270, 267);
            this.PasswordTxt.MaxLength = 15;
            this.PasswordTxt.Multiline = true;
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(281, 39);
            this.PasswordTxt.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(265, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Логин";
            // 
            // LoginTxt
            // 
            this.LoginTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTxt.Location = new System.Drawing.Point(270, 182);
            this.LoginTxt.MaxLength = 15;
            this.LoginTxt.Multiline = true;
            this.LoginTxt.Name = "LoginTxt";
            this.LoginTxt.Size = new System.Drawing.Size(281, 39);
            this.LoginTxt.TabIndex = 20;
            // 
            // RegistLabel
            // 
            this.RegistLabel.AutoSize = true;
            this.RegistLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistLabel.Location = new System.Drawing.Point(321, 100);
            this.RegistLabel.Name = "RegistLabel";
            this.RegistLabel.Size = new System.Drawing.Size(174, 31);
            this.RegistLabel.TabIndex = 19;
            this.RegistLabel.Text = "Регистрация";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.ItemHeight = 20;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Администратор",
            "Менеджер"});
            this.comboBoxRole.Location = new System.Drawing.Point(270, 320);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxRole.Size = new System.Drawing.Size(281, 28);
            this.comboBoxRole.TabIndex = 26;
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.infoLbl.Location = new System.Drawing.Point(351, 240);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(191, 15);
            this.infoLbl.TabIndex = 32;
            this.infoLbl.Text = "🛈 Узнать требования к паролю";
            this.infoLbl.Click += new System.EventHandler(this.infoLbl_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.createAccBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginTxt);
            this.Controls.Add(this.RegistLabel);
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "RegistrationForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton backBtn;
        private MaterialSkin.Controls.MaterialFlatButton createAccBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginTxt;
        private System.Windows.Forms.Label RegistLabel;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label infoLbl;
    }
}
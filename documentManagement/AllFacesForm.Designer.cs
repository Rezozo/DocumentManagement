namespace documentManagement
{
    partial class AllFacesForm
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
            this.facesGridView = new System.Windows.Forms.DataGridView();
            this.educationBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.dealBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassportData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.facesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(1219, 102);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(68, 25);
            this.LoginLabel.TabIndex = 21;
            this.LoginLabel.Text = "Логин";
            // 
            // facesGridView
            // 
            this.facesGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.facesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.facesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.LastName,
            this.FirstName,
            this.MiddleName,
            this.DateOfBirth,
            this.PassportData,
            this.Address,
            this.Email,
            this.PhoneNumber,
            this.Position,
            this.WorkPlace});
            this.facesGridView.Location = new System.Drawing.Point(33, 186);
            this.facesGridView.MultiSelect = false;
            this.facesGridView.Name = "facesGridView";
            this.facesGridView.RowHeadersWidth = 51;
            this.facesGridView.RowTemplate.Height = 24;
            this.facesGridView.Size = new System.Drawing.Size(1319, 376);
            this.facesGridView.TabIndex = 26;
            this.facesGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.facesGridView_CellEndEdit);
            this.facesGridView.SelectionChanged += new System.EventHandler(this.facesGridView_SelectionChanged);
            this.facesGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.facesGridView_UserDeletedRow);
            // 
            // educationBtn
            // 
            this.educationBtn.AutoSize = true;
            this.educationBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.educationBtn.Depth = 0;
            this.educationBtn.Location = new System.Drawing.Point(501, 96);
            this.educationBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.educationBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.educationBtn.Name = "educationBtn";
            this.educationBtn.Primary = false;
            this.educationBtn.Size = new System.Drawing.Size(359, 36);
            this.educationBtn.TabIndex = 27;
            this.educationBtn.Text = "Список образовательных программ";
            this.educationBtn.UseVisualStyleBackColor = true;
            this.educationBtn.Click += new System.EventHandler(this.educationBtn_Click);
            // 
            // dealBtn
            // 
            this.dealBtn.AutoSize = true;
            this.dealBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dealBtn.Depth = 0;
            this.dealBtn.Location = new System.Drawing.Point(899, 96);
            this.dealBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dealBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.dealBtn.Name = "dealBtn";
            this.dealBtn.Primary = false;
            this.dealBtn.Size = new System.Drawing.Size(190, 36);
            this.dealBtn.TabIndex = 28;
            this.dealBtn.Text = "Список договоров";
            this.dealBtn.UseVisualStyleBackColor = true;
            this.dealBtn.Click += new System.EventHandler(this.dealBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Список всех физических лиц:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(29, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1459, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Выберите нужную строку, чтобы начать создание договора, нажав на пустое пространс" +
    "тво в списке, левее фамилии физического лица\r\n";
            // 
            // Id
            // 
            this.Id.HeaderText = "Номер";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Фамилия";
            this.LastName.MaxInputLength = 30;
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Имя";
            this.FirstName.MaxInputLength = 30;
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 125;
            // 
            // MiddleName
            // 
            this.MiddleName.HeaderText = "Отчество";
            this.MiddleName.MaxInputLength = 30;
            this.MiddleName.MinimumWidth = 6;
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Width = 125;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "Дата рождения";
            this.DateOfBirth.MaxInputLength = 30;
            this.DateOfBirth.MinimumWidth = 6;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Width = 125;
            // 
            // PassportData
            // 
            this.PassportData.HeaderText = "Паспортные данные (серия номер)";
            this.PassportData.MaxInputLength = 11;
            this.PassportData.MinimumWidth = 6;
            this.PassportData.Name = "PassportData";
            this.PassportData.Width = 175;
            // 
            // Address
            // 
            this.Address.HeaderText = "Место жительства";
            this.Address.MaxInputLength = 100;
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 250;
            // 
            // Email
            // 
            this.Email.HeaderText = "Почта";
            this.Email.MaxInputLength = 70;
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Номер телефона";
            this.PhoneNumber.MaxInputLength = 18;
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Width = 125;
            // 
            // Position
            // 
            this.Position.HeaderText = "Должность";
            this.Position.MaxInputLength = 70;
            this.Position.MinimumWidth = 6;
            this.Position.Name = "Position";
            this.Position.Width = 125;
            // 
            // WorkPlace
            // 
            this.WorkPlace.HeaderText = "Место работы";
            this.WorkPlace.MaxInputLength = 70;
            this.WorkPlace.MinimumWidth = 6;
            this.WorkPlace.Name = "WorkPlace";
            this.WorkPlace.Width = 125;
            // 
            // AllFacesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 608);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dealBtn);
            this.Controls.Add(this.educationBtn);
            this.Controls.Add(this.facesGridView);
            this.Controls.Add(this.LoginLabel);
            this.MaximumSize = new System.Drawing.Size(1412, 608);
            this.MinimumSize = new System.Drawing.Size(1412, 608);
            this.Name = "AllFacesForm";
            this.Text = "Все физические лица";
            ((System.ComponentModel.ISupportInitialize)(this.facesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.DataGridView facesGridView;
        private MaterialSkin.Controls.MaterialFlatButton educationBtn;
        private MaterialSkin.Controls.MaterialFlatButton dealBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassportData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkPlace;
    }
}
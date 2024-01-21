namespace documentManagement
{
    partial class DealListForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.physBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.educationBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.dealGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllEducation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassportData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dealGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(36, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1089, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Чтобы создать квитанцию или печатную форму договора,  нажмите на пустое пространс" +
    "тво в списке, левее номера договора\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Список всех договоров:";
            // 
            // physBtn
            // 
            this.physBtn.AutoSize = true;
            this.physBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.physBtn.Depth = 0;
            this.physBtn.Location = new System.Drawing.Point(815, 107);
            this.physBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.physBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.physBtn.Name = "physBtn";
            this.physBtn.Primary = false;
            this.physBtn.Size = new System.Drawing.Size(244, 36);
            this.physBtn.TabIndex = 33;
            this.physBtn.Text = "Список физических лиц";
            this.physBtn.UseVisualStyleBackColor = true;
            this.physBtn.Click += new System.EventHandler(this.physBtn_Click);
            // 
            // educationBtn
            // 
            this.educationBtn.AutoSize = true;
            this.educationBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.educationBtn.Depth = 0;
            this.educationBtn.Location = new System.Drawing.Point(400, 107);
            this.educationBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.educationBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.educationBtn.Name = "educationBtn";
            this.educationBtn.Primary = false;
            this.educationBtn.Size = new System.Drawing.Size(359, 36);
            this.educationBtn.TabIndex = 32;
            this.educationBtn.Text = "Список образовательных программ";
            this.educationBtn.UseVisualStyleBackColor = true;
            this.educationBtn.Click += new System.EventHandler(this.educationBtn_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(1226, 110);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(68, 25);
            this.LoginLabel.TabIndex = 31;
            this.LoginLabel.Text = "Логин";
            // 
            // dealGridView
            // 
            this.dealGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dealGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dealGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dealGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Date,
            this.TotalCost,
            this.AllEducation,
            this.LastName,
            this.FirstName,
            this.MiddleName,
            this.DateOfBirth,
            this.PassportData,
            this.PhoneNumber,
            this.Address});
            this.dealGridView.Location = new System.Drawing.Point(40, 190);
            this.dealGridView.Name = "dealGridView";
            this.dealGridView.ReadOnly = true;
            this.dealGridView.RowHeadersWidth = 51;
            this.dealGridView.RowTemplate.Height = 24;
            this.dealGridView.Size = new System.Drawing.Size(1319, 376);
            this.dealGridView.TabIndex = 36;
            this.dealGridView.SelectionChanged += new System.EventHandler(this.dealGridView_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Номер";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // TotalCost
            // 
            this.TotalCost.HeaderText = "Полная стоимость";
            this.TotalCost.MinimumWidth = 6;
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            this.TotalCost.Width = 125;
            // 
            // AllEducation
            // 
            this.AllEducation.HeaderText = "Список курсов";
            this.AllEducation.MinimumWidth = 6;
            this.AllEducation.Name = "AllEducation";
            this.AllEducation.ReadOnly = true;
            this.AllEducation.Width = 250;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Фамилия";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Имя";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 125;
            // 
            // MiddleName
            // 
            this.MiddleName.HeaderText = "Отчество";
            this.MiddleName.MinimumWidth = 6;
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.ReadOnly = true;
            this.MiddleName.Width = 125;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "Дата рождения клиента";
            this.DateOfBirth.MinimumWidth = 6;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            this.DateOfBirth.Width = 125;
            // 
            // PassportData
            // 
            this.PassportData.HeaderText = "Паспортные данные";
            this.PassportData.MinimumWidth = 6;
            this.PassportData.Name = "PassportData";
            this.PassportData.ReadOnly = true;
            this.PassportData.Width = 125;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Номер телефона";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Место жительства";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 250;
            // 
            // DealListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 608);
            this.Controls.Add(this.dealGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.physBtn);
            this.Controls.Add(this.educationBtn);
            this.Controls.Add(this.LoginLabel);
            this.MaximumSize = new System.Drawing.Size(1412, 608);
            this.MinimumSize = new System.Drawing.Size(1412, 608);
            this.Name = "DealListForm";
            this.Text = "Все договоры";
            ((System.ComponentModel.ISupportInitialize)(this.dealGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialFlatButton physBtn;
        private MaterialSkin.Controls.MaterialFlatButton educationBtn;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.DataGridView dealGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllEducation;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassportData;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}
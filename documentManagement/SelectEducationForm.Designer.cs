namespace documentManagement
{
    partial class SelectEducationForm
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
            this.educationGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dealBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.physLbl = new System.Windows.Forms.Label();
            this.createDealBtn = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.educationGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // educationGridView
            // 
            this.educationGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.educationGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.educationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.educationGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Qualification,
            this.Cost,
            this.Period});
            this.educationGridView.Location = new System.Drawing.Point(48, 206);
            this.educationGridView.Name = "educationGridView";
            this.educationGridView.ReadOnly = true;
            this.educationGridView.RowHeadersWidth = 51;
            this.educationGridView.RowTemplate.Height = 24;
            this.educationGridView.Size = new System.Drawing.Size(1319, 376);
            this.educationGridView.TabIndex = 39;
            // 
            // Id
            // 
            this.Id.HeaderText = "Номер";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // Title
            // 
            this.Title.HeaderText = "Название";
            this.Title.MaxInputLength = 100;
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 125;
            // 
            // Qualification
            // 
            this.Qualification.HeaderText = "Квалификация";
            this.Qualification.MaxInputLength = 100;
            this.Qualification.MinimumWidth = 6;
            this.Qualification.Name = "Qualification";
            this.Qualification.ReadOnly = true;
            this.Qualification.Width = 125;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Стоимость";
            this.Cost.MaxInputLength = 10;
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 125;
            // 
            // Period
            // 
            this.Period.HeaderText = "Период обучения";
            this.Period.MinimumWidth = 6;
            this.Period.Name = "Period";
            this.Period.ReadOnly = true;
            this.Period.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Список всех образовательных программ";
            // 
            // dealBtn
            // 
            this.dealBtn.AutoSize = true;
            this.dealBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dealBtn.Depth = 0;
            this.dealBtn.Location = new System.Drawing.Point(514, 96);
            this.dealBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dealBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.dealBtn.Name = "dealBtn";
            this.dealBtn.Primary = false;
            this.dealBtn.Size = new System.Drawing.Size(297, 36);
            this.dealBtn.TabIndex = 37;
            this.dealBtn.Text = "Отменить создание договора";
            this.dealBtn.UseVisualStyleBackColor = true;
            this.dealBtn.Click += new System.EventHandler(this.dealBtn_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(1215, 99);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(68, 25);
            this.LoginLabel.TabIndex = 35;
            this.LoginLabel.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(44, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1546, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Выберите образовательны курсы (удерживайте ctrl и нажимайте на пустое пространств" +
    "о слева от номера, чтобы выбрать несколько программ)";
            // 
            // physLbl
            // 
            this.physLbl.AutoSize = true;
            this.physLbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.physLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.physLbl.Location = new System.Drawing.Point(44, 169);
            this.physLbl.Name = "physLbl";
            this.physLbl.Size = new System.Drawing.Size(167, 20);
            this.physLbl.TabIndex = 41;
            this.physLbl.Text = "Физическое лицо: ";
            // 
            // createDealBtn
            // 
            this.createDealBtn.AutoSize = true;
            this.createDealBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createDealBtn.Depth = 0;
            this.createDealBtn.Location = new System.Drawing.Point(850, 96);
            this.createDealBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createDealBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.createDealBtn.Name = "createDealBtn";
            this.createDealBtn.Primary = false;
            this.createDealBtn.Size = new System.Drawing.Size(176, 36);
            this.createDealBtn.TabIndex = 42;
            this.createDealBtn.Text = "Создать договор";
            this.createDealBtn.UseVisualStyleBackColor = true;
            this.createDealBtn.Click += new System.EventHandler(this.createDealBtn_Click);
            // 
            // SelectEducationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 608);
            this.Controls.Add(this.createDealBtn);
            this.Controls.Add(this.physLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.educationGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dealBtn);
            this.Controls.Add(this.LoginLabel);
            this.MaximumSize = new System.Drawing.Size(1412, 608);
            this.MinimumSize = new System.Drawing.Size(1412, 608);
            this.Name = "SelectEducationForm";
            this.Text = "Выбор образовательных программ";
            this.Load += new System.EventHandler(this.SelectEducationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.educationGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView educationGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Period;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialFlatButton dealBtn;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label physLbl;
        private MaterialSkin.Controls.MaterialFlatButton createDealBtn;
    }
}
namespace documentManagement
{
    partial class EducationForm
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
            this.dealBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.physBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.educationGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.educationGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Список всех образовательных программ";
            // 
            // dealBtn
            // 
            this.dealBtn.AutoSize = true;
            this.dealBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dealBtn.Depth = 0;
            this.dealBtn.Location = new System.Drawing.Point(906, 103);
            this.dealBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dealBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.dealBtn.Name = "dealBtn";
            this.dealBtn.Primary = false;
            this.dealBtn.Size = new System.Drawing.Size(190, 36);
            this.dealBtn.TabIndex = 32;
            this.dealBtn.Text = "Список договоров";
            this.dealBtn.UseVisualStyleBackColor = true;
            this.dealBtn.Click += new System.EventHandler(this.dealBtn_Click);
            // 
            // physBtn
            // 
            this.physBtn.AutoSize = true;
            this.physBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.physBtn.Depth = 0;
            this.physBtn.Location = new System.Drawing.Point(580, 103);
            this.physBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.physBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.physBtn.Name = "physBtn";
            this.physBtn.Primary = false;
            this.physBtn.Size = new System.Drawing.Size(244, 36);
            this.physBtn.TabIndex = 31;
            this.physBtn.Text = "Список физических лиц";
            this.physBtn.UseVisualStyleBackColor = true;
            this.physBtn.Click += new System.EventHandler(this.physBtn_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(1226, 109);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(68, 25);
            this.LoginLabel.TabIndex = 30;
            this.LoginLabel.Text = "Логин";
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
            this.educationGridView.Location = new System.Drawing.Point(36, 172);
            this.educationGridView.Name = "educationGridView";
            this.educationGridView.RowHeadersWidth = 51;
            this.educationGridView.RowTemplate.Height = 24;
            this.educationGridView.Size = new System.Drawing.Size(1319, 376);
            this.educationGridView.TabIndex = 34;
            this.educationGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.educationGridView_CellEndEdit);
            this.educationGridView.SelectionChanged += new System.EventHandler(this.educationGridView_SelectionChanged);
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
            // Title
            // 
            this.Title.HeaderText = "Название";
            this.Title.MaxInputLength = 100;
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.Width = 125;
            // 
            // Qualification
            // 
            this.Qualification.HeaderText = "Квалификация";
            this.Qualification.MaxInputLength = 100;
            this.Qualification.MinimumWidth = 6;
            this.Qualification.Name = "Qualification";
            this.Qualification.Width = 125;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Стоимость";
            this.Cost.MaxInputLength = 10;
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.Width = 125;
            // 
            // Period
            // 
            this.Period.HeaderText = "Период обучения";
            this.Period.MinimumWidth = 6;
            this.Period.Name = "Period";
            this.Period.Width = 125;
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.infoLbl.Location = new System.Drawing.Point(32, 145);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(1175, 25);
            this.infoLbl.TabIndex = 36;
            this.infoLbl.Text = "Чтобы удалить образовательную программу,  нажмите на пустое пространство в списке" +
    ", левее его названия\r\n";
            // 
            // EducationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 608);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.educationGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dealBtn);
            this.Controls.Add(this.physBtn);
            this.Controls.Add(this.LoginLabel);
            this.MaximumSize = new System.Drawing.Size(1412, 608);
            this.MinimumSize = new System.Drawing.Size(1412, 608);
            this.Name = "EducationForm";
            this.Text = "Все образовательные программы";
            this.Load += new System.EventHandler(this.EducationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.educationGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialFlatButton dealBtn;
        private MaterialSkin.Controls.MaterialFlatButton physBtn;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.DataGridView educationGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Period;
        private System.Windows.Forms.Label infoLbl;
    }
}
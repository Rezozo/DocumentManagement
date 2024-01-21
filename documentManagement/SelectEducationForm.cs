using documentManagement.files;
using documentManagement.models;
using documentManagement.provider;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace documentManagement
{
    public partial class SelectEducationForm : MaterialForm
    {
        private EducationProvider educationProvider;
        private DealProvider dealProvider;
        private PFace _physFace;
        private FileCreater fileCreater;
        public SelectEducationForm()
        {
            InitializeComponent();
            educationProvider = new EducationProvider();
            dealProvider = new DealProvider();
            fileCreater = new FileCreater();
            UpdatePrograms();
        }

        public string LoginLabelText
        {
            get { return LoginLabel.Text; }
            set { LoginLabel.Text = value; }
        }

        public PFace physFace { get { return _physFace; } set { _physFace = value; } } 

        private void UpdatePrograms()
        {
            List<EducationProgram> programs = educationProvider.getAll();
            educationGridView.Rows.Clear();
            foreach (EducationProgram program in programs)
            {
                int rowIndex = educationGridView.Rows.Add(program.id, program.title, program.qualification, program.cost, program.period);
                educationGridView.Rows[rowIndex].Tag = program;
            }
        }

        private void dealBtn_Click(object sender, EventArgs e)
        {
            Hide();
            AllFacesForm faceForm = new AllFacesForm();
            faceForm.LoginLabelText = LoginLabelText;
            faceForm.FormClosed += (s, args) => Close();
            faceForm.Show();
        }

        private void SelectEducationForm_Load(object sender, EventArgs e)
        {
            physLbl.Text += _physFace.lastName + " " + physFace.firstName + " " + physFace.middleName;
        }

        private void createDealBtn_Click(object sender, EventArgs e)
        {
            if (educationGridView.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection rows = educationGridView.SelectedRows;
                List<EducationProgram> educationPrograms = new List<EducationProgram>();
                decimal totalCost = 0;
                foreach (DataGridViewRow row in rows)
                {
                    EducationProgram educationProgram = new EducationProgram((int)row.Cells["Id"].Value, row.Cells["Title"].Value.ToString(), row.Cells["Qualification"].Value.ToString(),
                        decimal.Parse(row.Cells["Cost"].Value.ToString()), row.Cells["Period"].Value.ToString());
                    totalCost += decimal.Parse(row.Cells["Cost"].Value.ToString());
                    educationPrograms.Add(educationProgram);
                }

                Deal createdDeal = dealProvider.createAndReturnDeal(educationPrograms, _physFace, totalCost);

                SelectFormats selectFormats = new SelectFormats();
                DialogResult result = selectFormats.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string selectedFormat = selectFormats.SelectedFormat;
                    string fileName = selectFormats.FileName;

                    if (selectedFormat.Equals("PDF"))
                    {
                        fileCreater.GeneratePDF(fileName, createdDeal);                    
                    } else
                    {
                        fileCreater.GenerateTXT(fileName, createdDeal);
                    }

                    DialogResult paymentResult = MessageBox.Show("Создать квитанцию на оплату?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (paymentResult == DialogResult.Yes)
                    {
                        fileCreater.GeneratePdfPaymentList(fileName, createdDeal);
                    }

                    Hide();
                    DealListForm dealListForm = new DealListForm();
                    dealListForm.LoginLabelText = LoginLabel.Text;
                    dealListForm.FormClosed += (s, args) => Close();
                    dealListForm.ShowDialog();
                }

            } else
            {
                MessageBox.Show("Выберите образовательные курсы из списка");
            }
        }
    }
}

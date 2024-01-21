using documentManagement.models;
using documentManagement.provider;
using MaterialSkin.Controls;
using System.Collections.Generic;

namespace documentManagement
{
    public partial class DealListForm : MaterialForm
    {
        private DealProvider dealProvider;
        public DealListForm()
        {
            InitializeComponent();
            dealProvider = new DealProvider();
            UpdatePrograms();
        }

        private void UpdatePrograms()
        {
            List<Deal> deals = dealProvider.getAll();
            dealGridView.Rows.Clear();
            foreach (Deal deal in deals)
            {
                PFace physicalFace = deal.physicalFace;
                string courses = "";
                foreach (EducationProgram educationProgram in deal.educationPrograms)
                {
                    courses += educationProgram.title + "; ";
                }
                int rowIndex = dealGridView.Rows.Add(deal.id, deal.date.Date, deal.totalCost, courses, physicalFace.lastName, physicalFace.firstName, physicalFace.middleName,
                    physicalFace.dateOfBirth.Date, physicalFace.passportData, physicalFace.phoneNumber, physicalFace.address);
                dealGridView.Rows[rowIndex].Tag = deal;
            }
        }

        public string LoginLabelText
        {
            get { return LoginLabel.Text; }
            set { LoginLabel.Text = value; }
        }

        private void educationBtn_Click(object sender, System.EventArgs e)
        {
            Hide();
            EducationForm educationForm = new EducationForm();
            educationForm.LoginLabelText = LoginLabel.Text;
            educationForm.FormClosed += (s, args) => Close();
            educationForm.Show();
        }

        private void physBtn_Click(object sender, System.EventArgs e)
        {
            Hide();
            AllFacesForm physForm = new AllFacesForm();
            physForm.LoginLabelText = LoginLabel.Text;
            physForm.FormClosed += (s, args) => Close();
            physForm.Show();
        }
    }
}

using documentManagement.models;
using documentManagement.provider;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace documentManagement
{
    public partial class AllFacesForm : MaterialForm
    {
        private PFaceProvider pfaceProvider;
        public AllFacesForm()
        {
            InitializeComponent();
            pfaceProvider = new PFaceProvider();
            UpdateFaces();
        }

        private void UpdateFaces()
        {
            List<PFace> pFaces = pfaceProvider.getAll();
            facesGridView.Rows.Clear();
            foreach (PFace face in pFaces)
            {
                int rowIndex = facesGridView.Rows.Add(face.Id, face.lastName, face.firstName, face.middleName, face.dateOfBirth.ToShortDateString(), 
                    face.passportData, face.address, face.email, face.phoneNumber, face.position, face.workPlace);
                facesGridView.Rows[rowIndex].Tag = face;
            }
        }

        public string LoginLabelText
        {
            get { return LoginLabel.Text; }
            set { LoginLabel.Text = value; }
        }

        private void educationBtn_Click(object sender, EventArgs e)
        {
            Hide();
            EducationForm educationForm = new EducationForm();
            educationForm.LoginLabelText = LoginLabel.Text;
            educationForm.FormClosed += (s, args) => Close();
            educationForm.Show();
        }

        private void dealBtn_Click(object sender, EventArgs e)
        {
            Hide();
            DealListForm dealListForm = new DealListForm();
            dealListForm.LoginLabelText = LoginLabel.Text;
            dealListForm.FormClosed += (s, args) => Close();
            dealListForm.Show();
        }

        private void facesGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = facesGridView.Rows[e.RowIndex];

                if (row.Cells["Id"].Value == null)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex != facesGridView.Columns["MiddleName"].Index && cell.ColumnIndex != facesGridView.Columns["Id"].Index)
                        {
                            if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                            {
                                return;
                            }
                        }
                    }

                    string passportData = row.Cells["PassportData"].Value.ToString();
                    string dateOfBirth = row.Cells["DateOfBirth"].Value.ToString();
                    string phoneNumber = row.Cells["PhoneNumber"].Value.ToString();
                    string email = row.Cells["Email"].Value.ToString();

                    if (!isValidData(passportData, phoneNumber, dateOfBirth, email))
                    {
                        UpdateFaces();
                        return;
                    }

                    PFace pFace = new PFace(0, row.Cells["LastName"].Value.ToString(), row.Cells["FirstName"].Value.ToString(),
                        (string)row.Cells["MiddleName"].Value, DateTime.Parse(dateOfBirth), passportData,
                        row.Cells["Address"].Value.ToString(), email, phoneNumber,
                        row.Cells["Position"].Value.ToString(), row.Cells["WorkPlace"].Value.ToString());

                    pfaceProvider.saveFace(pFace);
                    UpdateFaces();
                } else
                {
                    string passportData = row.Cells["PassportData"].Value.ToString();
                    string dateOfBirth = row.Cells["DateOfBirth"].Value.ToString();
                    string phoneNumber = row.Cells["PhoneNumber"].Value.ToString();
                    string email = row.Cells["Email"].Value.ToString();

                    if (!isValidData(passportData, phoneNumber, dateOfBirth, email))
                    {
                        UpdateFaces();
                        return;
                    }

                    PFace pFace = new PFace((int)row.Cells["Id"].Value, row.Cells["LastName"].Value.ToString(), row.Cells["FirstName"].Value.ToString(),
                        (string)row.Cells["MiddleName"].Value, DateTime.Parse(dateOfBirth), passportData,
                        row.Cells["Address"].Value.ToString(), row.Cells["Email"].Value.ToString(), phoneNumber,
                        row.Cells["Position"].Value.ToString(), row.Cells["WorkPlace"].Value.ToString());
                    pfaceProvider.updateFace(pFace);
                    UpdateFaces();
                }
            }
            catch
            {
                MessageBox.Show("Зафиксируйте сохранение данных, нажатием кнопки 'Enter'!");
            }
        }

        private bool isValidData(string passportData, string phoneNumber, string date, string email)
        {
            var passportDatas = passportData.Split(' ');

            if (passportDatas.Length != 2)
            {
                MessageBox.Show("Укажите паспортные данные в формате серия номер через пробел");
                return false;
            }
            if (passportData.Count(char.IsDigit) != 10)
            {
                MessageBox.Show("Паспортные данные должны состоять только из цифр");
                return false;
            }

            try
            {
                DateTime.Parse(date);
            } catch
            {
                MessageBox.Show("Дата указана неверно, укажите в формате день.месяц.год");
                return false;
            }

            if (phoneNumber.Count(char.IsDigit) != phoneNumber.Length)
            {
                MessageBox.Show("Номер телефона должен состоять только из цифр");
                return false;
            }

            if (!email.Contains("@"))
            {
                MessageBox.Show("Почта должна содержать символ '@'");
                return false;
            }

            return true;
        }

        private void facesGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (facesGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = facesGridView.SelectedRows[0];

                Hide();
                SelectEducationForm selectEducation = new SelectEducationForm();
                selectEducation.LoginLabelText = LoginLabel.Text;
                selectEducation.physFace = new PFace((int)row.Cells["Id"].Value, row.Cells["LastName"].Value.ToString(), row.Cells["FirstName"].Value.ToString(),
                        (string)row.Cells["MiddleName"].Value, DateTime.Parse(row.Cells["DateOfBirth"].Value.ToString()), row.Cells["PassportData"].Value.ToString(),
                        row.Cells["Address"].Value.ToString(), row.Cells["Email"].Value.ToString(), row.Cells["PhoneNumber"].Value.ToString(),
                        row.Cells["Position"].Value.ToString(), row.Cells["WorkPlace"].Value.ToString());
                selectEducation.FormClosed += (s, args) => Close();
                selectEducation.Show();
            }
        }

        private void facesGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                DataGridViewRow row = e.Row;
                PFace face = (PFace)row.Tag;
                pfaceProvider.deleteById(face.Id);
                UpdateFaces();
            }
            catch
            {
                MessageBox.Show("Физическое лицо уже присутствует в договоре, удаление невозможно");
                UpdateFaces();
            }
        }
    }
}

using documentManagement.models;
using documentManagement.provider;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace documentManagement
{
    public partial class EducationForm : MaterialForm
    {
        private EducationProvider educationProvider;
        private UserProvider userProvider;

        public EducationForm()
        {
            InitializeComponent();
            educationProvider = new EducationProvider();
            userProvider = new UserProvider();
            UpdatePrograms();
        }

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

        private void EducationForm_Load(object sender, EventArgs e)
        {
            IsAdmin();
        }

        private void IsAdmin()
        {
            string role = userProvider.getRoleByLogin(LoginLabel.Text);
            if (!role.Equals("Администратор"))
            {
                educationGridView.ReadOnly = true;
                educationGridView.AllowUserToAddRows = false;
                educationGridView.AllowUserToDeleteRows = false;
                infoLbl.Visible = false;
            }
        }

        public string LoginLabelText
        {
            get { return LoginLabel.Text; }
            set { LoginLabel.Text = value; }
        }

        private void educationGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = educationGridView.Rows[e.RowIndex];

                if (row.Cells["Id"].Value == null)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex != educationGridView.Columns["Id"].Index)
                        {
                            if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                            {
                                return;
                            }
                        }
                    }

                    string cost = row.Cells["Cost"].Value.ToString();
                    string title = row.Cells["Title"].Value.ToString();

                    if (!isValidData(cost, title))
                    {
                        return;
                    }

                    EducationProgram educationProgram = new EducationProgram(0, title, row.Cells["Qualification"].Value.ToString(),
                        decimal.Parse(cost), row.Cells["Period"].Value.ToString());

                    educationProvider.insertProgram(educationProgram);
                    UpdatePrograms();
                }
                else
                {
                    DataGridViewCell cell = row.Cells[e.ColumnIndex];
                    if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        UpdatePrograms();
                        MessageBox.Show("Значение не может быть пустым");
                        return;
                    }
                    string cost = row.Cells["Cost"].Value.ToString();
                    string title = row.Cells["Title"].Value.ToString();

                    if (cell.Value.Equals(title))
                    {
                        if (!isValidData(cost, title))
                        {
                            UpdatePrograms();
                            return;
                        }
                    } else
                    {
                        if (!isValidCost(cost))
                        {
                            UpdatePrograms();
                            return;
                        }
                    }

                    EducationProgram educationProgram = new EducationProgram((int)row.Cells["Id"].Value, title, row.Cells["Qualification"].Value.ToString(),
                        decimal.Parse(cost), row.Cells["Period"].Value.ToString());
                    educationProvider.updateProgram(educationProgram);
                    UpdatePrograms();
                }
            }
            catch
            {
                MessageBox.Show("Зафиксируйте сохранение данных, нажатием кнопки 'Enter'!");
            }
        }

        private bool isValidData(string cost, string title)
        {
            if (!isValidCost(cost))
            {
                return false;
            }

            if (!educationProvider.isUniqueTitle(title))
            {
                MessageBox.Show("Название образовательной программы не должно повторяться");
                return false;
            }

            return true;
        }

        private bool isValidCost(string cost)
        {
            try
            {
                decimal.Parse(cost);
                return true;
            }
            catch
            {
                MessageBox.Show("Стоимостью является число, с двумя знаками после запятой");
                return false;
            }
        }

        private void dealBtn_Click(object sender, EventArgs e)
        {
            Hide();
            DealListForm dealListForm = new DealListForm();
            dealListForm.LoginLabelText = LoginLabel.Text;
            dealListForm.FormClosed += (s, args) => Close();
            dealListForm.Show();
        }

        private void physBtn_Click(object sender, EventArgs e)
        {
            Hide();
            AllFacesForm faceForm = new AllFacesForm();
            faceForm.LoginLabelText = LoginLabelText;
            faceForm.FormClosed += (s, args) => Close();
            faceForm.Show();
        }

        private void educationGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (educationGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = educationGridView.SelectedRows[0];
                bool deleted = educationProvider.deleteById((int)row.Cells["Id"].Value);
                if (!deleted)
                {
                    MessageBox.Show("Образовательная программа уже присутствует в договоре, удаление невозможно");
                }
                UpdatePrograms();
            }
        }
    }
}

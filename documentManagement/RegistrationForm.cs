using documentManagement.provider;
using MaterialSkin.Controls;
using Npgsql;
using System;
using System.Linq;
using System.Windows.Forms;

namespace documentManagement
{
    public partial class RegistrationForm : MaterialForm
    {
        private UserProvider usersProvider;
        public RegistrationForm()
        {
            InitializeComponent();
            usersProvider = new UserProvider();
            comboBoxRole.SelectedIndex = 0;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            goToAuth();
        }

        private void createAccBtn_Click(object sender, EventArgs e)
        {
            if (string.Empty != LoginTxt.Text 
                && string.Empty != PasswordTxt.Text 
                && string.Empty != comboBoxRole.Text
                && isValidPassword(PasswordTxt.Text))
            {
                if (usersProvider.addUser(LoginTxt.Text, PasswordTxt.Text, comboBoxRole.Text))
                {
                    goToAuth();
                }
                else
                {
                    MessageBox.Show("Пользователь с таким логином уже существует.");
                }
            }
            else
            {
                MessageBox.Show("Введите корректные данные.\nТребования к паролю: 5 букв,3 цифры " +
                    "и один или больше знаков «@#%)(.<»");
            }
        }

        private bool isValidPassword(string password)
        {
            return password.Length <= 9 &&
                password.IndexOfAny(new char[] { '@', '#', '%', ')', '(', '.', '<', '>', '«', '»' }) != -1
                && password.Count(char.IsLetter) == 5 && password.Count(char.IsDigit) == 3;
        }

        private void goToAuth()
        {
            Hide();
            AuthForm auth = new AuthForm();
            auth.FormClosed += (s, args) => Close();
            auth.Show();
        }

        private void infoLbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Требования к паролю: 5 букв,3 цифры " +
                 "и один или больше знаков «@#%)(.<»");
        }
    }
}

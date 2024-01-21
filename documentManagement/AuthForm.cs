using documentManagement.provider;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace documentManagement
{
    public partial class AuthForm : MaterialForm
    {
        private UserProvider userProvider;
        private int loginAttempts = 0;

        public AuthForm()
        {
            InitializeComponent();
            userProvider = new UserProvider();
        }

        private void authBtn_Click(object sender, System.EventArgs e)
        {
            string login = LoginTxtB.Text;
            string password = PasswordTxtB.Text;
            if (userProvider.existsByLogin(login))
            {
                if (!userProvider.isValidUser(login, password))
                {
                    loginAttempts++;
                    if (loginAttempts >= 3)
                    {
                        DialogResult result = MessageBox.Show("Сбросить пароль?", "Подтверждение сброса пароля", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            Hide();
                            ResetPasswordForm resetForm = new ResetPasswordForm();
                            resetForm.LoginLabelText = login;
                            resetForm.FormClosed += (s, args) => Close();
                            resetForm.Show();
                        }
                        else
                        {
                            loginAttempts = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Данные введены неверно!");
                    }
                }
                else
                {
                    Hide();
                    AllFacesForm allFaces = new AllFacesForm();
                    allFaces.LoginLabelText = login;
                    allFaces.FormClosed += (s, args) => Close();
                    allFaces.Show();
                }
            } else
            {
                loginAttempts = 0;
                MessageBox.Show("Пользователя с таким логином не существует");
            }
        }

        private void registrBtn_Click(object sender, System.EventArgs e)
        {
            Hide();
            RegistrationForm registr = new RegistrationForm();
            registr.FormClosed += (s, args) => Close();
            registr.Show();
        }
    }
}

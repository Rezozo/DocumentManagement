using documentManagement.provider;
using MaterialSkin.Controls;
using System.Linq;
using System.Windows.Forms;

namespace documentManagement
{
    public partial class ResetPasswordForm : MaterialForm
    {
        UserProvider userProvider;
        public ResetPasswordForm()
        {
            InitializeComponent();
            userProvider = new UserProvider();
        }

        public string LoginLabelText
        {
            get { return LoginLabel.Text; }
            set { LoginLabel.Text = value; }
        }

        private void resetBtn_Click(object sender, System.EventArgs e)
        {
            if (PasswordTxtB.Text != string.Empty 
                && PasswordTxtB2.Text != string.Empty 
                && PasswordTxtB.Text == PasswordTxtB2.Text
                && isValidPassword(PasswordTxtB.Text))
            {
                userProvider.resetPassword(PasswordTxtB.Text, LoginLabel.Text);
                Hide();
                AuthForm auth = new AuthForm();
                auth.FormClosed += (s, args) => Close();
                auth.Show();
            } else
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

        private void labl_info_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Требования к паролю: 5 букв,3 цифры " +
                "и один или больше знаков «@#%)(.<»");
        }
    }
}

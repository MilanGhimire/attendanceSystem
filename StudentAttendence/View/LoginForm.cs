using System;
using System.Windows.Forms;

namespace StudentAttendence
{
    public partial class FormLogin : Form
    {
        public static FormLogin formLogin;

        public FormLogin()
        {
            InitializeComponent();
            formLogin = this;
            formLogin.AcceptButton = LoginButton;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!LoginValidation())
            {
                return;
            }
            Controller.UserAccount userAccount = new Controller.UserAccount();
            if (userAccount.UserLoginAuthentication(UsernameTextBox.Text, PasswordTextBox.Text))
            {
                UsernameTextBox.Clear();
                PasswordTextBox.Clear();
                UsernameTextBox.Focus();
                HomeForm homeForm = new HomeForm(userAccount);
                this.Hide();
                homeForm.ShowDialog();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool LoginValidation()
        {
            if (String.IsNullOrWhiteSpace(UsernameTextBox.Text))
            {
                MessageBox.Show("Enter username.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                UsernameTextBox.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MessageBox.Show("Enter password.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PasswordTextBox.Focus();
                return false;
            }
            return true;
        }
    }
}

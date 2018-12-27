using System.Windows.Forms;

namespace StudentAttendence.View.Add
{
    public partial class ChangeUsernamePassword : Form
    {
        private string userName; //to check the username changed from orginal
        Controller.UserAccount userAccount;
        bool isAdmin;

        public ChangeUsernamePassword(Controller.UserAccount ua)
        {
            InitializeComponent();
            userName = string.Empty;
            userAccount = ua;
            isAdmin = false;
        }

        private bool ChangeUsernamePasswordValidation()
        {
            int length = UsernameTB.Text.Length;
            if (length < 5)
            {
                MessageBox.Show("Username should be at least 6 character long.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            length = 0;
            length = PasswordTB.Text.Length;
            if (length < 7)
            {
                MessageBox.Show("New Password should be at least 8 character long.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (userName == string.Empty || userName != UsernameTB.Text)
            {
                if (userAccount.CheckForUserName(UsernameTB.Text))
                {
                    MessageBox.Show("Username : '" + UsernameTB.Text + "' already exists. Please enter unique Username.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UsernameTB.Focus();
                    return false;
                }
            }

            if (!userAccount.CheckOldPassword(OldPasswordTextbox))
            {
                OldPasswordTextbox.Focus();
                return false;
            }

            //check new password and renew password
            if (!(ReEnterPassword.Text == PasswordTB.Text))
            {
                MessageBox.Show("Repassword didn't matched.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            return true;
        }

        private void ChangeUsernamePassword_Load(object sender, System.EventArgs e)
        {
            UsernameTB.ReadOnly = true;
            userAccount.GetUserName(UsernameTB);
            userName = UsernameTB.Text;
        }

        private void SubmitButton_Click(object sender, System.EventArgs e)
        {
            if (!ChangeUsernamePasswordValidation())
            {
                return;
            }
        }

        private void ChangeUsernameCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (ChangeUsernameCheckBox.Checked)
            {
                UsernameTB.ReadOnly = false;
            }
            else
            {
                UsernameTB.ReadOnly = true;
            }
        }

        private void ChangeUPCancelButton_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }
    }
}

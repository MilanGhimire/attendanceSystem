using System;
using System.Windows.Forms;

namespace StudentAttendence
{
    public partial class AddUserAccount : Form
    {
        Controller.UserAccount userAccount;
        String userName;

        public AddUserAccount()
        {
            InitializeComponent();
            userName = string.Empty;
            userAccount = new Controller.UserAccount();
        }

        public AddUserAccount(int userACID)
        {
            InitializeComponent();
            userName = string.Empty;
            userAccount = new Controller.UserAccount
            {
                ua_id = userACID
            };
        }

        private void CheckFormCall()
        {
            if (this.Owner != null)
            {
                if ((this.Owner is View.View.ViewUserAccount))
                {
                    labelAddUser.Text = "Update User";
                    textBoxPassword.Visible = false;
                    labelPassword.Visible = false;
                    userAccount.GetSingleUserAccount(comboBoxDepartmentName, comboBoxRole, textBoxUserName);
                    userName = textBoxUserName.Text;
                }
                if (this.Owner is HomeForm)
                {
                    //empty
                }
            }
        }

        private void AddUserAccount_Load(object sender, EventArgs e)
        {
            Controller.Department department = new Controller.Department();
            Controller.Role role = new Controller.Role();
            department.LoadAllDepartment(comboBoxDepartmentName);
            role.LoadAllRole(comboBoxRole);

            CheckFormCall();
        }

        private bool UserAccountValidation()
        {
            if (comboBoxDepartmentName.SelectedItem == null)
            {
                MessageBox.Show("Please select the Department.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                comboBoxDepartmentName.Focus();
                return false;
            }
            if (comboBoxRole.SelectedItem == null)
            {
                MessageBox.Show("Please select the Role.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                comboBoxRole.Focus();
                return false;
            }
            if (textBoxUserName.Text.Length < 5)
            {
                MessageBox.Show("Username should at least 6 characters long.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxUserName.Focus();
                return false;
            }

            if (userName == string.Empty || userName != textBoxUserName.Text)
            {
                if (userAccount.CheckForUserName(textBoxUserName.Text))
                {
                    MessageBox.Show(textBoxUserName.Text + " already exists. Please enter unique Department name.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxUserName.Focus();
                    return false;
                }

                if (textBoxPassword.Text.Length < 7)
                {
                    MessageBox.Show("Password name should at least 8 characters long.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBoxPassword.Focus();
                    return false;
                }
            }
            return true;
        }

        private void buttonSubjectSubmit_Click(object sender, EventArgs e)
        {
            if (!UserAccountValidation())
            {
                return;
            }

            if (this.Owner is View.View.ViewUserAccount)
            {
                if (userAccount.UpdateDepartment(Convert.ToInt32(comboBoxDepartmentName.SelectedValue), Convert.ToInt32(comboBoxRole.SelectedValue), textBoxUserName.Text))
                {
                    MessageBox.Show("Updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            if (this.Owner is HomeForm)
            {
                if (userAccount.AddNewUserAccount(Convert.ToInt32(comboBoxDepartmentName.SelectedValue), Convert.ToInt32(comboBoxRole.SelectedValue), textBoxUserName.Text, textBoxPassword.Text))
                {
                    MessageBox.Show("Inserted Successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
        }
    }
}

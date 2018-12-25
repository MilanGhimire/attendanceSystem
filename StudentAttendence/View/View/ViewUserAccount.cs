using System;
using System.Windows.Forms;

namespace StudentAttendence.View.View
{
    public partial class ViewUserAccount : Form
    {
        Controller.UserAccount userAccount;

        public ViewUserAccount()
        {
            InitializeComponent();
            userAccount = new Controller.UserAccount();
        }

        private void ViewUserAccount_Load(object sender, EventArgs e)
        {
            userAccount.GetAllUserAccountList(dataGridViewUserAccount);
        }

        private void dataGridViewUserAccount_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1 && e.Button == MouseButtons.Right)
            {
                dataGridViewUserAccount.Rows[e.RowIndex].Selected = true;
                userAccount.ua_id = Convert.ToInt32(dataGridViewUserAccount.Rows[e.RowIndex].Cells["ColumnUserAccountID"].Value);
                contextMenuStripAccount.Show();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userAccount.ua_id == 0)
            {
                MessageBox.Show("User Not Selected.");
                return;
            }

            AddUserAccount addUserAccount = new AddUserAccount(userAccount.ua_id);
            addUserAccount.ShowDialog(this);
            dataGridViewUserAccount.Rows.Clear();
            userAccount.GetAllUserAccountList(dataGridViewUserAccount);
        }
    }
}

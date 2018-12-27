using System;
using System.Windows.Forms;

namespace StudentAttendence.View.View
{
    public partial class ViewSubjectForm : Form
    {
        Controller.Subject subject;
        public Controller.UserAccount userAccount;

        public ViewSubjectForm(Controller.UserAccount ua)
        {
            InitializeComponent();
            subject = new Controller.Subject();
            userAccount = ua;
        }

        private void ViewSubjectForm_Load(object sender, EventArgs e)
        {
            Controller.Subject subject = new Controller.Subject();
            subject.GetAllSubjectList(userAccount.ua_department_id, dataGridViewSubject);
        }

        private void dataGridViewSubject_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1 && e.Button == MouseButtons.Right)
            {
                dataGridViewSubject.Rows[e.RowIndex].Selected = true;
                subject.subjectID = Convert.ToInt32(dataGridViewSubject.Rows[e.RowIndex].Cells["ColumnSubjectID"].Value);
                contextMenuStripSubject.Show();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (subject.subjectID == 0)
            {
                MessageBox.Show("Subject Not Selected.");
                return;
            }

            AddSubjectForm addSubjectForm = new AddSubjectForm(userAccount, subject.subjectID);
            addSubjectForm.ShowDialog(this);
            dataGridViewSubject.Rows.Clear();
            subject.GetAllSubjectList(userAccount.ua_department_id, dataGridViewSubject);
        }
    }
}

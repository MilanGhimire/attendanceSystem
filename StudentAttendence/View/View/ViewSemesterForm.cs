using System;
using System.Windows.Forms;

namespace StudentAttendence.View.View
{
    public partial class ViewSemesterForm : Form
    {
        Controller.Semester semester;
        public Controller.UserAccount userAccount;

        public ViewSemesterForm(Controller.UserAccount ua)
        {
            InitializeComponent();
            semester = new Controller.Semester();
            userAccount = ua;
        }

        private void ViewSemesterForm_Load(object sender, EventArgs e)
        {
            semester.GetAllSemesterList(userAccount.ua_department_id, dataGridViewSemester);
        }

        private void dataGridViewSemester_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1 && e.Button == MouseButtons.Right)
            {
                dataGridViewSemester.Rows[e.RowIndex].Selected = true;
                semester.semesterID = Convert.ToInt32(dataGridViewSemester.Rows[e.RowIndex].Cells["ColumnSemesterID"].Value);
                MessageBox.Show(semester.semesterID.ToString());
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (semester.semesterID == 0)
            {
                MessageBox.Show("Semester Not Selected.");
                return;
            }

            AddSemesterForm addSemesterForm = new AddSemesterForm();
            addSemesterForm.ShowDialog(this);
            dataGridViewSemester.Rows.Clear();
            semester.GetAllSemesterList(userAccount.ua_department_id, dataGridViewSemester);
        }
    }
}

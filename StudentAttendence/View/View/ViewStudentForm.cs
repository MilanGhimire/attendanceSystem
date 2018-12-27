using System;
using System.Windows.Forms;

namespace StudentAttendence
{
    public partial class ViewStudentForm : Form
    {
        Controller.Student student;
        public Controller.UserAccount userAccount;

        public ViewStudentForm(Controller.UserAccount ua)
        {
            InitializeComponent();
            student = new Controller.Student();
            userAccount = ua;
        }

        private void ViewStudentForm_Load(object sender, EventArgs e)
        {
            student.GetAllStudentList(dataGridViewStudent);
        }

        private void dataGridViewStudent_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1 && e.Button == MouseButtons.Right)
            {
                dataGridViewStudent.Rows[e.RowIndex].Selected = true;
                student.studentID = Convert.ToInt32(dataGridViewStudent.Rows[e.RowIndex].Cells["ColumnStudentID"].Value);
                //MessageBox.Show(student.studentID.ToString());
                contextMenuStripStudent.Show();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (student.studentID == 0)
            {
                MessageBox.Show("Student Not Selected.");
                return;
            }

            AddStudentForm addStudentForm = new AddStudentForm(userAccount, student.studentID);
            addStudentForm.ShowDialog(this);
            dataGridViewStudent.Rows.Clear();
            student.GetAllStudentList(dataGridViewStudent);
        }
    }
}

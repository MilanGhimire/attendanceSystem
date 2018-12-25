using System;
using System.Windows.Forms;

namespace StudentAttendence.View.View
{
    public partial class ViewTeacherForm : Form
    {
        Controller.Teacher teacher;

        public ViewTeacherForm()
        {
            InitializeComponent();
            teacher = new Controller.Teacher();
        }

        private void ViewTeacherForm_Load(object sender, EventArgs e)
        {
            teacher.GetAllTeacherList(dataGridViewTeacher);
        }

        private void dataGridViewTeacher_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1 && e.Button == MouseButtons.Right)
            {
                dataGridViewTeacher.Rows[e.RowIndex].Selected = true;
                teacher.teacherID = Convert.ToInt32(dataGridViewTeacher.Rows[e.RowIndex].Cells["ColumnTeacherID"].Value);
                contextMenuStripTeacher.Show();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (teacher.teacherID == 0)
            {
                MessageBox.Show("Teacher Not Selected.");
                return;
            }

            AddTeacherForm addTeacherForm = new AddTeacherForm(teacher.teacherID);
            addTeacherForm.ShowDialog(this);
            dataGridViewTeacher.Rows.Clear();
            teacher.GetAllTeacherList(dataGridViewTeacher);
        }
    }
}

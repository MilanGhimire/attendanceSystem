using System;
using System.Windows.Forms;

namespace StudentAttendence
{
    public partial class HomeForm : Form
    {
        Controller.UserAccount userAccount;

        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormLogin.formLogin.Dispose();
            Application.Exit();
        }

        private void addSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSectionForm addSectionForm = new AddSectionForm();
            addSectionForm.ShowDialog(this);
        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDepartmentForm addDepartmentForm = new AddDepartmentForm();
            addDepartmentForm.ShowDialog(this);
        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeacherForm addTeacherForm = new AddTeacherForm();
            addTeacherForm.ShowDialog(this);
        }

        private void addSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSubjectForm addSubjectForm = new AddSubjectForm();
            addSubjectForm.ShowDialog(this);
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.ShowDialog(this);
        }

        private void addUserAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserAccount addUserAccount = new AddUserAccount();
            addUserAccount.ShowDialog(this);
        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudentForm viewStudentForm = new ViewStudentForm();
            viewStudentForm.ShowDialog();
        }

        private void viewTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.View.ViewTeacherForm viewTeacherForm = new View.View.ViewTeacherForm();
            viewTeacherForm.ShowDialog();
        }

        private void viewSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.View.ViewSemesterForm viewSemesterForm = new View.View.ViewSemesterForm();
            viewSemesterForm.ShowDialog();
        }

        private void viewSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.View.ViewSubjectForm viewSubjectForm = new View.View.ViewSubjectForm();
            viewSubjectForm.ShowDialog();
        }

        private void viewSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.View.ViewSectionForm viewSectionForm = new View.View.ViewSectionForm();
            viewSectionForm.ShowDialog();
        }

        private void viewDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewDepartmentForm viewDepartmentForm = new ViewDepartmentForm();
            viewDepartmentForm.ShowDialog();
        }

        private void viewUserAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.View.ViewUserAccount viewUserAccount = new View.View.ViewUserAccount();
            viewUserAccount.ShowDialog();
        }
    }
}

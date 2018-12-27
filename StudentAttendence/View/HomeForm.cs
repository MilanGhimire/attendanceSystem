using System;
using System.Windows.Forms;

namespace StudentAttendence
{
    public partial class HomeForm : Form
    {
        public Controller.UserAccount userAccount;

        public HomeForm(Controller.UserAccount ua)
        {
            InitializeComponent();
            userAccount = ua;
        }

        private void addSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSectionForm addSectionForm = new AddSectionForm(userAccount);
            addSectionForm.ShowDialog(this);
        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDepartmentForm addDepartmentForm = new AddDepartmentForm();
            addDepartmentForm.ShowDialog(this);
        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeacherForm addTeacherForm = new AddTeacherForm(userAccount);
            addTeacherForm.ShowDialog(this);
        }

        private void addSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSubjectForm addSubjectForm = new AddSubjectForm(userAccount);
            addSubjectForm.ShowDialog(this);
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm(userAccount);
            addStudentForm.ShowDialog(this);
        }

        private void addUserAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserAccount addUserAccount = new AddUserAccount();
            addUserAccount.ShowDialog(this);
        }

        private void changeUsernamePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.Add.ChangeUsernamePassword changeUsernamePassword = new View.Add.ChangeUsernamePassword(userAccount);
            changeUsernamePassword.ShowDialog(this);
        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudentForm viewStudentForm = new ViewStudentForm(userAccount);
            viewStudentForm.ShowDialog();
        }

        private void viewTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.View.ViewTeacherForm viewTeacherForm = new View.View.ViewTeacherForm(userAccount);
            viewTeacherForm.ShowDialog();
        }

        private void viewSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.View.ViewSemesterForm viewSemesterForm = new View.View.ViewSemesterForm(userAccount);
            viewSemesterForm.ShowDialog();
        }

        private void viewSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.View.ViewSubjectForm viewSubjectForm = new View.View.ViewSubjectForm(userAccount);
            viewSubjectForm.ShowDialog();
        }

        private void viewSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.View.ViewSectionForm viewSectionForm = new View.View.ViewSectionForm(userAccount);
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

        private void HomeForm_Load(object sender, EventArgs e)
        {
            Controller.Role role = new Controller.Role();
            //for admin
            if (role.GetRoleName(userAccount.ua_role) == "Admin")
            {
                labelDepartmentTitle.Text = "Welcome to Attandance System.\nRole : " + role.GetRoleName(userAccount.ua_role);
                addStudentToolStripMenuItem.Visible = false;
                addTeacherToolStripMenuItem.Visible = false;
                addSectionToolStripMenuItem.Visible = false;
                addSubjectToolStripMenuItem.Visible = false;
            }
            else
            {
                Controller.Department department = new Controller.Department();
                labelDepartmentTitle.Text = "Welcome to :" + department.GetDepartmentName(userAccount.ua_department_id) + " department.\nRole : " + role.GetRoleName(userAccount.ua_role);
                //add
                addDepartmentToolStripMenuItem.Visible = false;
                addUserAccountToolStripMenuItem.Visible = false;
                //view
                viewDepartmentToolStripMenuItem.Visible = false;
                viewUserAccountToolStripMenuItem.Visible = false;
            }
        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormLogin.formLogin.Show();
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("exit");
            FormLogin.formLogin.Dispose();
            Application.Exit();
        }

        private void buttonViewAttandance_Click(object sender, EventArgs e)
        {
            View.View.ViewTodayAttandance viewTodayAttandance = new View.View.ViewTodayAttandance(userAccount);
            viewTodayAttandance.ShowDialog();
        }

        private void buttonViewFullAttandance_Click(object sender, EventArgs e)
        {
            AttandenceForm attandenceForm = new AttandenceForm();
            attandenceForm.ShowDialog();
        }
    }
}

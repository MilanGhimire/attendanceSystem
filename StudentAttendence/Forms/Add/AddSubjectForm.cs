using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendence
{
    public partial class AddSubjectForm : Form
    {
        public AddSubjectForm()
        {
            InitializeComponent();
        }

        private void AddSubjectForm_Load(object sender, EventArgs e)
        {
            Controller.Semester semester = new Controller.Semester();
            Controller.Teacher teacher = new Controller.Teacher();
            semester.LoadAllSemester(1, comboBoxSemesterName);
            teacher.LoadAllTeacher(1, comboBoxTeacherName);
        }

        private void buttonSubjectSubmit_Click(object sender, EventArgs e)
        {
            //ToDo check teacher teaching two subjects in a semester
            if (!SubjectValidation())
            {
                return;
            }

            Controller.Subject subject = new Controller.Subject();
            if (subject.CheckForSubjectName(Convert.ToInt32(comboBoxSemesterName.SelectedValue), textBoxSubjectName.Text, 1))
            {
                MessageBox.Show(textBoxSubjectName.Text + " is already added.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (subject.AddNewSubject(1, Convert.ToInt32(comboBoxSemesterName.SelectedValue), textBoxSubjectName.Text, Convert.ToInt32(comboBoxTeacherName.SelectedValue)))
            {
                MessageBox.Show("Inserted Successfully.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }

        private bool SubjectValidation()
        {
            if (comboBoxSemesterName.SelectedItem == null)
            {
                MessageBox.Show("Please select the Semester.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                comboBoxSemesterName.Focus();
                return false;
            }
            if (textBoxSubjectName.Text.Length < 5)
            {
                MessageBox.Show("Subject name should at least 6 characters long.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxSubjectName.Focus();
                return false;
            }

            if (comboBoxTeacherName.SelectedItem == null)
            {
                MessageBox.Show("Please select the Teacher.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                comboBoxTeacherName.Focus();
                return false;
            }
            return true;
        }
    }
}

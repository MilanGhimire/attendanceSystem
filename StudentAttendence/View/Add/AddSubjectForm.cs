using System;
using System.Windows.Forms;

namespace StudentAttendence
{
    public partial class AddSubjectForm : Form
    {
        Controller.Subject subject;
        String subjectName;

        public AddSubjectForm()
        {
            InitializeComponent();
            subjectName = string.Empty;
            subject = new Controller.Subject();
        }

        public AddSubjectForm(int subID)
        {
            InitializeComponent();
            subjectName = string.Empty;
            subject = new Controller.Subject
            {
                subjectID = subID
            };
        }

        private void CheckFormCall()
        {
            if (this.Owner != null)
            {
                if ((this.Owner is View.View.ViewSubjectForm))
                {
                    labelAddSubject.Text = "Update Subject";
                    subject.GetSingleSubject(comboBoxSemesterName, textBoxSubjectName, comboBoxTeacherName);
                    subjectName = textBoxSubjectName.Text;
                }
                if (this.Owner is HomeForm)
                {
                    comboBoxSemesterName.SelectedItem = null;
                    comboBoxTeacherName.SelectedItem = null;
                }
            }
        }

        private void AddSubjectForm_Load(object sender, EventArgs e)
        {
            Controller.Semester semester = new Controller.Semester();
            Controller.Teacher teacher = new Controller.Teacher();
            semester.LoadAllSemester(1, comboBoxSemesterName);
            teacher.LoadAllTeacher(1, comboBoxTeacherName);

            CheckFormCall();
        }

        private void buttonSubjectSubmit_Click(object sender, EventArgs e)
        {
            //ToDo check teacher teaching two subjects in a semester
            if (!SubjectValidation())
            {
                return;
            }

            if (subjectName != textBoxSubjectName.Text)
            {
                if (subject.CheckForSubjectName(Convert.ToInt32(comboBoxSemesterName.SelectedValue), textBoxSubjectName.Text, 1))
                {
                    MessageBox.Show(textBoxSubjectName.Text + " is already added.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if ((this.Owner is View.View.ViewSubjectForm))
            {
                if (subject.UpdateSubject(1, Convert.ToInt32(comboBoxSemesterName.SelectedValue), textBoxSubjectName.Text, Convert.ToInt32(comboBoxTeacherName.SelectedValue)))
                {
                    MessageBox.Show("Updated Successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            if (this.Owner is HomeForm)
            {
                if (subject.AddNewSubject(1, Convert.ToInt32(comboBoxSemesterName.SelectedValue), textBoxSubjectName.Text, Convert.ToInt32(comboBoxTeacherName.SelectedValue)))
                {
                    MessageBox.Show("Inserted Successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
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

using System;
using System.Windows.Forms;

namespace StudentAttendence
{
    public partial class AddStudentForm : Form
    {
        Controller.Student student;

        public AddStudentForm()
        {
            InitializeComponent();
            student = new Controller.Student();
        }

        public AddStudentForm(int stdID)
        {
            InitializeComponent();
            student = new Controller.Student
            {
                studentID = stdID
            };
        }

        private void CheckFormCall()
        {
            if (this.Owner != null)
            {
                if ((this.Owner is ViewStudentForm))
                {
                    LabelAddStudentTitle.Text = "Update Student";
                    Controller.Section section = new Controller.Section();
                    section.LoadAllSection(1, Convert.ToInt32(comboBoxSemester.SelectedValue), comboBoxSection);
                    student.GetSingleStudent(textBoxStudentName, textBoxCardNumber, textBoxStudentContact, textBoxParentContact, textBoxAddress, textBoxEmail, comboBoxSemester, comboBoxSection);
                }
                if (this.Owner is HomeForm)
                {
                    comboBoxSemester.SelectedItem = null;
                    comboBoxSection.SelectedItem = null;
                }
            }
        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            if (!StudentValidation())
            {
                return;
            }

            if ((this.Owner is ViewStudentForm))
            {
                if (student.UpdateStudent(1, Convert.ToInt32(comboBoxSemester.SelectedValue), Convert.ToInt32(comboBoxSection.SelectedValue), textBoxStudentName.Text, Convert.ToInt32(textBoxCardNumber.Text), Convert.ToDouble(textBoxStudentContact.Text), Convert.ToDouble(textBoxParentContact.Text), textBoxAddress.Text, textBoxEmail.Text))
                {
                    MessageBox.Show("Updated Successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            if (this.Owner is HomeForm)
            {
                if (student.AddNewStudent(1, Convert.ToInt32(comboBoxSemester.SelectedValue), Convert.ToInt32(comboBoxSection.SelectedValue), textBoxStudentName.Text, Convert.ToInt32(textBoxCardNumber.Text), Convert.ToDouble(textBoxStudentContact.Text), Convert.ToDouble(textBoxParentContact.Text), textBoxAddress.Text, textBoxEmail.Text))
                {
                    MessageBox.Show("Inserted Successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
        }

        private bool StudentValidation()
        {
            //Student Name
            if (String.IsNullOrWhiteSpace(textBoxStudentName.Text))
            {
                MessageBox.Show("Please fill student name.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBoxStudentName.Focus();
                return false;
            }
            if ((textBoxStudentName.Text).Length < 3)
            {
                MessageBox.Show("Student name should be atleast 3 character long.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBoxStudentName.Focus();
                return false;
            }

            //Id card
            if ((textBoxCardNumber.Text).Length < 4)
            {
                MessageBox.Show("Student ID card should be atleast 4 digits.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBoxCardNumber.Focus();
                return false;
            }

            //Student contact
            if ((textBoxStudentContact.Text).Length != 10)
            {
                MessageBox.Show("Student contact should be 10 digits.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBoxStudentContact.Focus();
                return false;
            }

            //Parent Contact
            if ((textBoxParentContact.Text).Length != 10)
            {
                MessageBox.Show("Parent contact card should be 10 digits.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBoxParentContact.Focus();
                return false;
            }

            //Student address
            if (String.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                MessageBox.Show("Please fill student address.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBoxAddress.Focus();
                return false;
            }
            if ((textBoxAddress.Text).Length < 4)
            {
                MessageBox.Show("Student address should be atleast 4 characters long.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBoxAddress.Focus();
                return false;
            }

            //Student email
            if ((textBoxEmail.Text).Length < 8)
            {
                MessageBox.Show("Student address should be atleast 8 characters long.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBoxEmail.Focus();
                return false;
            }
            Controller.Helper helper = new Controller.Helper();
            if (!helper.IsValidEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Enter valid Email.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBoxEmail.Focus();
                return false;
            }
            //Semester
            if (comboBoxSemester.SelectedItem == null)
            {
                MessageBox.Show("Please select the Semester.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                comboBoxSemester.Focus();
                return false;
            }
            //Section
            if (comboBoxSection.SelectedValue == null)
            {
                MessageBox.Show("Please select the Semester.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                comboBoxSemester.Focus();
                return false;
            }
            return true;
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            Controller.Semester semester = new Controller.Semester();
            semester.LoadAllSemester(1, comboBoxSemester);

            CheckFormCall();
        }

        private void textBoxCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxStudentContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void comboBoxSemester_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Controller.Section section = new Controller.Section();
            section.LoadAllSection(1, Convert.ToInt32(comboBoxSemester.SelectedValue), comboBoxSection);
        }
    }
}

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
    public partial class AddTeacherForm : Form
    {
        public AddTeacherForm()
        {
            InitializeComponent();
        }

        private void buttonTeacherSubmit_Click(object sender, EventArgs e)
        {
            if (!TeacherFormValidation())
            {
                return;
            }

            Controller.Teacher teacher = new Controller.Teacher();
            if (teacher.CheckForTeacherName(textBoxTeacherName.Text, 1))
            {
                MessageBox.Show(textBoxTeacherName.Text + " already exists. Please enter unique Teacher name.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxTeacherName.Focus();
                return;
            }

            if (teacher.AddNewTeacher(1, textBoxTeacherName.Text, textBoxContact.Text, textBoxAddress.Text, textBoxEmail.Text))
            {
                MessageBox.Show("Inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }

        public bool TeacherFormValidation()
        {
            if (String.IsNullOrWhiteSpace(textBoxTeacherName.Text))
            {
                MessageBox.Show("Please fill the Teacher name.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxTeacherName.Focus();
                return false;
            }
            if ((textBoxTeacherName.Text.Length) < 5)
            {
                MessageBox.Show("Teacher name should be atleast 6 characters long.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxTeacherName.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(textBoxContact.Text))
            {
                MessageBox.Show("Please fill the Contact.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxContact.Focus();
                return false;
            }
            if ((textBoxContact.Text.Length) != 10)
            {
                MessageBox.Show("Contact should be 10 digits.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxContact.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                MessageBox.Show("Please fill the Address.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxAddress.Focus();
                return false;
            }
            if ((textBoxAddress.Text.Length) < 4)
            {
                MessageBox.Show("Address should be atleast 5 characters long.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxAddress.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("Please fill the Email.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxEmail.Focus();
                return false;
            }
            Controller.Helper helper = new Controller.Helper();
            if (!helper.IsValidEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Please write valid Email.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxEmail.Focus();
                return false;
            }
            return true;
        }

        private void textBoxContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one hifun point
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            // only allow one plus point
            if ((e.KeyChar == '+') && ((sender as TextBox).Text.IndexOf('+') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

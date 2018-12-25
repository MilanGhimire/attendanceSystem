using System;
using System.Windows.Forms;

namespace StudentAttendence
{
    public partial class AddDepartmentForm : Form
    {
        //public String formType = String.Empty;
        private Controller.Department department;
        String deptName;

        public AddDepartmentForm()
        {
            InitializeComponent();
            deptName = string.Empty;
            department = new Controller.Department();
        }

        public AddDepartmentForm(int deptId)
        {
            InitializeComponent();
            deptName = string.Empty;
            department = new Controller.Department
            {
                departmentID = deptId
            };
        }

        private void CheckFormCall()
        {
            //if (this.formType == "edit")
            //{
            //    labelAddDepartmentTitle.Text = "Update Department";
            //    Controller.Department department = new Controller.Department();
            //    department.GetSingleDepartment();
            //}

            if (this.Owner != null)
            {
                if ((this.Owner is ViewDepartmentForm))
                {
                    labelAddDepartmentTitle.Text = "Update Department";
                    department.GetSingleDepartment(textBoxDepartmentName, comboBoxCourseType, numericUpDownCourseDuration);
                    deptName = textBoxDepartmentName.Text;
                }
                if (this.Owner is HomeForm)
                {
                    comboBoxCourseType.SelectedText = null;
                }
            }
        }

        private void AddDepartmentForm_Load(object sender, EventArgs e)
        {
            CheckFormCall();
        }

        private void comboBoxCourseType_SelectedValueChanged(object sender, EventArgs e)
        {
            numericUpDownCourseDuration.ReadOnly = false;
            if (comboBoxCourseType.SelectedItem.ToString() == "Year")
            {
                //MessageBox.Show("year selected.");
                labelNumberOf.Text = "Number of Years :";
            }
            if (comboBoxCourseType.SelectedItem.ToString() == "Semester")
            {
                labelNumberOf.Text = "Number of Semesters :";
                //MessageBox.Show("Semester selected.");
            }
        }

        private void numericUpDownCourseDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private bool DepartmentValidation()
        {
            if (String.IsNullOrWhiteSpace(textBoxDepartmentName.Text))
            {
                MessageBox.Show("Please enter Department Name.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxDepartmentName.Focus();
                return false;
            }
            if ((textBoxDepartmentName.Text).Length < 3)
            {
                MessageBox.Show("Department Name should be atleast 3 character long.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxDepartmentName.Focus();
                return false;
            }
            if (comboBoxCourseType.SelectedItem == null)
            {
                MessageBox.Show("Please select Course type.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBoxCourseType.Focus();
                return false;
            }
            if (numericUpDownCourseDuration.Value < 1)
            {
                MessageBox.Show("Please enter Course Duration.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                numericUpDownCourseDuration.Focus();
                return false;
            }
            if (deptName == string.Empty || deptName != textBoxDepartmentName.Text)
            {
                if (department.CheckForDepartmentName(textBoxDepartmentName.Text))
                {
                    MessageBox.Show(textBoxDepartmentName.Text + " already exists. Please enter unique Department name.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxDepartmentName.Focus();
                    return false;
                }
            }

            return true;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (!DepartmentValidation())
            {
                return;
            }

            if (this.Owner is ViewDepartmentForm)
            {
                if (department.UpdateDepartment(textBoxDepartmentName.Text, comboBoxCourseType.SelectedItem.ToString(), Convert.ToInt32(numericUpDownCourseDuration.Value)))
                {
                    MessageBox.Show("Updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            if (this.Owner is HomeForm)
            {
                if (department.AddNewDepartment(textBoxDepartmentName.Text, comboBoxCourseType.SelectedItem.ToString(), Convert.ToInt32(numericUpDownCourseDuration.Value)))
                {
                    MessageBox.Show("Inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
        }
    }
}

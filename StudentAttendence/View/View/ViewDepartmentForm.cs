using System;
using System.Windows.Forms;

namespace StudentAttendence
{
    public partial class ViewDepartmentForm : Form
    {
        Controller.Department department;

        public ViewDepartmentForm()
        {
            InitializeComponent();
            department = new Controller.Department();
        }

        private void ViewDepartmentForm_Load(object sender, EventArgs e)
        {
            department.GetAllDepartmentList(dataGridViewDepartment);
        }

        private void dataGridViewDepartment_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1 && e.Button == MouseButtons.Right)
            {
                dataGridViewDepartment.Rows[e.RowIndex].Selected = true;
                department.departmentID = Convert.ToInt32(dataGridViewDepartment.Rows[e.RowIndex].Cells["ColumnDepartmentID"].Value);
                contextMenuStripDepartment.Show();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (department.departmentID == 0)
            {
                MessageBox.Show("Department Not Selected.");
                return;
            }

            AddDepartmentForm addDepartmentForm = new AddDepartmentForm(department.departmentID);
            addDepartmentForm.ShowDialog(this);
            dataGridViewDepartment.Rows.Clear();
            department.GetAllDepartmentList(dataGridViewDepartment);
        }
    }
}

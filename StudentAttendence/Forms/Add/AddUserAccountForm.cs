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
    public partial class AddUserAccount : Form
    {
        public AddUserAccount()
        {
            InitializeComponent();
        }

        private void AddUserAccount_Load(object sender, EventArgs e)
        {
            Controller.Department department = new Controller.Department();
            department.LoadAllDepartment(comboBoxDepartmentName);
        }
    }
}

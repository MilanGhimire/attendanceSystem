using MySql.Data.MySqlClient;
using StudentAttendence.Controller;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentAttendence.Controller
{
    class Role
    {
        private MySqlConnection connect;

        public Role()
        {
            //roleID = 0;
            Database database = new Database();
            try
            {
                this.connect = database.getDatabaseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Role: " + ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadAllRole(ComboBox comboBox)
        {
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT `role_id`, `role_name` FROM `db_attendance_assistance`.`tbl_role`; ", this.connect);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                comboBox.DisplayMember = "role_name";
                comboBox.ValueMember = "role_id";
                comboBox.DataSource = dataTable;
                comboBox.SelectedItem = null;
                mySqlDataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Role comboLoad: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connect.Close();
            }
        }

        public string GetRoleName(int roleID)
        {
            string roleName = string.Empty;
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT `role_id`, `role_name` FROM `db_attendance_assistance`.`tbl_role` WHERE `role_id` = " + roleID + ";", this.connect);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                roleName = dataTable.Rows[0]["role_name"].ToString();
                dataTable.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Get Role Name: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connect.Close();
            }
            return roleName;
        }
    }
}

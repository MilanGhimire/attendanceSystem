using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentAttendence.Controller
{
    class UserAccount
    {
        private MySqlConnection connect;

        //instance Variables
        public int ua_id;
        String ua_username;
        String ua_role;
        int ua_department_id;

        public UserAccount()
        {
            Database database = new Database();
            try
            {
                this.connect = database.getDatabaseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login: " + ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool UserLoginAuthentication(String username, String password)
        {
            bool checkValidation = false;
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT `ua_id`, `ua_username`, `ua_role`, `ua_department_id` FROM `tbl_user_account` WHERE `ua_username` = @username AND `ua_password` = @password", connect);
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add(new MySqlParameter("@username", username));
                mySqlCommand.Parameters.Add(new MySqlParameter("@password", password));
                //mySqlCommand.ExecuteScalarAsync != String.IsNullOrEmpty

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                //MessageBox.Show(dataTable.Rows.Count.ToString());

                if (dataTable.Rows.Count == 1)
                {
                    this.ua_id = Convert.ToInt32(dataTable.Rows[0]["ua_id"]);
                    this.ua_username = dataTable.Rows[0]["ua_username"].ToString();
                    this.ua_role = dataTable.Rows[0]["ua_role"].ToString();
                    this.ua_department_id = Convert.ToInt32(dataTable.Rows[0]["ua_department_id"]);
                    MessageBox.Show("Welcome." + this.ua_role);
                    checkValidation = true;
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login: " + ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
            return checkValidation;
        }

        public void GetAllUserAccountList(DataGridView dataGridView)
        {
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT ua.`ua_id`, ua.`ua_username`, r.`role_name`, d.`dept_name` FROM `tbl_user_account` AS ua INNER JOIN `tbl_role` AS r ON ua.`ua_role` = r.`role_id` INNER JOIN `tbl_department` AS d ON ua.`ua_department_id` = d.`dept_id`;", this.connect);
                using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
                {
                    //To count how many rows are fetched from Database
                    int count = 1;

                    while (mySqlDataReader.Read())
                    {
                        //To show in dataGridView
                        dataGridView.Rows.Add(count, "Full name here", mySqlDataReader["ua_username"], mySqlDataReader["role_name"], mySqlDataReader["dept_name"], mySqlDataReader["ua_id"]);
                        count++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("User Account: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connect.Close();
            }
        }

        public void GetSingleUserAccount(ComboBox department, ComboBox role, TextBox Username)
        {
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT `ua_id`, `ua_username`, `ua_password`, `ua_role`, `ua_department_id` FROM `db_student_attendance`.`tbl_user_account` WHERE `ua_id` = " + this.ua_id + "; ", this.connect);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                department.SelectedValue = dataTable.Rows[0]["ua_department_id"];
                role.SelectedValue = dataTable.Rows[0]["ua_role"];
                Username.Text = dataTable.Rows[0]["ua_username"].ToString();
                dataTable.Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show("User Account single info: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connect.Close();
            }
        }

        public bool AddNewUserAccount(int department, int role, String username, String password)
        {
            bool checkInsertion = false;
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO `db_student_attendance`.`tbl_user_account` (`ua_username`, `ua_password`, `ua_role`, `ua_department_id`) VALUES(@username, @password, @role, @department);", connect);
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add(new MySqlParameter("@username", username));
                mySqlCommand.Parameters.Add(new MySqlParameter("@password", password));
                mySqlCommand.Parameters.Add(new MySqlParameter("@role", role));
                mySqlCommand.Parameters.Add(new MySqlParameter("@department", department));
                if (mySqlCommand.ExecuteNonQuery() > 0)
                {
                    checkInsertion = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add User Account: " + ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
            return checkInsertion;
        }

        public bool CheckForUserName(String name)
        {
            bool checkValidation = false;
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT  `ua_id`, `ua_username`, `ua_password`, `ua_role`, `ua_department_id` FROM `db_student_attendance`.`tbl_user_account` WHERE `ua_id` = @name", connect);
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add(new MySqlParameter("@name", name));

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                //MessageBox.Show(dataTable.Rows.Count.ToString());

                if (dataTable.Rows.Count > 0)
                {
                    checkValidation = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("User Account check username: " + ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
            return checkValidation;
        }

        public bool UpdateDepartment(int departmentID, int role, String username)
        {
            bool checkValidation = false;
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("UPDATE `db_student_attendance`.`tbl_user_account` SET `ua_username` = @username, `ua_role` = @role, `ua_department_id` = @departmentID WHERE `ua_id` = " + this.ua_id + "; ", connect);
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add(new MySqlParameter("@username", username));
                mySqlCommand.Parameters.Add(new MySqlParameter("@role", role));
                mySqlCommand.Parameters.Add(new MySqlParameter("@departmentID", departmentID));

                if (mySqlCommand.ExecuteNonQuery() > 0)
                {
                    checkValidation = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("User Account Update: " + ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
            return checkValidation;
        }
    }
}

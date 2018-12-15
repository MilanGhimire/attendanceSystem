using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StudentAttendence.Controller
{
    class UserAccount
    {
        private MySqlConnection connect;

        //instance Variables
        int ua_id;
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
    }
}

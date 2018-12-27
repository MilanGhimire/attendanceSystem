using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

//SELECT s.`student_id`, d.dept_name, s.`sem_id`, s.`sec_id`, s.`student_name`, s.`student_card_id`, s.`student_contact`, s.`parents_contact`, s.`student_address`, s.`student_email` FROM `tbl_students` AS s INNER JOIN tbl_department as d ON s.`dept_id` = d.dept_id WHERE s.dept_id = 1

namespace StudentAttendence.Controller
{
    class Semester
    {
        MySqlConnection connect;
        public int semesterID;

        public Semester()
        {
            semesterID = 0;
            try
            {
                Database database = new Database();
                this.connect = database.getDatabaseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadAllSemester(int department, ComboBox comboBox)
        {
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT `sem_id`, `dept_id`, `sem_name` FROM `tbl_semester` WHERE `dept_id` = @department", this.connect);
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add(new MySqlParameter("@department", department));
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                comboBox.DisplayMember = "sem_name";
                comboBox.ValueMember = "sem_id";
                comboBox.DataSource = dataTable;
                comboBox.SelectedItem = null;
                mySqlDataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connect.Close();
            }
        }

        public void GetAllSemesterList(int departmentID,DataGridView dataGridView)
        {
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT s.`sem_id`,d.`dept_name`, s.`sem_name` FROM `db_attendance_assistance`.`tbl_semester` AS s INNER JOIN `tbl_department` AS d ON s.`dept_id` = d.`dept_id` WHERE d.`dept_id` = @departmentID; ", this.connect);
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add(new MySqlParameter("@departmentID", departmentID));
                using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
                {
                    //To count how many rows are fetched from Database
                    int count = 1;

                    while (mySqlDataReader.Read())
                    {
                        //To show in dataGridView
                        dataGridView.Rows.Add(count, mySqlDataReader["dept_name"], mySqlDataReader["sem_name"], mySqlDataReader["sem_id"]);
                        count++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Semester: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connect.Close();
            }
        }

        public void GetSingleSemester(ComboBox semester, TextBox sectionName)
        {
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT `sem_id`, `dept_id`, `sem_name` FROM `db_attendance_assistance`.`tbl_semester` WHERE `sem_id` = " + this.semesterID + "; ", this.connect);
                //MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                //DataTable dataTable = new DataTable();
                //mySqlDataAdapter.Fill(dataTable);
                //semester.SelectedValue = dataTable.Rows[0]["sem_id"];
                //sectionName.Text = dataTable.Rows[0]["sec_name"].ToString();
                //dataTable.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Semester: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connect.Close();
            }
        }

        //public bool UpdateSemester(int departmentID, int role, String username)
        //{
        //    bool checkValidation = false;
        //    try
        //    {
        //        connect.Open();
        //        MySqlCommand mySqlCommand = new MySqlCommand("UPDATE `db_attendance_assistance`.`tbl_user_account` SET `ua_username` = @username, `ua_role` = @role, `ua_department_id` = @departmentID WHERE `ua_id` = " + this.ua_id + "; ", connect);
        //        mySqlCommand.Parameters.Clear();
        //        mySqlCommand.Parameters.Add(new MySqlParameter("@username", username));
        //        mySqlCommand.Parameters.Add(new MySqlParameter("@role", role));
        //        mySqlCommand.Parameters.Add(new MySqlParameter("@departmentID", departmentID));

        //        if (mySqlCommand.ExecuteNonQuery() > 0)
        //        {
        //            checkValidation = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Semester Update: " + ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        connect.Close();
        //    }
        //    return checkValidation;
        //}
    }
}

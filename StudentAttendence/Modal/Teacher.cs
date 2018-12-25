using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentAttendence.Controller
{
    class Teacher
    {
        private MySqlConnection connect;
        public int teacherID;

        public Teacher()
        {
            teacherID = 0;
            Database database = new Database();
            try
            {
                this.connect = database.getDatabaseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Teacher: " + ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadAllTeacher(int department, ComboBox comboBox)
        {
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT `teacher_id`, `teacher_name` FROM `tbl_teacher` WHERE `dept_id` = @department;", this.connect);
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add(new MySqlParameter("@department", department));
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                comboBox.DisplayMember = "teacher_name";
                comboBox.ValueMember = "teacher_id";
                comboBox.DataSource = dataTable;
                //comboBox.SelectedItem = null;
                mySqlDataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Teacher: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connect.Close();
            }
        }

        public bool AddNewTeacher(int department_id, String name, String contact, String address, String email)
        {
            bool checkInsertion = false;
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO `tbl_teacher`(`teacher_name`, `teacher_contact`, `teacher_address`, `teacher_email`, `dept_id`) VALUES (@name, @contact, @address, @email, @department_id)", connect);
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add(new MySqlParameter("@name", name));
                mySqlCommand.Parameters.Add(new MySqlParameter("@semester", contact));
                mySqlCommand.Parameters.Add(new MySqlParameter("@semester", address));
                mySqlCommand.Parameters.Add(new MySqlParameter("@semester", email));
                mySqlCommand.Parameters.Add(new MySqlParameter("@department_id", department_id));
                if (mySqlCommand.ExecuteNonQuery() > 0)
                {
                    checkInsertion = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Teacher: " + ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
            return checkInsertion;
        }

        public bool CheckForTeacherName(String teacher_name, int department_id)
        {
            bool checkValidation = false;
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT `teacher_id`, `teacher_name`, `teacher_contact`, `teacher_address`, `teacher_email`, `dept_id` FROM `tbl_teacher` WHERE `teacher_name`=@name AND `dept_id`=@department;", connect);
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add(new MySqlParameter("@name", teacher_name));
                mySqlCommand.Parameters.Add(new MySqlParameter("@department", department_id));

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
                MessageBox.Show("Section: " + ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
            return checkValidation;
        }

        public void GetAllTeacherList(DataGridView dataGridView)
        {
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT t.`teacher_id`, t.`teacher_name`, t.`teacher_contact`, t.`teacher_address`, t.`teacher_email`, d.`dept_name` FROM `tbl_teacher` AS t INNER JOIN `tbl_department` AS d ON t.`teacher_id` = d.`dept_id`;", this.connect);
                using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
                {
                    //To count how many rows are fetched from Database
                    int count = 1;

                    while (mySqlDataReader.Read())
                    {
                        //To show in dataGridView
                        dataGridView.Rows.Add(count, mySqlDataReader["teacher_name"], mySqlDataReader["teacher_contact"], mySqlDataReader["teacher_address"], mySqlDataReader["teacher_email"], mySqlDataReader["dept_name"], mySqlDataReader["teacher_id"]);
                        count++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Teacher: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connect.Close();
            }
        }

        public void GetSingleTeacher(TextBox teacherName, TextBox contact, TextBox address, TextBox email)
        {
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT `teacher_id`, `teacher_name`, `teacher_contact`, `teacher_address`, `teacher_email`, `dept_id` FROM `db_student_attendance`.`tbl_teacher` WHERE `teacher_id` = " + this.teacherID + "; ", this.connect);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                teacherName.Text = dataTable.Rows[0]["teacher_name"].ToString();
                contact.Text = dataTable.Rows[0]["teacher_contact"].ToString();
                address.Text = dataTable.Rows[0]["teacher_address"].ToString();
                email.Text = dataTable.Rows[0]["teacher_email"].ToString();
                dataTable.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Teacher Single Load: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connect.Close();
            }
        }

        public bool UpdateTeacher(int department_id, String name, String contact, String address, String email)
        {
            bool checkValidation = false;
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("UPDATE `db_student_attendance`.`tbl_teacher` SET `teacher_name` = @name, `teacher_contact` = @contact, `teacher_address` = @address, `teacher_email` = @email, `dept_id` = @department_id WHERE `teacher_id` = " + this.teacherID + "; ", connect);
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add(new MySqlParameter("@name", name));
                mySqlCommand.Parameters.Add(new MySqlParameter("@contact", contact));
                mySqlCommand.Parameters.Add(new MySqlParameter("@address", address));
                mySqlCommand.Parameters.Add(new MySqlParameter("@email", email));
                mySqlCommand.Parameters.Add(new MySqlParameter("@department_id", department_id));

                if (mySqlCommand.ExecuteNonQuery() > 0)
                {
                    checkValidation = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Teacher Update: " + ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
            return checkValidation;
        }
    }
}

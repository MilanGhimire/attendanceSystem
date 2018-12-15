using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendence.Controller
{
    class Teacher
    {
        private MySqlConnection connect;

        public Teacher()
        {
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
                comboBox.SelectedItem = null;
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
    }
}

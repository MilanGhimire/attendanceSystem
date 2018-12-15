using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using StudentAttendence.Controller;

namespace StudentAttendence.Controller
{
    class Section
    {
        private MySqlConnection connect;

        public Section()
        {
            Database database = new Database();
            try
            {
                this.connect = database.getDatabaseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadAllSection(int department, int semester, ComboBox comboBox)
        {
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT `sec_id`, `dept_id`, `sec_name`, `teacher_id`, `sem_id` FROM `tbl_section` WHERE `dept_id` = @department AND `sem_id` = @semester", this.connect);
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add(new MySqlParameter("@department", department));
                mySqlCommand.Parameters.Add(new MySqlParameter("@semester", semester));
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                comboBox.DisplayMember = "sec_name";
                comboBox.ValueMember = "sec_id";
                comboBox.DataSource = dataTable;
                comboBox.SelectedItem = null;
                mySqlDataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Section: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connect.Close();
            }
        }

        public bool AddNewSection(int department_id, int semester_id, String[] name, int count)
        {
            bool checkInsertion = false;
            try
            {
                int c = 0;
                connect.Open();
                for (int i = 0; i < count; i++)
                {
                    MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO `tbl_section`(`dept_id`, `sec_name`, `sem_id`) VALUES (@department_id, @name, @semester)", connect);
                    mySqlCommand.Parameters.Clear();
                    mySqlCommand.Parameters.Add(new MySqlParameter("@department_id", department_id));
                    mySqlCommand.Parameters.Add(new MySqlParameter("@name", name[i]));
                    mySqlCommand.Parameters.Add(new MySqlParameter("@semester", semester_id));
                    if (mySqlCommand.ExecuteNonQuery() > 0)
                    {
                        c++;
                    }
                }
                //MessageBox.Show(c.ToString() + "\n" + count.ToString());
                if (c == count)
                {
                    checkInsertion = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Section: " + ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
            return checkInsertion;
        }

        public bool CheckForSectionName(int semester_id, String section_name, int department_id)
        {
            bool checkValidation = false;
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT `sec_id`, `dept_id`, `sec_name`, `teacher_id`, `sem_id` FROM `tbl_section` WHERE `sec_name`=@name AND `dept_id`=@department AND `sem_id`=@semester", connect);
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add(new MySqlParameter("@name", section_name));
                mySqlCommand.Parameters.Add(new MySqlParameter("@department", department_id));
                mySqlCommand.Parameters.Add(new MySqlParameter("@semester", semester_id));

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

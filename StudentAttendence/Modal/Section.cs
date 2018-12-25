using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentAttendence.Controller
{
    class Section
    {
        private MySqlConnection connect;
        public int sectionID;

        public Section()
        {
            sectionID = 0;
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

        public void GetAllSectionList(DataGridView dataGridView)
        {
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT sec.`sec_id`, d.`dept_name`, sec.`sec_name`, t.`teacher_name`, sem.`sem_name` FROM `db_student_attendance`.`tbl_section` AS sec INNER JOIN `tbl_department` AS d ON sec.`dept_id` = d.`dept_id` INNER JOIN `tbl_teacher` AS t ON sec.`teacher_id` = t.`teacher_id` INNER JOIN `tbl_semester` AS sem ON sec.`sem_id` = sem.`sem_id`; ", this.connect);
                using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
                {
                    //To count how many rows are fetched from Database
                    int count = 1;

                    while (mySqlDataReader.Read())
                    {
                        //To show in dataGridView
                        dataGridView.Rows.Add(count, mySqlDataReader["dept_name"], mySqlDataReader["sec_name"], mySqlDataReader["teacher_name"], mySqlDataReader["sem_name"], mySqlDataReader["sec_id"]);
                        count++;
                    }
                }
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

        public void GetSingleSection(ComboBox semester, TextBox sectionName)
        {
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT `sec_id`, `sec_name`, `teacher_id`, `sem_id` FROM `db_student_attendance`.`tbl_section` WHERE `sec_id` = " + sectionID + "; ", this.connect);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                semester.SelectedValue = dataTable.Rows[0]["sem_id"];
                sectionName.Text = dataTable.Rows[0]["sec_name"].ToString();
                dataTable.Dispose();
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

        public bool UpdateSection(int department_id, int semester_id, String name)
        {
            bool checkValidation = false;
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("UPDATE `db_student_attendance`.`tbl_section` SET `dept_id` = @department_id, `sec_name` = @name, `sem_id` = @semester_id WHERE `sec_id` = " + this.sectionID + "; ", connect);
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add(new MySqlParameter("@department_id", department_id));
                mySqlCommand.Parameters.Add(new MySqlParameter("@name", name));
                mySqlCommand.Parameters.Add(new MySqlParameter("@semester_id", semester_id));

                if (mySqlCommand.ExecuteNonQuery() > 0)
                {
                    checkValidation = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Section Update: " + ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
            return checkValidation;
        }
    }
}

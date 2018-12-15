using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentAttendence.Controller
{
    class Subject
    {
        private MySqlConnection connect;

        public Subject()
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

        public void LoadAllSubject(int department, int semester, ComboBox comboBox)
        {
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT `subject_id`, `subject_department`, `subject_semester`, `subject_teacher`, `subject_name` FROM `tbl_subject` WHERE `subject_department` = @department AND `subject_semester` = @semester;", this.connect);
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add(new MySqlParameter("@department", department));
                mySqlCommand.Parameters.Add(new MySqlParameter("@semester", semester));
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                comboBox.DisplayMember = "subject_name";
                comboBox.ValueMember = "subject_id";
                comboBox.DataSource = dataTable;
                comboBox.SelectedItem = null;
                mySqlDataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Subject: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connect.Close();
            }
        }

        public bool CheckForSubjectName(int semester, String subject, int department_id)
        {
            bool checkValidation = false;
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT `subject_id`, `subject_department`, `subject_semester`, `subject_teacher`, `subject_name` FROM `tbl_subject` WHERE `subject_semester` = @semester AND `subject_name` = @subject  AND `subject_department`=@department;", connect);
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add(new MySqlParameter("@semester", semester));
                mySqlCommand.Parameters.Add(new MySqlParameter("@subject", subject));
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

        public bool AddNewSubject(int department_id, int semester, String subject, int teacher_id)
        {
            bool checkInsertion = false;
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO `tbl_subject`(`subject_department`, `subject_semester`, `subject_teacher`, `subject_name`) VALUES (@department, @semester, @teacher, @subject);", connect);
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add(new MySqlParameter("@department", department_id));
                mySqlCommand.Parameters.Add(new MySqlParameter("@semester", semester));
                mySqlCommand.Parameters.Add(new MySqlParameter("@teacher", teacher_id));
                mySqlCommand.Parameters.Add(new MySqlParameter("@subject", subject));
                if (mySqlCommand.ExecuteNonQuery() > 0)
                {
                    checkInsertion = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Subject: " + ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
            return checkInsertion;
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentAttendence.Controller
{
    class Subject
    {
        private MySqlConnection connect;
        public int subjectID;

        public Subject()
        {
            subjectID = 0;
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
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT `subject_id`, `dept_id`, `sem_id`, `teacher_id`, `subject_name` FROM `tbl_subject` WHERE `dept_id` = @department AND `sem_id` = @semester;", this.connect);
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
                MessageBox.Show("Subject LOad: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO `tbl_subject`(`dept_id`, `sem_id`, `teacher_id`, `subject_name`) VALUES (@department, @semester, @teacher, @subject);", connect);
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

        public void GetAllSubjectList(int departmentID, DataGridView dataGridView)
        {
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT sub.`subject_id`, d.`dept_name`, sem.`sem_name`, t.`teacher_name`, sub.`subject_name` FROM `tbl_subject` AS sub INNER JOIN `tbl_department` AS d ON sub.`dept_id` = d.`dept_id` INNER JOIN `tbl_semester` AS sem ON sub.`sem_id` = sem.`sem_id` INNER JOIN `tbl_teacher` AS t ON sub.`teacher_id` = t.`teacher_id`;", this.connect);
                using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
                {
                    //To count how many rows are fetched from Database
                    int count = 1;

                    while (mySqlDataReader.Read())
                    {
                        //To show in dataGridView
                        dataGridView.Rows.Add(count, mySqlDataReader["dept_name"], mySqlDataReader["sem_name"], mySqlDataReader["teacher_name"], mySqlDataReader["subject_name"], mySqlDataReader["subject_id"]);
                        count++;
                    }
                }
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

        public void GetSingleSubject(ComboBox semester, TextBox subjectName, ComboBox teacherName)
        {
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT `subject_id`, `dept_id`, `sem_id`, `teacher_id`, `subject_name` FROM `db_student_attendance`.`tbl_subject` WHERE `subject_id` = " + this.subjectID + ";", this.connect);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                semester.SelectedValue = dataTable.Rows[0]["sem_id"];
                subjectName.Text = dataTable.Rows[0]["subject_name"].ToString();
                teacherName.SelectedValue = dataTable.Rows[0]["teacher_id"];
                dataTable.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Subject Get Single: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connect.Close();
            }
        }

        public bool UpdateSubject(int department_id, int semester, String subject, int teacher_id)
        {
            bool checkValidation = false;
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("UPDATE `db_student_attendance`.`tbl_subject` SET `dept_id` = @department_id, `sem_id` = @semester, `teacher_id` = @teacher_id, `subject_name` = @subject WHERE `subject_id` = " + this.subjectID + "; ", connect);
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add(new MySqlParameter("@department_id", department_id));
                mySqlCommand.Parameters.Add(new MySqlParameter("@semester", semester));
                mySqlCommand.Parameters.Add(new MySqlParameter("@teacher_id", teacher_id));
                mySqlCommand.Parameters.Add(new MySqlParameter("@subject", subject));

                if (mySqlCommand.ExecuteNonQuery() > 0)
                {
                    checkValidation = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Subject Update: " + ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
            return checkValidation;
        }

        public void GetSubject(int departmentID, DataGridView dataGridView)
        {
            try
            {
                //SELECT a.`attendace_id`, stu.`student_name`, a.`teacher_id`, a.`section_id`, a.`subject_id`, a.`attendance_semester`, a.`attendance_date`, a.`attendance_status` FROM `db_student_attendance`.`tbl_attendance` AS a INNER JOIN `tbl_student` AS stu ON a.`student_id` = stu.`student_id` WHERE a.`section_id` = 1 AND a.`subject_id` = 1 AND a.`subject_id` = 1
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT `subject_id`, `dept_id`, `sem_id`, `subject_section_id`, `teacher_id`, `subject_name` FROM `db_student_attendance`.`tbl_subject` WHERE `dept_id` = 1 AND `sem_id` = 1 AND `subject_section_id` = 1", this.connect);
                mySqlCommand.Parameters.Clear();
                using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
                {
                    //To count how many rows are fetched from Database
                    //int count = 1;

                    while (mySqlDataReader.Read())
                    {
                        mySqlCommand = new MySqlCommand("SELECT stu.`student_name`, a.`teacher_id`, a.`section_id`, a.`subject_id`, a.`attendance_semester`, a.`attendance_date`, SUM(a.`attendance_status`) AS 'Present', COUNT(a.`attendance_status`) AS 'Total' FROM `db_student_attendance`.`tbl_attendance` AS a INNER JOIN `tbl_student` AS stu ON a.`student_id` = stu.`student_id` WHERE a.`subject_id` = 4 AND a.`section_id` = 1 GROUP BY stu.`student_name`", this.connect);
                        using (MySqlDataReader mySUBSqlDataReader = mySqlCommand.ExecuteReader())
                        {
                            //To count how many rows are fetched from Database
                            //mySqlDataReader["subject_name"]
                            int count = 1;

                            while (mySUBSqlDataReader.Read())
                            {
                                //To show in dataGridView
                                dataGridView.Rows.Add(count, mySUBSqlDataReader["student_name"], mySUBSqlDataReader["teacher_id"], mySUBSqlDataReader["section_id"], mySUBSqlDataReader["subject_section_id"], mySUBSqlDataReader["Present"], mySUBSqlDataReader["Total"]);
                                count++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Subject getSubject: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connect.Close();
            }
        }
    }
}

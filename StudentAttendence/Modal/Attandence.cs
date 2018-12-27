using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentAttendence.Controller
{
    class Attandence
    {
        private readonly MySqlConnection connect;
        public Attandence()
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

        public void GetStudentAttandence(String Query, String[] ParameterNames, String[] ParamaterValues, DataGridView dataGridView)
        {
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(Query, this.connect);
                mySqlCommand.Parameters.Clear();
                int i = 0;
                foreach (String name in ParameterNames)
                {
                    mySqlCommand.Parameters.Add(new MySqlParameter(name, ParamaterValues[i]));
                    i++;
                }
                using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
                {
                    //To count how many rows are fetched from Database
                    int count = 1;

                    while (mySqlDataReader.Read())
                    {
                        //To show in dataGridView
                        dataGridView.Rows.Add(count, mySqlDataReader["student_card_id"], mySqlDataReader["student_name"], mySqlDataReader["sem_name"], mySqlDataReader["sec_name"], mySqlDataReader["subject_name"], mySqlDataReader["Present"], (Convert.ToInt32(mySqlDataReader["Total"])-(Convert.ToInt32(mySqlDataReader["Present"]))).ToString());
                        count++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Student Attandence: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connect.Close();
            }
        }

        public void GetTodayAttandence(int departmentID, int semesterID, int sectionID, int subjectID, DataGridView dataGridView)
        {
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT `student_id`, `dept_id`, `sem_id`, `sec_id`, `student_name`, `student_card_id`, `student_contact`, `parents_contact`, `student_address`, `student_email` FROM `db_attendance_assistance`.`tbl_student` WHERE `sem_id` = 1 AND `sec_id` = 1", this.connect);
                mySqlCommand.Parameters.Clear();
                //mySqlCommand.Parameters.Add(new MySqlParameter("@semesterID", semesterID));
                //mySqlCommand.Parameters.Add(new MySqlParameter("@sectionID", sectionID));

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                String[] array = new string[dataTable.Rows.Count];
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    array[i] = dataTable.Rows[i]["student_id"].ToString();
                }
                dataTable.Dispose();
                int a = 1;
                foreach (var item in array)
                {
                    mySqlCommand = new MySqlCommand("SELECT `attendace_id`, `student_id`, `teacher_id`, `section_id`, `subject_id`, `attendance_semester`, `attendance_date`, `attendance_status` FROM `db_attendance_assistance`.`tbl_attendance` WHERE `student_id` = " + item + " AND `subject_id` = 1 AND `attendance_date` = CURRENT_DATE", this.connect);
                    mySqlCommand.Parameters.Clear();
                    //mySqlCommand.Parameters.Add(new MySqlParameter("@subjectID", subjectID));

                    using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
                    {
                        //To count how many rows are fetched from Database
                        int count = 1;

                        while (mySqlDataReader.Read())
                        {
                            if (Convert.ToInt32(mySqlDataReader["attendance_status"]) == 0)
                            {
                                //To show in dataGridView
                                dataGridView.Rows.Add(count, mySqlDataReader["student_id"], mySqlDataReader["attendace_id"], mySqlDataReader["subject_id"], mySqlDataReader["attendance_status"], mySqlDataReader["attendance_date"]);
                                count++;
                            }
                        }
                    }
                    a++;
                }
                //mySqlCommand.Parameters.Clear();
                //int i = 0;
                //foreach (String name in ParameterNames)
                //{
                //    mySqlCommand.Parameters.Add(new MySqlParameter(name, ParamaterValues[i]));
                //    i++;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Today Student Attandence: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connect.Close();
            }
        }

        public void GetAllSpecificDateAbsentList(int departmentID, String date, DataGridView dataGridView)
        {
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT DISTINCT a.`student_id`, a.`attendace_id`, stu.`student_name`, stu.`student_card_id`, stu.`student_contact`, stu.`parents_contact`, sem.`sem_name`, a.`teacher_id`, a.`section_id`, sec.`sec_name`, a.`subject_id`, sub.`subject_name`, a.`attendance_semester`, a.`attendance_date`, a.`attendance_status` FROM `db_attendance_assistance`.`tbl_attendance` AS a INNER JOIN `tbl_student` AS stu ON a.`student_id` = stu.`student_id` INNER JOIN `tbl_semester` AS sem ON stu.`sem_id` = sem.`sem_id` INNER JOIN `tbl_section` AS sec ON a.`section_id` = sec.`sec_id` INNER JOIN `tbl_subject` AS sub ON a.`subject_id` = sub.`subject_id` WHERE a.`attendance_status` = 0 AND a.`attendance_date` = @date AND stu.`dept_id` = 1 GROUP BY a.`student_id`", this.connect);
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add(new MySqlParameter("@date", date));
                mySqlCommand.Parameters.Add(new MySqlParameter("@departmentID", departmentID));
                //mySqlCommand.Parameters.Add(new MySqlParameter("@sectionID", sectionID));

                using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
                {
                    //To count how many rows are fetched from Database
                    int count = 1;

                    while (mySqlDataReader.Read())
                    {
                        if (Convert.ToInt32(mySqlDataReader["attendance_status"]) == 0)
                        {
                            //To show in dataGridView
                            dataGridView.Rows.Add(count, mySqlDataReader["student_id"], mySqlDataReader["student_name"], mySqlDataReader["sem_name"], mySqlDataReader["sec_name"], mySqlDataReader["subject_name"], mySqlDataReader["student_contact"], mySqlDataReader["parents_contact"]);
                            count++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Specific Date All Attandence: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connect.Close();
            }
        }
    }
}

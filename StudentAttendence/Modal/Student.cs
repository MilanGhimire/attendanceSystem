using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentAttendence.Controller
{
    class Student
    {
        private MySqlConnection connect;
        public int studentID;

        public Student()
        {
            studentID = 0;
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

        public bool AddNewStudent(int department_id, int semester_id, int section_id, String name, int IDcardNumber, Double studentContact, Double parentContact, String address, String email)
        {
            bool checkInsertion = false;
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO `tbl_student`(`dept_id`, `sem_id`, `sec_id`, `student_name`, `student_card_id`, `student_contact`, `parents_contact`, `student_address`, `student_email`) VALUES (@department, @semester, @section, @name, @idNumber, @studentContact, @parentContant, @address, @email)", connect);
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add(new MySqlParameter("@department", department_id));
                mySqlCommand.Parameters.Add(new MySqlParameter("@semester", semester_id));
                mySqlCommand.Parameters.Add(new MySqlParameter("@section", section_id));
                mySqlCommand.Parameters.Add(new MySqlParameter("@name", name));
                mySqlCommand.Parameters.Add(new MySqlParameter("@idNumber", IDcardNumber));
                mySqlCommand.Parameters.Add(new MySqlParameter("@studentContact", studentContact));
                mySqlCommand.Parameters.Add(new MySqlParameter("@parentContant", parentContact));
                mySqlCommand.Parameters.Add(new MySqlParameter("@address", address));
                mySqlCommand.Parameters.Add(new MySqlParameter("@email", email));
                if (mySqlCommand.ExecuteNonQuery() > 0)
                {
                    checkInsertion = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Department: " + ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
            return checkInsertion;
        }

        public void GetAllStudentList(DataGridView dataGridView)
        {
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT s.`student_id`, d.`dept_name`, sem.`sem_name`, sec.`sec_name`, s.`student_name`, s.`student_card_id`, s.`student_contact`, s.`parents_contact`, s.`student_address`, s.`student_email` FROM `db_attendance_assistance`.`tbl_student` AS s INNER JOIN `tbl_department` AS d ON s.`dept_id` = d.`dept_id` INNER JOIN `tbl_semester` AS sem ON s.`sem_id` = sem.`sem_id` INNER JOIN `tbl_section` AS sec ON s.`sec_id` = sec.`sec_id`; ", this.connect);
                using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
                {
                    //To count how many rows are fetched from Database
                    int count = 1;

                    while (mySqlDataReader.Read())
                    {
                        //To show in dataGridView
                        dataGridView.Rows.Add(count, mySqlDataReader["dept_name"], mySqlDataReader["sem_name"], mySqlDataReader["sec_name"], mySqlDataReader["student_name"], mySqlDataReader["student_card_id"], mySqlDataReader["student_contact"], mySqlDataReader["parents_contact"], mySqlDataReader["student_address"], mySqlDataReader["student_email"], mySqlDataReader["student_id"]);
                        count++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Student: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connect.Close();
            }
        }

        public void GetSingleStudent(TextBox studentName, TextBox idCardNumber, TextBox studentContact, TextBox parentContact, TextBox address, TextBox email, ComboBox semester, ComboBox section)
        {
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT `student_id`, `dept_id`, `sem_id`, `sec_id`, `student_name`, `student_card_id`, `student_contact`, `parents_contact`, `student_address`, `student_email` FROM `db_attendance_assistance`.`tbl_student` WHERE `student_id` = " + this.studentID + "; ", this.connect);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
               studentName.Text = dataTable.Rows[0]["student_name"].ToString();
                idCardNumber.Text = dataTable.Rows[0]["student_card_id"].ToString();
                studentContact.Text = dataTable.Rows[0]["student_contact"].ToString();
                parentContact.Text = dataTable.Rows[0]["parents_contact"].ToString();
                address.Text = dataTable.Rows[0]["student_address"].ToString();
                email.Text = dataTable.Rows[0]["student_email"].ToString();
                semester.SelectedValue = dataTable.Rows[0]["sem_id"];
                section.SelectedValue = dataTable.Rows[0]["sec_id"];
                dataTable.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Student single: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connect.Close();
            }
        }

        public bool UpdateStudent(int department_id, int semester_id, int section_id, String name, int IDcardNumber, Double studentContact, Double parentContact, String address, String email)
        {
            bool checkValidation = false;
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("UPDATE `db_attendance_assistance`.`tbl_student` SET `dept_id` = @department_id, `sem_id` = @semester_id, `sec_id` = @section_id, `student_name` = @name, `student_card_id` = @IDcardNumber, `student_contact` = @studentContact, `parents_contact` = @parentContact, `student_address` = @address, `student_email` = @email WHERE `student_id` = " + this.studentID + "; ", connect);
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add(new MySqlParameter("@department_id", department_id));
                mySqlCommand.Parameters.Add(new MySqlParameter("@semester_id", semester_id));
                mySqlCommand.Parameters.Add(new MySqlParameter("@section_id", section_id));
                mySqlCommand.Parameters.Add(new MySqlParameter("@name", name));
                mySqlCommand.Parameters.Add(new MySqlParameter("@IDcardNumber", IDcardNumber));
                mySqlCommand.Parameters.Add(new MySqlParameter("@studentContact", studentContact));
                mySqlCommand.Parameters.Add(new MySqlParameter("@parentContact", parentContact));
                mySqlCommand.Parameters.Add(new MySqlParameter("@address", address));
                mySqlCommand.Parameters.Add(new MySqlParameter("@email", email));

                if (mySqlCommand.ExecuteNonQuery() > 0)
                {
                    checkValidation = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Student Update: " + ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
            return checkValidation;
        }
    }
}

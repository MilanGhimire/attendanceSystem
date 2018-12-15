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
        public Semester()
        {
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
    }
}

using System;
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
    }
}

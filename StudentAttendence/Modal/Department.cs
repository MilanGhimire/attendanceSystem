﻿using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentAttendence.Controller
{
    class Department
    {
        private MySqlConnection connect;
        public int departmentID;

        public Department()
        {
            departmentID = 0;
            Database database = new Database();
            try
            {
                this.connect = database.getDatabaseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Department: " + ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool AddNewDepartment(String name, String type, int duration)
        {
            bool checkInsertion = false;
            String[] durationNames = { "First", "Second", "Third", "Forth", "Fifth", "Sixth", "Seventh", "Eight", "Nineth", "Thenth" };
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = connect.CreateCommand();
                MySqlTransaction mySqlTransaction;
                //Start a local transaction
                mySqlTransaction = connect.BeginTransaction();
                //Must assign both transaction object and connection to Command object for a pending local transaction
                mySqlCommand.Connection = connect;
                mySqlCommand.Transaction = mySqlTransaction;

                try
                {
                    //Department Inserted
                    mySqlCommand.CommandText = "INSERT INTO `tbl_department`(`dept_name`, `gradutaion_type`, `course_duration`) VALUES (@name, @type, @duration)";
                    mySqlCommand.Parameters.Clear();
                    mySqlCommand.Parameters.Add(new MySqlParameter("@name", name));
                    mySqlCommand.Parameters.Add(new MySqlParameter("@type", type));
                    mySqlCommand.Parameters.Add(new MySqlParameter("@duration", duration));
                    mySqlCommand.ExecuteNonQuery();

                    //Get DepartmentID to insert the 
                    mySqlCommand.CommandText = "SELECT `dept_id`, `dept_name`, `gradutaion_type`, `course_duration` FROM `db_attendance_assistance`.`tbl_department` WHERE `dept_name` = @name; ";
                    mySqlCommand.Parameters.Clear();
                    mySqlCommand.Parameters.Add(new MySqlParameter("@name", name));
                    mySqlCommand.ExecuteNonQuery();

                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                    DataTable dataTable = new DataTable();
                    mySqlDataAdapter.Fill(dataTable);
                    //MessageBox.Show(dataTable.Rows[0]["dept_name"].ToString());

                    //Insert the semester names
                    for (int i = 0; i < duration; i++)
                    {
                        mySqlCommand.CommandText = "INSERT INTO `db_attendance_assistance`.`tbl_semester` (`dept_id`, `sem_name`) VALUES(@departmentID, @semesterName);";
                        mySqlCommand.Parameters.Clear();
                        mySqlCommand.Parameters.Add(new MySqlParameter("@departmentID", Convert.ToInt32(dataTable.Rows[0]["dept_id"])));
                        mySqlCommand.Parameters.Add(new MySqlParameter("@semesterName", durationNames[i] + " " + type));
                        mySqlCommand.ExecuteNonQuery();
                    }

                    mySqlTransaction.Commit();
                    //Both transactions are written in the database.
                    checkInsertion = true;
                }
                catch (Exception ex)
                {
                    try
                    {
                        mySqlTransaction.Rollback();
                    }
                    catch (MySqlException e)
                    {
                        MessageBox.Show("An exception of type " + e.GetType() + "was encountered while attemption to rollback the transaction.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MessageBox.Show("An exception of type " + ex.GetType() + "was encountered while attemption to inserting the data.\n Neither record was written to database.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool CheckForDepartmentName(String name)
        {
            bool checkValidation = false;
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT `dept_id`, `dept_name`, `gradutaion_type`, `course_duration` FROM `tbl_department` WHERE `dept_name`=@name", connect);
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add(new MySqlParameter("@name", name));

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
                MessageBox.Show("Department: " + ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
            return checkValidation;
        }

        public void LoadAllDepartment(ComboBox comboBox)
        {
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT `dept_id`, `dept_name` FROM `tbl_department`;", this.connect);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                comboBox.DisplayMember = "dept_name";
                comboBox.ValueMember = "dept_id";
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

        public void GetAllDepartmentList(DataGridView dataGridView)
        {
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT `dept_id`, `dept_name`, `gradutaion_type`, `course_duration` FROM `db_attendance_assistance`.`tbl_department`;", this.connect);
                using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
                {
                    //To count how many rows are fetched from Database
                    int count = 1;

                    while (mySqlDataReader.Read())
                    {
                        //To show in dataGridView
                        dataGridView.Rows.Add(count, mySqlDataReader["dept_name"], mySqlDataReader["gradutaion_type"], mySqlDataReader["course_duration"], mySqlDataReader["dept_id"]);
                        count++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Department: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connect.Close();
            }
        }

        public void GetSingleDepartment(TextBox departmentName, ComboBox courseType, NumericUpDown numberOf)
        {
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT `dept_id`, `dept_name`, `gradutaion_type`, `course_duration` FROM `db_attendance_assistance`.`tbl_department` WHERE `dept_id` = " + this.departmentID + ";", this.connect);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                this.departmentID = Convert.ToInt32(dataTable.Rows[0]["dept_id"]);
                departmentName.Text = dataTable.Rows[0]["dept_name"].ToString();
                courseType.Text = dataTable.Rows[0]["gradutaion_type"].ToString();
                numberOf.Value = Convert.ToDecimal(dataTable.Rows[0]["course_duration"]);
                dataTable.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Department: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connect.Close();
            }
        }

        public bool UpdateDepartment(String departmentName, String courseType, int duration)
        {
            bool checkValidation = false;
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("UPDATE `db_attendance_assistance`.`tbl_department` SET `dept_name` = @departmentName, `gradutaion_type` = @courseType, `course_duration` = @duration WHERE `dept_id` = " + this.departmentID + "; ", connect);
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add(new MySqlParameter("@departmentName", departmentName));
                mySqlCommand.Parameters.Add(new MySqlParameter("@courseType", courseType));
                mySqlCommand.Parameters.Add(new MySqlParameter("@duration", duration));

                if (mySqlCommand.ExecuteNonQuery() > 0)
                {
                    checkValidation = true;
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
            return checkValidation;
        }

        public string GetDepartmentName(int departmentID)
        {
            string departmentName = string.Empty;
            try
            {
                connect.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT `dept_id`, `dept_name`, `gradutaion_type`, `course_duration` FROM `db_attendance_assistance`.`tbl_department` WHERE `dept_id` = " + departmentID + ";", this.connect);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                departmentName = dataTable.Rows[0]["dept_name"].ToString();
                dataTable.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Get Department Name: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connect.Close();
            }
            return departmentName;
        }
    }
}

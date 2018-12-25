using System;
using MySql.Data.MySqlClient;

namespace StudentAttendence.Controller
{
    class Database
    {
        public static String connectionString = "Data Source = localhost; user = root; password = @part; database = db_student_attendance";
        private MySqlConnection connect;

        public MySqlConnection getDatabaseConnection()
        {
            if (this.connect != null)
            {
                //System.Console.WriteLine("Connection is already open.");
                return connect;
            }
            else
            {
                //System.Console.WriteLine("connection is new.");
                connect = new MySqlConnection(connectionString);
                return connect;
            }
        }
    }
}


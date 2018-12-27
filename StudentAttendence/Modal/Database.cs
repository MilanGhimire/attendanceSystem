using System;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace StudentAttendence.Controller
{
    class Database
    {
        public static String value = ConfigurationManager.AppSettings["key"];

        public static String connectionString = "Data Source = "+ value +"; user = root; password = @part; database = db_student_attendance";
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
                System.Console.WriteLine("Connection is already open." + value);
                //System.Console.WriteLine("connection is new.");
                connect = new MySqlConnection(connectionString);
                return connect;
            }
        }
    }
}


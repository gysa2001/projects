using MySql.Data.MySqlClient;
using System.Configuration;

namespace TaskManagementApp
{
    public class DatabaseConnection
    {
        static public MySqlConnection connection;
        private string server;
        string port;
        private string database;
        private string username;
        private string password;
        private string sslMode;
        private string connectionString;
        public DatabaseConnection()
        {
            server = Properties.Settings.Default.ServerAddress;
            port = Properties.Settings.Default.Port;
            database = Properties.Settings.Default.Database;
            username = Properties.Settings.Default.Username;
            password = Properties.Settings.Default.Password;
            sslMode = "Preferred";
            connectionString = $"Server={server};" +
                               $"Port={port};" +
                               $"Database={database};" +
                               $"Uid={username};" +
                               $"Pwd={password};" +
                               $"Persist Security Info=True;" +
                               $"Convert Zero Datetime=True;sslmode={sslMode};";
        }


        public void ConnectToDatabase()
        {
            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CloseConnection()
        {
            connection.Close();
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;
using System.Globalization;

namespace TaskManagementApp
{
    internal class Authenticator
    {
        public bool IsUserExist(string username)
        {
            string sql = "SELECT COUNT(*) FROM Users WHERE Username = @Username;";
            MySqlCommand CheckUsername = new MySqlCommand(sql, DatabaseConnection.connection);
            CheckUsername.Parameters.AddWithValue("@Username", username);

            long userCount = (long)CheckUsername.ExecuteScalar();

            return userCount > 0;
        }

        public bool IsPasswordCorrect(string username, string password)
        {
            string sql = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password;";
            MySqlCommand CheckPassword = new MySqlCommand(sql, DatabaseConnection.connection);
            CheckPassword.Parameters.AddWithValue("@Username", username);
            CheckPassword.Parameters.AddWithValue("@Password", Cryptography.Encrypt(password));

            long passCount = (long)CheckPassword.ExecuteScalar();

            return passCount > 0;
        }

        public bool AddUser(User user)
        {
            try
            {
                string query = "INSERT INTO Users (Name, Surname, Username, Email, Password, CreatedAt) VALUES (@Name, @Surname, @Username, @Email, @Password, NOW())";

                MySqlCommand command = new MySqlCommand(query, DatabaseConnection.connection);

                command.Parameters.AddWithValue("@Name", user.Name);
                command.Parameters.AddWithValue("@Surname", user.Surname);
                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Password", Cryptography.Encrypt(user.Password));

                command.ExecuteNonQuery();
                
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error creating new account: {ex.Message}", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void UpdatePassword(string username, string password)
        {
           
            string query = "UPDATE Users SET Password = @NewPassword WHERE Username = @Username";

            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.connection);

            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@NewPassword", Cryptography.Encrypt(password));
            command.ExecuteNonQuery();
            
        }

        public void UpdateUserInfo(User user)
        {

            string query = "UPDATE Users SET Name = @Name, Surname = @Surname, Username = @Username, Email = @Email, Password = @NewPassword WHERE Username = @Username";

            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.connection);

            command.Parameters.AddWithValue("@Name", user.Name);
            command.Parameters.AddWithValue("@Surname", user.Surname);
            command.Parameters.AddWithValue("@Username", user.Username);
            command.Parameters.AddWithValue("@Email", user.Email);
            command.Parameters.AddWithValue("@NewPassword", Cryptography.Encrypt(user.Password));
            command.ExecuteNonQuery();

        }

        public static User GetUserByUsername(string username)
        {
            User user = null;

            string query = "SELECT * FROM Users WHERE Username = @Username";
            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.connection);
            command.Parameters.AddWithValue("@Username", username);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    user = new User
                    {
                        Id = reader.GetInt32(0),
                        Name = reader["Name"].ToString(),
                        Surname = reader["Surname"].ToString(),
                        Username = reader["Username"].ToString(),
                        Email = reader["Email"].ToString(),
                        Password = reader["Password"].ToString()
                    };
                }
            }

            return user;
        }

        public static int GetUserIdByUsername(string username)
        {
            int Id = 0;

            string query = "SELECT Id FROM Users WHERE Username = @Username";
            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.connection);
            command.Parameters.AddWithValue("@Username", username);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    Id = reader.GetInt32(0);
                }
            }

            return Id;
        }

        public static string GetUsernameByUserId(int Id)
        {
            string username = "";

            string query = "SELECT Username FROM Users WHERE Id = @Id";
            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.connection);
            command.Parameters.AddWithValue("@Id", Id);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    username = reader["Username"].ToString();
                }
            }

            return username;
        }

        public static void DeleteAccount()
        {
            string query = "DELETE FROM Sharings WHERE OwnUserId = @Id OR SharedWithUserId = @Id;";
            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.connection);
            command.Parameters.AddWithValue("@Id", Program.session.currentUser.Id);
            command.ExecuteNonQuery();

            query = "DELETE FROM Tasks WHERE UserId = @Id;";
            command = new MySqlCommand(query, DatabaseConnection.connection);
            command.Parameters.AddWithValue("@Id", Program.session.currentUser.Id);
            command.ExecuteNonQuery();

            query = "DELETE FROM Sessions WHERE UserId = @Id;";
            command = new MySqlCommand(query, DatabaseConnection.connection);
            command.Parameters.AddWithValue("@Id", Program.session.currentUser.Id);
            command.ExecuteNonQuery();

            query = "DELETE FROM Users WHERE Id = @Id;";
            command = new MySqlCommand(query, DatabaseConnection.connection);
            command.Parameters.AddWithValue("@Id", Program.session.currentUser.Id);
            command.ExecuteNonQuery();
        }

        public string GenerateRandomPassword()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789 !\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
            return new string(Enumerable.Repeat(chars, 10).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static void Login(string username)
        {
            Program.session = new Session(GetUserByUsername(username));
            Program.session.Start();
        }

        public static void Logout()
        {
            Program.session.Stop();
        }
    }
}

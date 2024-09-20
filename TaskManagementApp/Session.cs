using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementApp
{
    internal class Session
    {
        public User currentUser;
        public UserSettings settings;
        public DashboardForm dashboard;
        public Session(User user)
        {
            currentUser = user;

            settings = new UserSettings();
            settings.SetFileName(user.Username);

            if (!Directory.Exists(UserSettings.settingsPath))
            {
                Directory.CreateDirectory(UserSettings.settingsPath);
            }

            if (!File.Exists(UserSettings.settingsFile))
            {
                settings = new UserSettings();
                UserSettings.WriteToFile(settings);
            }
            else
            {
                settings = UserSettings.Get();
            }
        }

        public void Start()
        {
            string query = "INSERT INTO Sessions (UserId, CreatedAt) VALUES (@Id, NOW())";

            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.connection);

            command.Parameters.AddWithValue("@Id", currentUser.Id);
            command.ExecuteNonQuery();

            dashboard = new DashboardForm(currentUser);

            if(string.IsNullOrEmpty(Properties.Settings.Default.CurrentUserUsername))
            {
                dashboard.ShowDialog();
            }
            else
            {
                dashboard.Show();
            }
        }
        public void Stop()
        {
            string query = "DELETE FROM Sessions WHERE UserId = @UserId";
            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.connection);
            command.Parameters.AddWithValue("@UserId", currentUser.Id);
            command.ExecuteNonQuery();
        }
    }
}

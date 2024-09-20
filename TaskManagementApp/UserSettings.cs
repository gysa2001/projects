using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace TaskManagementApp
{
    public class UserSettings
    {
        public static string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string settingsPath = Path.Combine(documentsPath, "Task Management App");
        public static string settingsFile;

        public bool IsAutoLogin {  get; set; }
        public List<string> Categories {  get; set; }
        public ThemeName theme {  get; set; }

        public void SetFileName( string userName)
        {
            settingsFile = Path.Combine(settingsPath, $"{userName}_settings.json");
        }
        public enum ThemeName
        {
            red,
            blue,
            green
        }



        public UserSettings(bool is_auto_login, List<string> categories)
        {
            IsAutoLogin = is_auto_login;
            Categories = categories;
        }

        public UserSettings()
        {
            IsAutoLogin=false;
            Categories = new List<string> { "Personal", "Education", "Work","Other"};
            theme = ThemeName.blue;
        }

        public static void WriteToFile(UserSettings settings)
        {
            string jsonString = JsonSerializer.Serialize(settings);
            File.WriteAllText(settingsFile, jsonString);
        }

        public static UserSettings Get()
        {
            try
            {
                if (new FileInfo(settingsFile).Length > 0)
                {
                    string jsonString = File.ReadAllText(settingsFile);
                    return JsonSerializer.Deserialize<UserSettings>(jsonString)
                        ?? new UserSettings();
                }
                else
                {
                    return new UserSettings();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading user settings file: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new UserSettings();
            }
        }
    }
}

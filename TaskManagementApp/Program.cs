
using TaskManagementApp.Forms;

namespace TaskManagementApp
{
    internal static class Program
    {
        static public LoginForm LoginForm;
        static public Session session;
        
        [STAThread]
        static void Main()
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.ConnectToDatabase();
            ApplicationConfiguration.Initialize();

            Properties.Settings.Default.CurrentUserUsername = string.Empty;
            Properties.Settings.Default.Save();

            if (string.IsNullOrEmpty(Properties.Settings.Default.CurrentUserUsername))
            {
                LoginForm = new LoginForm();
                Application.Run(LoginForm);
            }
            else
            {
                Authenticator.Login(Properties.Settings.Default.CurrentUserUsername);
                Application.Run(session.dashboard);
            }
        }
    }
}
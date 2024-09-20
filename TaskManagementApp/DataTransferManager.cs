using Google.Protobuf.Compiler;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementApp
{
    public class DataTransferManager
    {
        public static void ExportDataToJson(string fileName)
        {
            try
            {
                List<Task> tasks = new List<Task>();

                string query = "SELECT Id, Title, Description, Deadline, Status, Category, Priority " +
                "FROM Tasks WHERE UserId = @UserId;";
                MySqlCommand command = new MySqlCommand(query, DatabaseConnection.connection);
                command.Parameters.AddWithValue("@UserId", Program.session.currentUser.Id);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Task task = new Task
                    {
                        Title = reader["Title"].ToString(),
                        Description = reader["Description"].ToString(),
                        Deadline = DateTime.ParseExact(reader["Deadline"].ToString(), "yyyy-MM-dd HH:mm:ss",
                        CultureInfo.InvariantCulture, DateTimeStyles.None),
                        Status = reader["Status"].ToString(),
                        Category = reader["Category"].ToString(),
                        Priority = Convert.ToInt32(reader["Priority"])
                    };
                    tasks.Add(task);
                }

                reader.Close();
                string json = JsonConvert.SerializeObject(tasks);
                File.WriteAllText(fileName, json);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error exporting data: {ex.Message}","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ImportDataFromJson(string fileName)
        {
            try
            {
                string json = File.ReadAllText(fileName);
                List<Task> tasks = JsonConvert.DeserializeObject<List<Task>>(json);


                foreach (Task task in tasks)
                {
                    string query = "INSERT INTO Tasks (UserId, Title, Description, Deadline, Status,Category, Priority, CreatedAt)" +
                    " VALUES (@UserId, @Title, @Description, @Deadline, @Status,@Category, @Priority , NOW())";

                    MySqlCommand command = new MySqlCommand(query, DatabaseConnection.connection);

                    command.Parameters.AddWithValue("@UserId", Program.session.currentUser.Id);
                    command.Parameters.AddWithValue("@Title", task.Title);
                    command.Parameters.AddWithValue("@Description", task.Description);
                    command.Parameters.AddWithValue("@Deadline", task.Deadline);
                    command.Parameters.AddWithValue("@Status", task.Status);
                    command.Parameters.AddWithValue("@Category", task.Category);
                    command.Parameters.AddWithValue("@Priority", task.Priority);
                    command.ExecuteNonQuery();
                }
                Program.session.dashboard.LoadTasks();
            }
            catch( Exception ex )
            {
                MessageBox.Show($"Error importing data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

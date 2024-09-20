using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementApp
{
    public class Task
    {
        public int Id { get; set; }
        public string Title;
        public string Description;
        public DateTime Deadline;
        public string Status;
        public string Category;
        public int Priority;
        public DateTime CreatedAt;
        public Task(int id,string title, string description, DateTime deadline, string status, string category, int priority, DateTime createdAt)
        {
            Id = id;
            Title = title;
            Description = description;
            Deadline = deadline;
            Status = status;
            Category = category;
            Priority = priority;
            CreatedAt = createdAt;
        }

        public Task(int id, string title, string description, DateTime deadline, string status, string category, int priority)
        {
            Id = id;
            Title = title;
            Description = description;
            Deadline = deadline;
            Status = status;
            Category = category;
            Priority = priority;
        }
        public Task(string title, string description, DateTime deadline, string status, string category, int priority)
        {
            Title = title;
            Description = description;
            Deadline = deadline;
            Status = status;
            Category = category;
            Priority = priority;
        }
        public Task() { }

        public static bool IsTitleValid(string title)
        {
            return !string.IsNullOrWhiteSpace(title);
        }

        public static bool IsDescriptionValid(string description)
        {
            return !string.IsNullOrWhiteSpace(description);
        }

        public static bool AddTask(Task task)
        {
            try
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

                int taskId;
                string selectTaskIdQuery = @"SELECT MAX(Id) FROM Tasks;";
                MySqlCommand selectTaskIdCommand = new MySqlCommand(selectTaskIdQuery, DatabaseConnection.connection);
                taskId = Convert.ToInt32(selectTaskIdCommand.ExecuteScalar());

                task.Id = taskId;

                //MessageBox.Show("Task added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding task: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static List<Task> GetCurrentUserTasks()
        {
            List<Task> tasks = new List<Task>();

            string query = "SELECT * " +
                "FROM Tasks WHERE UserId = @UserId;";
            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.connection);
            command.Parameters.AddWithValue("@UserId", Program.session.currentUser.Id);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Task task = new Task
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Title = reader["Title"].ToString(),
                    Description = reader["Description"].ToString(),
                    Deadline = DateTime.ParseExact(reader["Deadline"].ToString(), "yyyy-MM-dd HH:mm:ss",
                    CultureInfo.InvariantCulture, DateTimeStyles.None),
                    Status = reader["Status"].ToString(),
                    Category = reader["Category"].ToString(),
                    Priority = Convert.ToInt32(reader["Priority"]),
                    CreatedAt = DateTime.ParseExact(reader["CreatedAt"].ToString(), "yyyy-MM-dd HH:mm:ss",
                    CultureInfo.InvariantCulture, DateTimeStyles.None)
                };

                tasks.Add(task);
            }

            reader.Close();

            return tasks;
        }

        public static Task GetTaskById(int id)
        {
            Task task = new Task();

            string query = "SELECT Id, Title, Description, Deadline, Status, Category, Priority " +
                "FROM Tasks WHERE Id = @Id;";
            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.connection);
            command.Parameters.AddWithValue("@Id", id);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                task = new Task
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Title = reader["Title"].ToString(),
                    Description = reader["Description"].ToString(),
                    Deadline = DateTime.ParseExact(reader["Deadline"].ToString(), "yyyy-MM-dd HH:mm:ss",
                    CultureInfo.InvariantCulture, DateTimeStyles.None),
                    Status = reader["Status"].ToString(),
                    Category = reader["Category"].ToString(),
                    Priority = Convert.ToInt32(reader["Priority"])
                };
            }

            reader.Close();

            return task;
        }

        public static List<Task> GetCurrentUserSharedTasks()
        {
            List<Task> tasks = new List<Task>();

            string query = "SELECT Id, Title, Description, Deadline, Status, Category, Priority " +
                "FROM Tasks LEFT JOIN Sharings ON Tasks.Id = Sharings.TaskId WHERE Sharings.SharedWithUserId = @UserId;";
            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.connection);
            command.Parameters.AddWithValue("@UserId", Program.session.currentUser.Id);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Task task = new Task
                {
                    Id = Convert.ToInt32(reader["Id"]),
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

            return tasks;
        }

        public static void UpdateTask(Task task)
        {

            string query = "UPDATE Tasks SET Title = @NewTitle, Description = @NewDescription, " +
                "Deadline = @NewDeadline, Status = @NewStatus, Category = @NewCategory, Priority = @NewPriority  WHERE Id = @TaskId;";

            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.connection);

            command.Parameters.AddWithValue("@TaskId", task.Id);
            command.Parameters.AddWithValue("@NewTitle", task.Title);
            command.Parameters.AddWithValue("@NewDescription", task.Description);
            command.Parameters.AddWithValue("@NewDeadline", task.Deadline);
            command.Parameters.AddWithValue("@NewStatus", task.Status);
            command.Parameters.AddWithValue("@NewCategory", task.Category);
            command.Parameters.AddWithValue("@NewPriority", task.Priority);
            command.ExecuteNonQuery();

        }

        public static void DeleteTask(int id)
        {
            string query = "DELETE FROM Tasks WHERE Id = @TaskId;";
            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.connection);
            command.Parameters.AddWithValue("@TaskId", id);

            command.ExecuteNonQuery();
        }
    }
}

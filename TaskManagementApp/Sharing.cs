using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TaskManagementApp
{
    public class Sharing
    {
        public int Id;
        public int TaskId;
        public int OwnUserId;
        public int ShareWithUserId;

        public Sharing() { }
        public Sharing(int id, int taskId, int ownUserId, int shareWithUserId)
        {
            Id = id;
            TaskId = taskId;
            OwnUserId = ownUserId;
            ShareWithUserId = shareWithUserId;
        }
        public Sharing(int taskId, int ownUserId, int shareWithUserId)
        {
            TaskId = taskId;
            OwnUserId = ownUserId;
            ShareWithUserId = shareWithUserId;
        }

        public static int ShareTask(int task_id, string[] users, int rights = 0)
        {
            int sharingId = -1;
            try
            {
                foreach (string user in users)
                {
                    string query = "INSERT INTO Sharings (TaskId, OwnUserId, SharedWithUserId, Rights, CreatedAt) " +
                        "VALUES (@TaskId, @OwnUserId, @SharedWithUserId, @Rights, NOW())";

                    MySqlCommand command = new MySqlCommand(query, DatabaseConnection.connection);

                    command.Parameters.AddWithValue("@TaskId", task_id);
                    command.Parameters.AddWithValue("@OwnUserId", Program.session.currentUser.Id);
                    command.Parameters.AddWithValue("@SharedWithUserId", Authenticator.GetUserIdByUsername(user));
                    command.Parameters.AddWithValue("@Rights", 0);

                    command.ExecuteNonQuery();

                    string selectTaskIdQuery = @"SELECT MAX(Id) FROM Sharings;";
                    MySqlCommand selectTaskIdCommand = new MySqlCommand(selectTaskIdQuery, DatabaseConnection.connection);
                    sharingId = Convert.ToInt32(selectTaskIdCommand.ExecuteScalar());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sharing task: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return sharingId;
        }
        public static List<Sharing> GetSharingsByCurrentUser()
        {
            List<Sharing> sharings = new List<Sharing>();

            string query = "SELECT * FROM Sharings WHERE OwnUserId = @UserId";
            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.connection);
            command.Parameters.AddWithValue("@UserId", Program.session.currentUser.Id);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Sharing sharing = new Sharing
                    {
                        Id = reader.GetInt32(0),
                        TaskId = reader.GetInt32(1),
                        OwnUserId = reader.GetInt32(2),
                        ShareWithUserId = reader.GetInt32(3)
                    };
                    sharings.Add(sharing);
                }
            }

            return sharings;
        }

        public static List<Sharing> GetSharingsWithCurrentUser()
        {
            List<Sharing> sharings = new List<Sharing>();

            string query = "SELECT * FROM Sharings WHERE SharedWithUserId = @UserId";
            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.connection);
            command.Parameters.AddWithValue("@UserId", Program.session.currentUser.Id);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Sharing sharing = new Sharing
                    {
                        Id = reader.GetInt32(0),
                        TaskId = reader.GetInt32(1),
                        OwnUserId = reader.GetInt32(2),
                        ShareWithUserId = reader.GetInt32(3),
                    };
                    sharings.Add(sharing);
                }
            }

            return sharings;
        }

        public static bool IsShared(int task_id, int shared_with_user)
        {
            string sql = "SELECT COUNT(*) FROM Sharings WHERE TaskId = @TaskId AND OwnUserId = @OwnUserId AND SharedWithUserId = @SharedWithUserId;";
            MySqlCommand CheckUsername = new MySqlCommand(sql, DatabaseConnection.connection);
            CheckUsername.Parameters.AddWithValue("@TaskId", task_id);
            CheckUsername.Parameters.AddWithValue("@OwnUserId", Program.session.currentUser.Id);
            CheckUsername.Parameters.AddWithValue("@SharedWithUserId", shared_with_user);

            long shareCount = (long)CheckUsername.ExecuteScalar();

            return shareCount > 0;
        }
        public static void DeleteSharing(int id)
        {
            string query = "DELETE FROM Sharings WHERE Id = @SharingId;";
            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.connection);
            command.Parameters.AddWithValue("@SharingId", id);

            command.ExecuteNonQuery();
        }
    }
}

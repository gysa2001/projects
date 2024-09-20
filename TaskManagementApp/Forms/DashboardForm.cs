using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Org.BouncyCastle.Tls;
using ReaLTaiizor.Forms;
using ReaLTaiizor;
using ReaLTaiizor.Child.Material;
using TaskManagementApp.Forms;
using Microsoft.Toolkit.Uwp.Notifications;
using System.IO;
using Windows.ApplicationModel.Contacts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace TaskManagementApp
{
    public partial class DashboardForm : MaterialForm
    {
        public TaskForm taskForm { get; set; }
        public List<string> priorities = new List<string> { "1 - lowest", "2 - low", "3 - medium", "4 - high", "5 - highest" };
        private List<Task> tasks;
        private bool IsDeletingAccount = false;
        private Dictionary<int,bool> IsReminderSended;
        public DashboardForm(User user)
        {
            InitializeComponent();
            LoadTableSettings();
            LoadTasks();
            AddCategories();
            LoadCategories();
            LoadSharings();

            NameTextBox.Text = user.Name;
            SurnameTextBox.Text = user.Surname;
            UsernameTextBox.Text = user.Username;
            EmailTextBox.Text = user.Email;
            PasswordTextBox.Text = Cryptography.Decrypt(user.Password);
            ConfirmPasswordTextBox.Text = Cryptography.Decrypt(user.Password);

            IsReminderSended = new Dictionary<int, bool>();

            if (string.IsNullOrEmpty(Properties.Settings.Default.CurrentUserUsername))
            {
                LoginStatusSwitch.Checked = false;
            }
            else
            {
                LoginStatusSwitch.Checked = true;
            }


            InitializeEventHandlers();

            LoadTheme();

            MessageTimer.Start();

            TasksComboBox.SelectedIndex = 0;

            LoadAnalysis();
        }

        private void LoadTheme()
        {
            AppTheme appTheme = new AppTheme(this);
            switch (Program.session.settings.theme)
            {
                case UserSettings.ThemeName.red:
                    appTheme.Red();
                    RedThemeRadioButton.Checked = true;
                    break;
                case UserSettings.ThemeName.blue:
                    appTheme.Blue();
                    BlueThemeRadioButton.Checked = true;
                    break;
                case UserSettings.ThemeName.green:
                    appTheme.Green();
                    GreenThemeRadioButton.Checked = true;
                    break;
            }
        }

        private void LoadTableSettings()
        {
            TasksList.EnableHeadersVisualStyles = true;
            TasksList.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            TasksList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            TasksList.DefaultCellStyle.BackColor = Color.White;
            TasksList.DefaultCellStyle.ForeColor = Color.Black;
            TasksList.DefaultCellStyle.SelectionBackColor = Color.White;
            TasksList.DefaultCellStyle.SelectionForeColor = Color.Black;

            SharingsTable.EnableHeadersVisualStyles = true;
            SharingsTable.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            SharingsTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            SharingsTable.DefaultCellStyle.BackColor = Color.White;
            SharingsTable.DefaultCellStyle.ForeColor = Color.Black;
            SharingsTable.DefaultCellStyle.SelectionBackColor = Color.White;
            SharingsTable.DefaultCellStyle.SelectionForeColor = Color.Black;

            CategoryBox.SelectedIndex = 0;
        }

        public void LoadTasks()
        {

            List<Task> tasks = Task.GetCurrentUserTasks();

            if (tasks.Count == 0)
            {
                NoTasksLabel.Visible = true;
                TasksList.Visible = false;
                TasksComboBox.Items.Clear();
                TasksComboBox.Items.Add(NoTasksLabel.Text);
            }
            else
            {
                NoTasksLabel.Visible = false;
                TasksList.Visible = true;
                foreach (Task task in tasks)
                {
                    TasksList.Rows.Add(task.Id.ToString(), task.Title, task.Description,
                        task.Deadline.ToString("yyyy-MM-dd HH:mm"), task.Status, task.Category, priorities[task.Priority - 1]);
                    TasksComboBox.Items.Add(task.Title);
                    TasksIdComboBox.Items.Add(task.Id);
                }
            }

            TasksList.Sort(TasksList.Columns["Priority"], ListSortDirection.Descending);
        }
        private void AddCategories()
        {
            foreach (String cat in Program.session.settings.Categories)
            {
                CategoryBox.Items.Add(new MaterialListBoxItem(cat));
            }
        }
        public void LoadCategories()
        {
            List<Task> tasks = Task.GetCurrentUserTasks();
            foreach (MaterialListBoxItem cat in CategoryBox.Items)
            {
                if (!cat.Text.Split(' ')[0].Equals("All"))
                {
                    int tasksCount = tasks.Count(task => task.Category.Equals(cat.Text.Split(' ')[0]));
                    cat.Text = $"{cat.Text.Split(' ')[0]} ({tasksCount})";
                }
                else
                {
                    cat.Text = $"{cat.Text.Split(' ')[0]} ({tasks.Count})";
                }
            }
            CategoryBox.Refresh();

        }

        public void LoadAnalysis()
        {
            DataAnalysis DataAnalysis = new DataAnalysis();
            AvTaskDurVal.Text = DataAnalysis.AverageTaskDuration().Days.ToString();
            TasksThisMonthL.Text = DataAnalysis.DeadlinesCountInCurrentMonth().ToString();
            TasksCompletedProgBar.Value = (int)DataAnalysis.PercentageCompletedTasks();

            AvTaskDurVal.Refresh();
            TasksThisMonthL.Refresh();
            TasksCompletedProgBar.Refresh();
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!IsDeletingAccount)
            {
                Authenticator.Logout();
            }

            if (Program.LoginForm != null)
            {
                Program.LoginForm.Close();
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewTaskButton_Click(object sender, EventArgs e)
        {
            taskForm = new TaskForm();
            taskForm.OpenNewTaskForm();
        }

        private void TasksList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == TasksList.Columns["EditCol"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = TasksList.Rows[e.RowIndex];
                string Id = (string)selectedRow.Cells["Id"].Value;
                string title = (string)selectedRow.Cells["Title"].Value;
                string decription = (string)selectedRow.Cells["Description"].Value;
                DateTime deadline = DateTime.ParseExact((string)selectedRow.Cells["Deadline"].Value, "yyyy-MM-dd HH:mm",
                    CultureInfo.InvariantCulture, DateTimeStyles.None);
                string status = (string)selectedRow.Cells["Status"].Value;
                string category = (string)selectedRow.Cells["Category"].Value;
                string priority = (string)selectedRow.Cells["Priority"].Value;

                taskForm = new TaskForm();

                taskForm.IdBox.Text = Id;
                taskForm.TaskTitleBox.Text = title;
                taskForm.TaskDescriptionBox.Text = decription;
                taskForm.DeadlinePicker.Value = deadline;
                taskForm.StatusBox.SelectedItem = status;
                taskForm.CategoryBox.SelectedItem = category;
                taskForm.PriorityBox.SelectedItem = priority;

                taskForm.OpenEditTaskForm();
            }
            else if (e.ColumnIndex == TasksList.Columns["DeleteCol"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    DataGridViewRow selectedRow = TasksList.Rows[e.RowIndex];
                    int Id = int.Parse((string)selectedRow.Cells["Id"].Value);
                    TasksList.Rows.RemoveAt(e.RowIndex);
                    LoadCategories();

                    if (TasksList.Rows.Count == 0)
                    {
                        TasksList.Visible = false;
                        NoTasksLabel.Visible = true;
                    }

                    Task.DeleteTask(Id);

                    return;
                }
                else
                {
                    return;
                }
            }
            LoadCategories();
            LoadAnalysis();
            Program.session.dashboard.TasksList.Sort(Program.session.dashboard.TasksList.Columns["Priority"], ListSortDirection.Descending);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            TasksList.Rows.Clear();
            LoadTasks();
            LoadCategories();
        }

        private void LoginStatusSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (LoginStatusSwitch.Checked)
            {
                Properties.Settings.Default.CurrentUserUsername = Program.session.currentUser.Username;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.CurrentUserUsername = string.Empty;
                Properties.Settings.Default.Save();
            }
        }

        private void ShowTasksByCategory(string category, List<Task> tasks)
        {
            if (tasks.Count == 0)
            {
                TasksList.Visible = false;
                NoTasksLabel.Visible = true;
            }
            else
            {
                NoTasksLabel.Visible = false;
                TasksList.Visible = true;
                TasksList.Rows.Clear();
                foreach (Task task in tasks)
                {
                    if (task.Category == category)
                    {
                        TasksList.Rows.Add(task.Id.ToString(), task.Title, task.Description,
                            task.Deadline.ToString("yyyy-MM-dd HH:mm"), task.Status, task.Category, priorities[task.Priority - 1]);
                    }
                }
                TasksList.Sort(TasksList.Columns["Priority"], ListSortDirection.Descending);
            }
        }

        private void materialListBox2_SelectedIndexChanged(object sender, ReaLTaiizor.Child.Material.MaterialListBoxItem selectedItem)
        {
            string category = selectedItem.Text.Split(' ')[0];

            if (category == "All")
            {
                NoTasksLabel.Visible = false;
                TasksList.Visible = true;
                TasksList.Rows.Clear();
                TasksComboBox.Items.Clear();
                TasksIdComboBox.Items.Clear();
                LoadTasks();
            }
            else
            {
                List<Task> tasks = Task.GetCurrentUserTasks();
                Dictionary<int, Task> map = new Dictionary<int, Task>();

                foreach (Task task in tasks)
                {
                    map[task.Id] = task;
                }

                var results = map.Where(pair => pair.Value.Category.Contains(category)).ToDictionary(pair => pair.Key, pair => pair.Value);

                ShowTasksByCategory(category, results.Values.ToList());
            }
        }

        private void CategoryBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (CategoryBox.SelectedIndex == 0)
                {
                    DeleteOption.Enabled = false;
                }
                else
                {
                    DeleteOption.Enabled = true;
                }
                CategoryMenu.Show(CategoryBox, e.Location);
            }
        }

        private void NewCategoryOption_Click(object sender, EventArgs e)
        {
            NewCategoryForm newCategoryForm = new NewCategoryForm();
            newCategoryForm.ShowDialog();
        }

        private void DeleteOption_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Are you sure you want delete category '{CategoryBox.SelectedItem.Text}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                CategoryBox.Items.Remove(CategoryBox.SelectedItem);
                Program.session.settings.Categories.Remove(CategoryBox.SelectedItem.Text.Split(" ")[0]);
                UserSettings.WriteToFile(Program.session.settings);
            }
        }

        private void InitializeEventHandlers()
        {
            NameTextBox.TextChanged += ValidateFields;
            SurnameTextBox.TextChanged += ValidateFields;
            UsernameTextBox.TextChanged += ValidateFields;
            EmailTextBox.TextChanged += ValidateFields;
            PasswordTextBox.TextChanged += ValidateFields;
            ConfirmPasswordTextBox.TextChanged += ValidateFields;
        }

        private void ValidateFields(object sender, EventArgs e)
        {
            Validator validator = new Validator();
            Authenticator auth = new Authenticator();

            bool isValid = validator.IsNameValid(NameTextBox.Text) &&
                           validator.IsNameValid(SurnameTextBox.Text) &&
                           validator.IsUsernameValid(UsernameTextBox.Text) &&
                           !auth.IsUserExist(UsernameTextBox.Text) &&
                           validator.IsEmailValid(EmailTextBox.Text) &&
                           validator.IsPasswordValid(PasswordTextBox.Text) &&
                           validator.IsPasswordValid(ConfirmPasswordTextBox.Text) &&
                           validator.IsPasswordConfirmed(PasswordTextBox.Text, ConfirmPasswordTextBox.Text);

            RegisterButton.Enabled = isValid;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            Validator validator = new Validator();

            string name = NameTextBox.Text;

            if (!string.IsNullOrWhiteSpace(name))
            {
                if (!validator.IsNameValid(name))
                {
                    NameTextBox.ErrorMessage = "Invalid name format!";
                    NameTextBox.SetErrorState(true);
                }
                else
                {
                    NameTextBox.SetErrorState(false);
                }
            }
            else { NameTextBox.SetErrorState(false); }
        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            Validator validator = new Validator();

            string surname = SurnameTextBox.Text;

            if (!string.IsNullOrWhiteSpace(surname))
            {
                if (!validator.IsNameValid(surname))
                {
                    SurnameTextBox.ErrorMessage = "Invalid surname format!";
                    SurnameTextBox.SetErrorState(true);
                }
                else
                {
                    SurnameTextBox.SetErrorState(false);
                }
            }
            else { SurnameTextBox.SetErrorState(false); }
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            Validator validator = new Validator();

            string username = UsernameTextBox.Text;


            if (!string.IsNullOrWhiteSpace(username))
            {
                if (!validator.IsUsernameValid(username))
                {
                    UsernameTextBox.ErrorMessage = "Invalid username format!";
                    UsernameTextBox.SetErrorState(true);
                }
                else
                {
                    Authenticator auth = new Authenticator();
                    if (auth.IsUserExist(username) && !username.Equals(Program.session.currentUser.Username))
                    {
                        UsernameTextBox.ErrorMessage = "Username already exist.";
                        UsernameTextBox.SetErrorState(true);
                    }
                    else
                    {
                        UsernameTextBox.SetErrorState(false);
                    }
                }
            }
            else { UsernameTextBox.SetErrorState(false); }
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            Validator validator = new Validator();

            string email = EmailTextBox.Text;

            if (!string.IsNullOrWhiteSpace(email))
            {
                if (!validator.IsEmailValid(email))
                {
                    EmailTextBox.ErrorMessage = "Invalid email format!";
                    EmailTextBox.SetErrorState(true);
                }
                else
                {
                    EmailTextBox.SetErrorState(false);
                }
            }
            else { EmailTextBox.SetErrorState(false); }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            Validator validator = new Validator();

            string password = PasswordTextBox.Text;

            if (!string.IsNullOrWhiteSpace(password))
            {
                if (!validator.IsPasswordValid(password))
                {
                    PasswordTextBox.ErrorMessage = "Invalid password format!";
                    PasswordTextBox.SetErrorState(true);
                    ConfirmPasswordTextBox.Enabled = false;
                }
                else
                {
                    ConfirmPasswordTextBox.Enabled = true;
                    PasswordTextBox.SetErrorState(false);
                }
            }
            else
            {
                PasswordTextBox.SetErrorState(false);
                ConfirmPasswordTextBox.Enabled = false;
            }
        }

        private void ConfirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            Validator validator = new Validator();

            string password = PasswordTextBox.Text;
            string confirmPassword = ConfirmPasswordTextBox.Text;

            if (!string.IsNullOrWhiteSpace(confirmPassword))
            {
                if (!validator.IsPasswordValid(confirmPassword))
                {
                    ConfirmPasswordTextBox.ErrorMessage = "Invalid password format!";
                    ConfirmPasswordTextBox.SetErrorState(true);
                }
                else
                {
                    if (!validator.IsPasswordConfirmed(password, confirmPassword))
                    {
                        ConfirmPasswordTextBox.ErrorMessage = "Passwords doesn't match!";
                        ConfirmPasswordTextBox.SetErrorState(true);
                    }
                    else
                    {
                        ConfirmPasswordTextBox.SetErrorState(false);
                    }
                }
            }
            else { ConfirmPasswordTextBox.SetErrorState(false); }
        }

        private void ConfirmPasswordTextBox_TrailingIconClick(object sender, EventArgs e)
        {
            if (ConfirmPasswordTextBox.UseSystemPasswordChar && ConfirmPasswordTextBox.UseSystemPasswordChar)
            {
                ConfirmPasswordTextBox.UseSystemPasswordChar = false;
                PasswordTextBox.UseSystemPasswordChar = false;
                ConfirmPasswordTextBox.PasswordChar = '\0';
                PasswordTextBox.PasswordChar = '\0';
                ConfirmPasswordTextBox.TrailingIcon = Properties.Resources.pass_show;
            }
            else
            {
                ConfirmPasswordTextBox.UseSystemPasswordChar = true;
                PasswordTextBox.UseSystemPasswordChar = true;
                ConfirmPasswordTextBox.TrailingIcon = Properties.Resources.pass_hide;
            }
        }

        private void ShareUsersBox_TextChanged(object sender, EventArgs e)
        {
            string[] users;

            users = ShareUsersBox.Text.Split(',');
            if (users.Length == 0)
            {
                users[0] = ShareUsersBox.Text;
            }

            Validator validator = new Validator();

            foreach (string username in users)
            {
                if (!string.IsNullOrWhiteSpace(username))
                {
                    if (!validator.IsUsernameValid(username))
                    {
                        ShareUsersBox.ErrorMessage = $"Invalid username '{username}' format!";
                        ShareUsersBox.SetErrorState(true);
                        ShareButton.Enabled = false;
                        break;
                    }
                    else
                    {
                        Authenticator auth = new Authenticator();
                        int taskId = (int)TasksIdComboBox.Items[TasksComboBox.SelectedIndex];
                        if (!auth.IsUserExist(username))
                        {
                            ShareUsersBox.ErrorMessage = $"Username '{username}' doesn't exist.";
                            ShareUsersBox.SetErrorState(true);
                            ShareButton.Enabled = false;
                            break;
                        }
                        else if (auth.IsUserExist(username) && username.Equals(Program.session.currentUser.Username))
                        {
                            ShareUsersBox.ErrorMessage = "You can't share with yourself.";
                            ShareUsersBox.SetErrorState(true);
                            ShareButton.Enabled = false;
                            break;
                        }
                        else if (Sharing.IsShared(taskId, Authenticator.GetUserIdByUsername(username)))
                        {
                            ShareUsersBox.ErrorMessage = $"You already shared this task with user '{username}'.";
                            ShareUsersBox.SetErrorState(true);
                            ShareButton.Enabled = false;
                        }
                        else
                        {
                            ShareUsersBox.SetErrorState(false);
                            ShareButton.Enabled = true;
                        }
                    }
                }
                else
                {
                    ShareUsersBox.SetErrorState(false);
                    ShareButton.Enabled = false;
                }
            }
        }

        private void ShareButton_Click(object sender, EventArgs e)
        {
            string[] users = ShareUsersBox.Text.Split(',');

            int taskId = (int)TasksIdComboBox.Items[TasksComboBox.SelectedIndex];

            int sharingId = Sharing.ShareTask(taskId, users);

            string usersString = "";

            foreach (string user in users)
            {
                SharingsTable.Rows.Add(sharingId, taskId, TasksComboBox.SelectedItem, $"{Program.session.currentUser.Username} (You)", user);
            }

            NoSharingsLabel.Visible = false;
            SharingsTable.Visible = true;
        }

        private void LoadSharings()
        {
            List<Sharing> sharingByCurrUserList = new List<Sharing>();
            List<Sharing> sharingWithCurrUserList = new List<Sharing>();

            sharingByCurrUserList = Sharing.GetSharingsByCurrentUser();
            sharingWithCurrUserList = Sharing.GetSharingsWithCurrentUser();

            var result = sharingByCurrUserList.GroupBy(sharing => sharing.TaskId).ToList();

            if (sharingByCurrUserList.Count > 0 || sharingWithCurrUserList.Count > 0)
            {
                NoSharingsLabel.Visible = false;
                SharingsTable.Visible = true;


                foreach (Sharing s in sharingByCurrUserList)
                {
                    Task task = Task.GetTaskById(s.TaskId);
                    SharingsTable.Rows.Add(s.Id, s.TaskId, task.Title, $"{Program.session.currentUser.Username} (You)", Authenticator.GetUsernameByUserId(s.ShareWithUserId));
                }

                foreach (Sharing s in sharingWithCurrUserList)
                {
                    Task task = Task.GetTaskById(s.TaskId);
                    SharingsTable.Rows.Add(s.Id, s.TaskId, task.Title, $"{Authenticator.GetUsernameByUserId(s.OwnUserId)}", Authenticator.GetUsernameByUserId(s.ShareWithUserId));
                }
            }
            else
            {
                NoSharingsLabel.Visible = true;
                SharingsTable.Visible = false;
            }
        }

        private void ChangeTaskState(bool state)
        {
            taskForm.IdBox.Enabled = state;
            taskForm.TaskTitleBox.Enabled = state;
            taskForm.TaskDescriptionBox.Enabled = state;
            taskForm.DeadlinePicker.Enabled = state;
            taskForm.StatusBox.Enabled = state;
            taskForm.CategoryBox.Enabled = state;
            taskForm.PriorityBox.Enabled = state;
            taskForm.AddTaskButton.Visible = state;
        }
        private void SharingsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == SharingsTable.Columns["MoreCol"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = SharingsTable.Rows[e.RowIndex];
                int Id = (int)selectedRow.Cells["TaskIdCol"].Value;
                string sharedBy = (string)selectedRow.Cells["SharedByCol"].Value;

                Task task = Task.GetTaskById(Id);

                taskForm = new TaskForm();

                taskForm.IdBox.Text = task.Id.ToString();
                taskForm.TaskTitleBox.Text = task.Title;
                taskForm.TaskDescriptionBox.Text = task.Description;
                taskForm.DeadlinePicker.Value = task.Deadline;
                taskForm.StatusBox.SelectedItem = task.Status;
                taskForm.CategoryBox.SelectedItem = task.Category;
                taskForm.PriorityBox.SelectedItem = task.Priority;

                if (sharedBy.Split(' ')[0] == Program.session.currentUser.Username)
                {
                    ChangeTaskState(true);
                }
                else
                {
                    ChangeTaskState(false);
                }

                taskForm.OpenInfoTaskForm();
            }
            else if (e.ColumnIndex == SharingsTable.Columns["DelSharingCol"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    DataGridViewRow selectedRow = SharingsTable.Rows[e.RowIndex];
                    int Id = (int)selectedRow.Cells["SharingIdCol"].Value;
                    SharingsTable.Rows.RemoveAt(e.RowIndex);

                    if (SharingsTable.Rows.Count == 0)
                    {
                        SharingsTable.Visible = false;
                        NoSharingsLabel.Visible = true;
                    }

                    Sharing.DeleteSharing(Id);

                    return;
                }
                else
                {
                    return;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void RedThemeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RedThemeRadioButton.Checked)
            {
                Program.session.settings.theme = UserSettings.ThemeName.red;
                LoadTheme();
                this.Refresh();
            }
        }

        private void GreenThemeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GreenThemeRadioButton.Checked)
            {
                Program.session.settings.theme = UserSettings.ThemeName.green;
                LoadTheme();
                this.Refresh();
            }
        }

        private void BlueThemeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (BlueThemeRadioButton.Checked)
            {
                Program.session.settings.theme = UserSettings.ThemeName.blue;
                LoadTheme();
                this.Refresh();
            }
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            UserSettings.WriteToFile(Program.session.settings);
        }

        private void MessageTimer_Tick(object sender, EventArgs e)
        {
            tasks = Task.GetCurrentUserTasks();

            foreach (Task task in tasks)
            {
                TimeSpan timeUntilDeadline = task.Deadline - DateTime.Now;

                if (Math.Round(timeUntilDeadline.TotalDays) == 7 && timeUntilDeadline.TotalDays > 0
                    && !IsReminderSended.ContainsKey(task.Id))
                {
                    Notification.Show($"Deadline for '{task.Title}' is approaching!");
                    IsReminderSended[task.Id] = true;
                }
            }
        }

        private void DeleteAccountButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                IsDeletingAccount = true;
                Properties.Settings.Default.CurrentUserUsername = string.Empty;
                Properties.Settings.Default.Save();
                Authenticator.DeleteAccount();
                this.Close();
            }
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            ImportTasksDialog.ShowDialog();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ExportTasksDialog.ShowDialog();
        }

        private void ImportTasksDialog_FileOk(object sender, CancelEventArgs e)
        {
            DataTransferManager.ImportDataFromJson(ImportTasksDialog.FileName);
        }

        private void ExportTasksDialog_FileOk(object sender, CancelEventArgs e)
        {
            DataTransferManager.ExportDataToJson(ExportTasksDialog.FileName);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace TaskManagementApp.Forms
{
    public partial class TaskForm : MaterialForm
    {
        public TaskForm()
        {
            InitializeComponent();
            InitializeEventHandlers();
            AddCategories();
            CategoryBox.SelectedIndex = 0;
            PriorityBox.SelectedIndex = 0;
        }

        private void InitializeEventHandlers()
        {
            TaskTitleBox.TextChanged += ValidateFields;
            TaskDescriptionBox.TextChanged += ValidateFields;
        }

        private void ValidateFields(object sender, EventArgs e)
        {
            bool isValid = (Task.IsTitleValid(TaskTitleBox.Text) &&
                            Task.IsDescriptionValid(TaskDescriptionBox.Text));

            AddTaskButton.Enabled = isValid;
        }

        private void AddCategories()
        {
            foreach(String cat in Program.session.settings.Categories)
            {
                CategoryBox.Items.Add(cat);
            }
        }
        public void OpenNewTaskForm()
        {
            this.Text = "New";
            this.AddTaskButton.Text = "Add";
            this.AddTaskButton.Click += AddTaskButton_Click;
            DeadlinePicker.MinDate = DateTime.Now;
            this.ShowDialog();
        }

        public void OpenEditTaskForm()
        {

            this.Text = "Edit";
            NewTaskLabel.Text = "Edit task";
            this.AddTaskButton.Text = "Save";
            this.AddTaskButton.Click += EditTaskButton_Click;


            this.ShowDialog();
        }

        public void OpenInfoTaskForm()
        {

            this.Text = "Info";
            NewTaskLabel.Text = "About task";
            this.AddTaskButton.Text = "Save";
            this.AddTaskButton.Click += EditTaskButton_Click;


            this.ShowDialog();
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            Task newTask = new Task(TaskTitleBox.Text, TaskDescriptionBox.Text, DeadlinePicker.Value, 
                (string)StatusBox.SelectedItem, (string)CategoryBox.SelectedItem, PriorityBox.SelectedIndex + 1);

            if (Task.AddTask(newTask))
            {
                Program.session.dashboard.NoTasksLabel.Visible = false;
                Program.session.dashboard.TasksList.Visible = true;
                Program.session.dashboard.TasksList.Rows.Add(newTask.Id.ToString(), newTask.Title,
                    newTask.Description, newTask.Deadline.ToString("yyyy-MM-dd HH:mm"), newTask.Status, newTask.Category, newTask.Priority.ToString());
                Program.session.dashboard.TasksList.Sort(Program.session.dashboard.TasksList.Columns["Priority"], ListSortDirection.Descending);
            }
            Program.session.dashboard.LoadCategories();

            this.Close();

        }

        private void EditTaskButton_Click(object sender, EventArgs e)
        {
            Task editedTask = new Task(int.Parse(IdBox.Text), TaskTitleBox.Text, TaskDescriptionBox.Text, DeadlinePicker.Value, 
                (string)StatusBox.SelectedItem, (string)CategoryBox.SelectedItem, PriorityBox.SelectedIndex + 1);
           

            Task.UpdateTask(editedTask);
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TaskDescriptionBox_TextChanged(object sender, EventArgs e)
        {
            int maxLength = 1000;

            int currentLength = TaskDescriptionBox.Text.Length;

            DescriptionWordsCount.Text = $"{currentLength}/{maxLength}";
        }

        private void TaskTitleBox_TextChanged(object sender, EventArgs e)
        {
            int maxLength = 60;

            int currentLength = TaskTitleBox.Text.Length;

            TitleWordsCount.Text = $"{currentLength}/{maxLength}";
        }

        private void TaskDescriptionBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int maxLength = 1000;

            if (!(e.KeyChar == '\b') && TaskDescriptionBox.Text.Length >= maxLength)
            {
                e.Handled = true;
            }
        }

        private void TaskTitleBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int maxLength = 60;

            if (!(e.KeyChar == '\b') && TaskTitleBox.Text.Length >= maxLength)
            {
                e.Handled = true;
            }
        }
    }
}

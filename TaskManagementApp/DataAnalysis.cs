using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace TaskManagementApp
{
    public class DataAnalysis
    {
        private List<Task> tasks;

        public DataAnalysis()
        {
            tasks = Task.GetCurrentUserTasks();
        }
        public TimeSpan AverageTaskDuration()
        {
            TimeSpan sum = TimeSpan.Zero;
            foreach (Task task in tasks)
            {
                TimeSpan timeUntilDeadline = task.Deadline - task.CreatedAt;
                sum += timeUntilDeadline;
            }

            if (tasks.Count > 0)
            {
                TimeSpan average = sum / tasks.Count;
                return average;
            }

            return TimeSpan.Zero;
        }

        public int DeadlinesCountInCurrentMonth()
        {
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;

            var deadlinesInCurrentMonth = tasks.Where(t =>
                t.Deadline.Year == currentYear && t.Deadline.Month == currentMonth);

            int numberOfDeadlines = deadlinesInCurrentMonth.Count();

            return numberOfDeadlines;
        }

        public double PercentageCompletedTasks()
        {
            if (tasks.Count == 0)
                return 0;

            int completedTasksCount = tasks.Count(t => t.Status.Equals("Completed"));
            return (double)completedTasksCount / tasks.Count * 100;
        }
    }
}

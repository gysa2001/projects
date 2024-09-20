using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp.Notifications;
using Windows.UI.Notifications;

namespace TaskManagementApp
{
    public class Notification
    {
        public static void Show(string message)
        {
            // Create the content for the toast notification
            new ToastContentBuilder()
                .AddText("Reminder")
                .AddText(message)
                .Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TaskManagementApp
{
    internal class Validator
    {
        public bool IsEmailValid(string email)
        {
            return  Regex.IsMatch(email, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$") && email.Length <= 320;
        }

        public bool IsNameValid(string name)
        {
            return Regex.IsMatch(name, @"^[a-zA-Z]+$") && name.Length <= 20;
        }

        public bool IsUsernameValid(string username)
        {
            return Regex.IsMatch(username, @"^[a-zA-Z0-9]+$") && username.Length <= 20;
        }

        public bool IsPasswordValid(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$") && password.Length >= 8 && password.Length <= 25;
        }

        public bool IsPasswordConfirmed(string password, string confirmPassword)
        {
            return confirmPassword == password;
        }
    }
}

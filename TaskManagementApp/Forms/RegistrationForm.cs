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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TaskManagementApp
{
    public partial class RegistrationForm : MaterialForm
    {
        public RegistrationForm()
        {
            InitializeComponent();
            InitializeEventHandlers();
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
                    if (auth.IsUserExist(username))
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

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            User newUser = new User(NameTextBox.Text, SurnameTextBox.Text, UsernameTextBox.Text, EmailTextBox.Text, PasswordTextBox.Text);
            Authenticator auth = new Authenticator();

            if (auth.AddUser(newUser))
            {
                DialogResult result = MessageBox.Show("Account created successfully!\nNow you can login.", "Success", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    this.Close();
                    Program.LoginForm.Show();
                }
            }

            NameTextBox.Text = "";
            SurnameTextBox.Text = "";
            UsernameTextBox.Text = "";
            EmailTextBox.Text = "";
            PasswordTextBox.Text = "";
            ConfirmPasswordTextBox.Text = "";
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.LoginForm.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.LoginForm.Show();
            Close();
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int maxLength = 20;

            if (!(e.KeyChar == '\b') && NameTextBox.Text.Length >= maxLength)
            {
                e.Handled = true;
            }
        }

        private void SurnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int maxLength = 20;

            if (!(e.KeyChar == '\b') && SurnameTextBox.Text.Length >= maxLength)
            {
                e.Handled = true;
            }
        }

        private void UsernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int maxLength = 20;

            if (!(e.KeyChar == '\b') && UsernameTextBox.Text.Length >= maxLength)
            {
                e.Handled = true;
            }
        }

        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int maxLength = 30;

            if (!(e.KeyChar == '\b') && EmailTextBox.Text.Length >= maxLength)
            {
                e.Handled = true;
            }
        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int maxLength = 25;

            if (!(e.KeyChar == '\b') && PasswordTextBox.Text.Length >= maxLength)
            {
                e.Handled = true;
            }
        }

        private void ConfirmPasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int maxLength = 25;

            if (!(e.KeyChar == '\b') && ConfirmPasswordTextBox.Text.Length >= maxLength)
            {
                e.Handled = true;
            }
        }
    }
}

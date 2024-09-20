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
using ReaLTaiizor.Manager;
using TaskManagementApp.Forms;
using TaskManagementApp.Properties;

namespace TaskManagementApp
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            UsernameTextBox.TextChanged += ValidateFields;
            PasswordTextBox.TextChanged += ValidateFields;
        }

        private void ValidateFields(object sender, EventArgs e)
        {
            Validator validator = new Validator();
            bool isValid = validator.IsUsernameValid(UsernameTextBox.Text) &&
                           validator.IsPasswordValid(PasswordTextBox.Text);

            LoginButton.Enabled = isValid;
        }

        private void ClearFields()
        {
            UsernameTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
            ErrorLabel.Visible = false;
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
                    UsernameTextBox.SetErrorState(false);
                }
            }
            else { UsernameTextBox.SetErrorState(false); }
        }

        private void linkLabelEdit1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClearFields();

            RegistrationForm form = new RegistrationForm();
            form.ShowDialog();
        }

        private void PasswordTextBox_TrailingIconClick(object sender, EventArgs e)
        {
            if (PasswordTextBox.UseSystemPasswordChar)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
                PasswordTextBox.PasswordChar = '\0';
                PasswordTextBox.TrailingIcon = Properties.Resources.pass_show;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
                PasswordTextBox.TrailingIcon = Properties.Resources.pass_hide;
            }

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
                }
                else
                {
                    PasswordTextBox.SetErrorState(false);
                }
            }
            else { PasswordTextBox.SetErrorState(false); }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Authenticator auth = new Authenticator();

            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            if (!auth.IsUserExist(username))
            {
                ErrorLabel.Text = "User doesn't exist or incorrect credentials!";
                ErrorLabel.Visible = true;
            }
            else
            {
                if (!auth.IsPasswordCorrect(username, password))
                {
                    ErrorLabel.Text = "User doesn't exist or incorrect credentials!";
                    ErrorLabel.Visible = true;
                }
                else
                {
                    ClearFields();
                    Hide();

                    Authenticator.Login(username);
                }
            }
        }

        private void CalcelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResetPasswordLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClearFields();

            ResetPasswordForm form = new ResetPasswordForm();
            form.ShowDialog();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatabaseConnection.CloseConnection();
        }
    }
}

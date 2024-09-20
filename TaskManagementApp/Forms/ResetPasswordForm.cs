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
    public partial class ResetPasswordForm : MaterialForm
    {
        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private void ResetPasswordButton_Click(object sender, EventArgs e)
        {
            try
            {
                User user = Authenticator.GetUserByUsername(UsernameTextBox.Text);

                Authenticator auth = new Authenticator();

                string randowmPassword = auth.GenerateRandomPassword();

                auth.UpdatePassword(user.Username, randowmPassword);

                string recipient = user.Email;

                EmailService emailService = new EmailService();
                emailService.SendPasswordResetEmail(recipient, randowmPassword);

                MessageBox.Show("Password resetted successfully!\nNow you can login.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error resetting password: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetPasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.LoginForm.Show();
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
                    ResetPasswordButton.Enabled = false;
                }
                else
                {
                    Authenticator auth = new Authenticator();
                    if (!auth.IsUserExist(username))
                    {
                        UsernameTextBox.ErrorMessage = "User with this username doesn't exist.";
                        UsernameTextBox.SetErrorState(true);
                        ResetPasswordButton.Enabled = false;
                    }
                    else
                    {
                        UsernameTextBox.SetErrorState(false);
                        ResetPasswordButton.Enabled = true;
                    }
                }
            }
            else { UsernameTextBox.SetErrorState(false); }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

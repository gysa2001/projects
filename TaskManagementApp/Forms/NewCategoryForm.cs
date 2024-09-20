using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Forms;

namespace TaskManagementApp.Forms
{
    public partial class NewCategoryForm : MaterialForm
    {
        public NewCategoryForm()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            CategoryTextBox.TextChanged += ValidateField;
        }

        private void ValidateField(object sender, EventArgs e)
        {
            bool IsValid = !string.IsNullOrWhiteSpace(CategoryTextBox.Text);
            NewCategoryButton.Enabled = IsValid;
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NewCategoryButton_Click(object sender, EventArgs e)
        {
            Program.session.dashboard.CategoryBox.Items.Add(
                new ReaLTaiizor.Child.Material.MaterialListBoxItem(CategoryTextBox.Text));
            Program.session.settings.Categories.Add(CategoryTextBox.Text);
            UserSettings.WriteToFile(Program.session.settings);
            Close();
        }

        private void CategoryTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}

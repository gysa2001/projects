namespace TaskManagementApp
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            NameTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            SurnameTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            UsernameTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            EmailTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            PasswordTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            ConfirmPasswordTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            RegisterButton = new ReaLTaiizor.Controls.MaterialButton();
            CancelButton = new ReaLTaiizor.Controls.MaterialButton();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            aloneNotice1 = new ReaLTaiizor.Controls.AloneNotice();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.AnimateReadOnly = false;
            NameTextBox.AutoCompleteMode = AutoCompleteMode.None;
            NameTextBox.AutoCompleteSource = AutoCompleteSource.None;
            NameTextBox.BackgroundImageLayout = ImageLayout.None;
            NameTextBox.CharacterCasing = CharacterCasing.Normal;
            NameTextBox.Depth = 0;
            NameTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            NameTextBox.HideSelection = true;
            NameTextBox.Hint = "Name";
            NameTextBox.LeadingIcon = null;
            NameTextBox.Location = new Point(147, 218);
            NameTextBox.MaxLength = 32767;
            NameTextBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PasswordChar = '\0';
            NameTextBox.PrefixSuffixText = null;
            NameTextBox.ReadOnly = false;
            NameTextBox.RightToLeft = RightToLeft.No;
            NameTextBox.SelectedText = "";
            NameTextBox.SelectionLength = 0;
            NameTextBox.SelectionStart = 0;
            NameTextBox.ShortcutsEnabled = true;
            NameTextBox.ShowAssistiveText = true;
            NameTextBox.Size = new Size(312, 64);
            NameTextBox.TabIndex = 0;
            NameTextBox.TabStop = false;
            NameTextBox.TextAlign = HorizontalAlignment.Left;
            NameTextBox.TrailingIcon = null;
            NameTextBox.UseAccent = false;
            NameTextBox.UseSystemPasswordChar = false;
            NameTextBox.KeyPress += NameTextBox_KeyPress;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.AnimateReadOnly = false;
            SurnameTextBox.AutoCompleteMode = AutoCompleteMode.None;
            SurnameTextBox.AutoCompleteSource = AutoCompleteSource.None;
            SurnameTextBox.BackgroundImageLayout = ImageLayout.None;
            SurnameTextBox.CharacterCasing = CharacterCasing.Normal;
            SurnameTextBox.Depth = 0;
            SurnameTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            SurnameTextBox.HideSelection = true;
            SurnameTextBox.Hint = "Surname";
            SurnameTextBox.LeadingIcon = null;
            SurnameTextBox.Location = new Point(476, 218);
            SurnameTextBox.MaxLength = 32767;
            SurnameTextBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.PasswordChar = '\0';
            SurnameTextBox.PrefixSuffixText = null;
            SurnameTextBox.ReadOnly = false;
            SurnameTextBox.RightToLeft = RightToLeft.No;
            SurnameTextBox.SelectedText = "";
            SurnameTextBox.SelectionLength = 0;
            SurnameTextBox.SelectionStart = 0;
            SurnameTextBox.ShortcutsEnabled = true;
            SurnameTextBox.ShowAssistiveText = true;
            SurnameTextBox.Size = new Size(312, 64);
            SurnameTextBox.TabIndex = 1;
            SurnameTextBox.TabStop = false;
            SurnameTextBox.TextAlign = HorizontalAlignment.Left;
            SurnameTextBox.TrailingIcon = null;
            SurnameTextBox.UseAccent = false;
            SurnameTextBox.UseSystemPasswordChar = false;
            SurnameTextBox.KeyPress += SurnameTextBox_KeyPress;
            SurnameTextBox.TextChanged += SurnameTextBox_TextChanged;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.AnimateReadOnly = false;
            UsernameTextBox.AutoCompleteMode = AutoCompleteMode.None;
            UsernameTextBox.AutoCompleteSource = AutoCompleteSource.None;
            UsernameTextBox.BackgroundImageLayout = ImageLayout.None;
            UsernameTextBox.CharacterCasing = CharacterCasing.Normal;
            UsernameTextBox.Depth = 0;
            UsernameTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            UsernameTextBox.HideSelection = true;
            UsernameTextBox.Hint = "Username";
            UsernameTextBox.LeadingIcon = null;
            UsernameTextBox.Location = new Point(147, 288);
            UsernameTextBox.MaxLength = 32767;
            UsernameTextBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.PasswordChar = '\0';
            UsernameTextBox.PrefixSuffixText = null;
            UsernameTextBox.ReadOnly = false;
            UsernameTextBox.RightToLeft = RightToLeft.No;
            UsernameTextBox.SelectedText = "";
            UsernameTextBox.SelectionLength = 0;
            UsernameTextBox.SelectionStart = 0;
            UsernameTextBox.ShortcutsEnabled = true;
            UsernameTextBox.ShowAssistiveText = true;
            UsernameTextBox.Size = new Size(312, 64);
            UsernameTextBox.TabIndex = 2;
            UsernameTextBox.TabStop = false;
            UsernameTextBox.TextAlign = HorizontalAlignment.Left;
            UsernameTextBox.TrailingIcon = null;
            UsernameTextBox.UseAccent = false;
            UsernameTextBox.UseSystemPasswordChar = false;
            UsernameTextBox.KeyPress += UsernameTextBox_KeyPress;
            UsernameTextBox.TextChanged += UsernameTextBox_TextChanged;
            // 
            // EmailTextBox
            // 
            EmailTextBox.AnimateReadOnly = false;
            EmailTextBox.AutoCompleteMode = AutoCompleteMode.None;
            EmailTextBox.AutoCompleteSource = AutoCompleteSource.None;
            EmailTextBox.BackgroundImageLayout = ImageLayout.None;
            EmailTextBox.CharacterCasing = CharacterCasing.Normal;
            EmailTextBox.Depth = 0;
            EmailTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            EmailTextBox.HideSelection = true;
            EmailTextBox.Hint = "Email";
            EmailTextBox.LeadingIcon = null;
            EmailTextBox.Location = new Point(476, 288);
            EmailTextBox.MaxLength = 32767;
            EmailTextBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.PasswordChar = '\0';
            EmailTextBox.PrefixSuffixText = null;
            EmailTextBox.ReadOnly = false;
            EmailTextBox.RightToLeft = RightToLeft.No;
            EmailTextBox.SelectedText = "";
            EmailTextBox.SelectionLength = 0;
            EmailTextBox.SelectionStart = 0;
            EmailTextBox.ShortcutsEnabled = true;
            EmailTextBox.ShowAssistiveText = true;
            EmailTextBox.Size = new Size(312, 64);
            EmailTextBox.TabIndex = 3;
            EmailTextBox.TabStop = false;
            EmailTextBox.TextAlign = HorizontalAlignment.Left;
            EmailTextBox.TrailingIcon = null;
            EmailTextBox.UseAccent = false;
            EmailTextBox.UseSystemPasswordChar = false;
            EmailTextBox.KeyPress += EmailTextBox_KeyPress;
            EmailTextBox.TextChanged += EmailTextBox_TextChanged;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.AnimateReadOnly = false;
            PasswordTextBox.AutoCompleteMode = AutoCompleteMode.None;
            PasswordTextBox.AutoCompleteSource = AutoCompleteSource.None;
            PasswordTextBox.BackgroundImageLayout = ImageLayout.None;
            PasswordTextBox.CharacterCasing = CharacterCasing.Normal;
            PasswordTextBox.Depth = 0;
            PasswordTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            PasswordTextBox.HideSelection = true;
            PasswordTextBox.Hint = "Password";
            PasswordTextBox.LeadingIcon = null;
            PasswordTextBox.Location = new Point(147, 358);
            PasswordTextBox.MaxLength = 32767;
            PasswordTextBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '●';
            PasswordTextBox.PrefixSuffixText = null;
            PasswordTextBox.ReadOnly = false;
            PasswordTextBox.RightToLeft = RightToLeft.No;
            PasswordTextBox.SelectedText = "";
            PasswordTextBox.SelectionLength = 0;
            PasswordTextBox.SelectionStart = 0;
            PasswordTextBox.ShortcutsEnabled = true;
            PasswordTextBox.ShowAssistiveText = true;
            PasswordTextBox.Size = new Size(312, 64);
            PasswordTextBox.TabIndex = 4;
            PasswordTextBox.TabStop = false;
            PasswordTextBox.TextAlign = HorizontalAlignment.Left;
            PasswordTextBox.TrailingIcon = null;
            PasswordTextBox.UseAccent = false;
            PasswordTextBox.UseSystemPasswordChar = true;
            PasswordTextBox.KeyPress += PasswordTextBox_KeyPress;
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
            // 
            // ConfirmPasswordTextBox
            // 
            ConfirmPasswordTextBox.AnimateReadOnly = false;
            ConfirmPasswordTextBox.AutoCompleteMode = AutoCompleteMode.None;
            ConfirmPasswordTextBox.AutoCompleteSource = AutoCompleteSource.None;
            ConfirmPasswordTextBox.BackgroundImageLayout = ImageLayout.None;
            ConfirmPasswordTextBox.CharacterCasing = CharacterCasing.Normal;
            ConfirmPasswordTextBox.Depth = 0;
            ConfirmPasswordTextBox.Enabled = false;
            ConfirmPasswordTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ConfirmPasswordTextBox.HideSelection = true;
            ConfirmPasswordTextBox.Hint = "Confirm password";
            ConfirmPasswordTextBox.LeadingIcon = null;
            ConfirmPasswordTextBox.Location = new Point(476, 358);
            ConfirmPasswordTextBox.MaxLength = 32767;
            ConfirmPasswordTextBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            ConfirmPasswordTextBox.PasswordChar = '●';
            ConfirmPasswordTextBox.PrefixSuffixText = null;
            ConfirmPasswordTextBox.ReadOnly = false;
            ConfirmPasswordTextBox.RightToLeft = RightToLeft.No;
            ConfirmPasswordTextBox.SelectedText = "";
            ConfirmPasswordTextBox.SelectionLength = 0;
            ConfirmPasswordTextBox.SelectionStart = 0;
            ConfirmPasswordTextBox.ShortcutsEnabled = true;
            ConfirmPasswordTextBox.ShowAssistiveText = true;
            ConfirmPasswordTextBox.Size = new Size(312, 64);
            ConfirmPasswordTextBox.TabIndex = 5;
            ConfirmPasswordTextBox.TabStop = false;
            ConfirmPasswordTextBox.TextAlign = HorizontalAlignment.Left;
            ConfirmPasswordTextBox.TrailingIcon = Properties.Resources.pass_hide;
            ConfirmPasswordTextBox.UseAccent = false;
            ConfirmPasswordTextBox.UseSystemPasswordChar = true;
            ConfirmPasswordTextBox.TrailingIconClick += ConfirmPasswordTextBox_TrailingIconClick;
            ConfirmPasswordTextBox.KeyPress += ConfirmPasswordTextBox_KeyPress;
            ConfirmPasswordTextBox.TextChanged += ConfirmPasswordTextBox_TextChanged;
            // 
            // RegisterButton
            // 
            RegisterButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RegisterButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            RegisterButton.Depth = 0;
            RegisterButton.Enabled = false;
            RegisterButton.HighEmphasis = true;
            RegisterButton.Icon = null;
            RegisterButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            RegisterButton.Location = new Point(147, 563);
            RegisterButton.Margin = new Padding(4, 6, 4, 6);
            RegisterButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            RegisterButton.Name = "RegisterButton";
            RegisterButton.NoAccentTextColor = Color.Empty;
            RegisterButton.Size = new Size(147, 36);
            RegisterButton.TabIndex = 6;
            RegisterButton.Text = "create account";
            RegisterButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            RegisterButton.UseAccentColor = false;
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CancelButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            CancelButton.Depth = 0;
            CancelButton.HighEmphasis = true;
            CancelButton.Icon = null;
            CancelButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            CancelButton.Location = new Point(302, 563);
            CancelButton.Margin = new Padding(4, 6, 4, 6);
            CancelButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            CancelButton.Name = "CancelButton";
            CancelButton.NoAccentTextColor = Color.Empty;
            CancelButton.Size = new Size(77, 36);
            CancelButton.TabIndex = 7;
            CancelButton.Text = "cancel";
            CancelButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            CancelButton.UseAccentColor = false;
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.BackColor = Color.Transparent;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H4;
            materialLabel1.HighEmphasis = true;
            materialLabel1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            materialLabel1.Location = new Point(319, 131);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(319, 63);
            materialLabel1.TabIndex = 8;
            materialLabel1.Text = "Account registration";
            // 
            // aloneNotice1
            // 
            aloneNotice1.BackColor = Color.FromArgb(255, 253, 232);
            aloneNotice1.BorderColor = Color.White;
            aloneNotice1.BorderStyle = BorderStyle.None;
            aloneNotice1.Enabled = false;
            aloneNotice1.ForeColor = Color.DarkGoldenrod;
            aloneNotice1.Location = new Point(147, 428);
            aloneNotice1.Multiline = true;
            aloneNotice1.Name = "aloneNotice1";
            aloneNotice1.ReadOnly = true;
            aloneNotice1.Size = new Size(312, 115);
            aloneNotice1.TabIndex = 9;
            aloneNotice1.Text = "Password must:\r\n1.  Have at least 8 characters length.\r\n2.  Have at least one digit.\r\n3.  Have at least one uppercase letter.\r\n4.  Have at least one special symbol.";
            // 
            // RegistrationForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(936, 630);
            Controls.Add(aloneNotice1);
            Controls.Add(materialLabel1);
            Controls.Add(CancelButton);
            Controls.Add(RegisterButton);
            Controls.Add(ConfirmPasswordTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(SurnameTextBox);
            Controls.Add(NameTextBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_64;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(936, 630);
            Name = "RegistrationForm";
            Padding = new Padding(3, 88, 3, 3);
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Management App";
            FormClosed += RegistrationForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit NameTextBox;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit SurnameTextBox;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit UsernameTextBox;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit EmailTextBox;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit PasswordTextBox;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit ConfirmPasswordTextBox;
        private ReaLTaiizor.Controls.MaterialButton RegisterButton;
        private ReaLTaiizor.Controls.MaterialButton CancelButton;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.AloneNotice aloneNotice1;
    }
}
namespace TaskManagementApp.Forms
{
    partial class ResetPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordForm));
            UsernameTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            ResetPasswordButton = new ReaLTaiizor.Controls.MaterialButton();
            CancelButton = new ReaLTaiizor.Controls.MaterialButton();
            SuspendLayout();
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
            UsernameTextBox.Location = new Point(140, 195);
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
            UsernameTextBox.TabIndex = 0;
            UsernameTextBox.TabStop = false;
            UsernameTextBox.TextAlign = HorizontalAlignment.Left;
            UsernameTextBox.TrailingIcon = null;
            UsernameTextBox.UseAccent = false;
            UsernameTextBox.UseSystemPasswordChar = false;
            UsernameTextBox.TextChanged += UsernameTextBox_TextChanged;
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(53, 98);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(484, 59);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Please enter the username for password resetting\r\nand we send new random password in your email";
            materialLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ResetPasswordButton
            // 
            ResetPasswordButton.AutoSize = false;
            ResetPasswordButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ResetPasswordButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ResetPasswordButton.Depth = 0;
            ResetPasswordButton.Enabled = false;
            ResetPasswordButton.HighEmphasis = true;
            ResetPasswordButton.Icon = null;
            ResetPasswordButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ResetPasswordButton.Location = new Point(140, 268);
            ResetPasswordButton.Margin = new Padding(4, 6, 4, 6);
            ResetPasswordButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ResetPasswordButton.Name = "ResetPasswordButton";
            ResetPasswordButton.NoAccentTextColor = Color.Empty;
            ResetPasswordButton.Size = new Size(148, 36);
            ResetPasswordButton.TabIndex = 3;
            ResetPasswordButton.Text = "Reset password";
            ResetPasswordButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ResetPasswordButton.UseAccentColor = false;
            ResetPasswordButton.UseVisualStyleBackColor = false;
            ResetPasswordButton.Click += ResetPasswordButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CancelButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            CancelButton.Depth = 0;
            CancelButton.HighEmphasis = true;
            CancelButton.Icon = null;
            CancelButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            CancelButton.Location = new Point(296, 268);
            CancelButton.Margin = new Padding(4, 6, 4, 6);
            CancelButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            CancelButton.Name = "CancelButton";
            CancelButton.NoAccentTextColor = Color.Empty;
            CancelButton.Size = new Size(77, 36);
            CancelButton.TabIndex = 8;
            CancelButton.Text = "cancel";
            CancelButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            CancelButton.UseAccentColor = false;
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // ResetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 371);
            Controls.Add(CancelButton);
            Controls.Add(ResetPasswordButton);
            Controls.Add(materialLabel1);
            Controls.Add(UsernameTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ResetPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Management App";
            FormClosed += ResetPasswordForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit UsernameTextBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialButton ResetPasswordButton;
        private ReaLTaiizor.Controls.MaterialButton CancelButton;
    }
}
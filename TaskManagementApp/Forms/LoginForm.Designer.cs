namespace TaskManagementApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            UsernameTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            PasswordTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            LoginButton = new ReaLTaiizor.Controls.MaterialButton();
            CalcelButton = new ReaLTaiizor.Controls.MaterialButton();
            linkLabelEdit1 = new ReaLTaiizor.Controls.LinkLabelEdit();
            ResetPasswordLink = new ReaLTaiizor.Controls.LinkLabelEdit();
            label1 = new Label();
            ErrorLabel = new ReaLTaiizor.Controls.LabelEdit();
            panel1 = new Panel();
            LoginPanel = new Panel();
            panel1.SuspendLayout();
            LoginPanel.SuspendLayout();
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
            UsernameTextBox.LeadingIcon = (Image)resources.GetObject("UsernameTextBox.LeadingIcon");
            UsernameTextBox.Location = new Point(79, 107);
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
            UsernameTextBox.ShortcutsEnabled = false;
            UsernameTextBox.ShowAssistiveText = true;
            UsernameTextBox.Size = new Size(310, 64);
            UsernameTextBox.TabIndex = 0;
            UsernameTextBox.TabStop = false;
            UsernameTextBox.TextAlign = HorizontalAlignment.Left;
            UsernameTextBox.TrailingIcon = null;
            UsernameTextBox.UseAccent = false;
            UsernameTextBox.UseSystemPasswordChar = false;
            UsernameTextBox.TextChanged += UsernameTextBox_TextChanged;
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
            PasswordTextBox.LeadingIcon = (Image)resources.GetObject("PasswordTextBox.LeadingIcon");
            PasswordTextBox.Location = new Point(79, 168);
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
            PasswordTextBox.Size = new Size(310, 64);
            PasswordTextBox.TabIndex = 1;
            PasswordTextBox.TabStop = false;
            PasswordTextBox.TextAlign = HorizontalAlignment.Left;
            PasswordTextBox.TrailingIcon = (Image)resources.GetObject("PasswordTextBox.TrailingIcon");
            PasswordTextBox.UseAccent = false;
            PasswordTextBox.UseSystemPasswordChar = true;
            PasswordTextBox.TrailingIconClick += PasswordTextBox_TrailingIconClick;
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LoginButton.AutoSize = false;
            LoginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoginButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            LoginButton.Depth = 0;
            LoginButton.Enabled = false;
            LoginButton.HighEmphasis = true;
            LoginButton.Icon = null;
            LoginButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            LoginButton.Location = new Point(79, 276);
            LoginButton.Margin = new Padding(4, 6, 4, 6);
            LoginButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            LoginButton.Name = "LoginButton";
            LoginButton.NoAccentTextColor = Color.Empty;
            LoginButton.Size = new Size(151, 36);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Log In";
            LoginButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            LoginButton.UseAccentColor = false;
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // CalcelButton
            // 
            CalcelButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CalcelButton.AutoSize = false;
            CalcelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CalcelButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            CalcelButton.Depth = 0;
            CalcelButton.HighEmphasis = true;
            CalcelButton.Icon = null;
            CalcelButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            CalcelButton.Location = new Point(237, 276);
            CalcelButton.Margin = new Padding(4, 6, 4, 6);
            CalcelButton.MaximumSize = new Size(152, 36);
            CalcelButton.MinimumSize = new Size(152, 36);
            CalcelButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            CalcelButton.Name = "CalcelButton";
            CalcelButton.NoAccentTextColor = Color.Empty;
            CalcelButton.Size = new Size(152, 36);
            CalcelButton.TabIndex = 5;
            CalcelButton.Text = "Cancel";
            CalcelButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            CalcelButton.UseAccentColor = false;
            CalcelButton.UseVisualStyleBackColor = true;
            CalcelButton.Click += CalcelButton_Click;
            // 
            // linkLabelEdit1
            // 
            linkLabelEdit1.ActiveLinkColor = Color.FromArgb(153, 34, 34);
            linkLabelEdit1.AutoSize = true;
            linkLabelEdit1.BackColor = Color.Transparent;
            linkLabelEdit1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelEdit1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabelEdit1.LinkColor = Color.FromArgb(32, 34, 37);
            linkLabelEdit1.Location = new Point(280, 235);
            linkLabelEdit1.Name = "linkLabelEdit1";
            linkLabelEdit1.Size = new Size(109, 18);
            linkLabelEdit1.TabIndex = 6;
            linkLabelEdit1.TabStop = true;
            linkLabelEdit1.Text = "Create account";
            linkLabelEdit1.VisitedLinkColor = Color.FromArgb(32, 34, 37);
            linkLabelEdit1.Click += linkLabelEdit1_Click;
            // 
            // ResetPasswordLink
            // 
            ResetPasswordLink.ActiveLinkColor = Color.FromArgb(153, 34, 34);
            ResetPasswordLink.AutoSize = true;
            ResetPasswordLink.BackColor = Color.Transparent;
            ResetPasswordLink.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ResetPasswordLink.LinkBehavior = LinkBehavior.NeverUnderline;
            ResetPasswordLink.LinkColor = Color.FromArgb(32, 34, 37);
            ResetPasswordLink.Location = new Point(79, 235);
            ResetPasswordLink.Name = "ResetPasswordLink";
            ResetPasswordLink.Size = new Size(129, 18);
            ResetPasswordLink.TabIndex = 7;
            ResetPasswordLink.TabStop = true;
            ResetPasswordLink.Text = "Forgot password?";
            ResetPasswordLink.VisitedLinkColor = Color.FromArgb(32, 34, 37);
            ResetPasswordLink.Click += ResetPasswordLink_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(122, 68);
            label1.Name = "label1";
            label1.Size = new Size(189, 19);
            label1.TabIndex = 8;
            label1.Text = "Welcome, please log in";
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.BackColor = Color.Transparent;
            ErrorLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Location = new Point(68, 30);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(71, 18);
            ErrorLabel.TabIndex = 9;
            ErrorLabel.Text = "labelEdit1";
            ErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            ErrorLabel.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(LoginPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(1380, 773);
            panel1.TabIndex = 10;
            // 
            // LoginPanel
            // 
            LoginPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LoginPanel.BackColor = Color.White;
            LoginPanel.BorderStyle = BorderStyle.FixedSingle;
            LoginPanel.Controls.Add(UsernameTextBox);
            LoginPanel.Controls.Add(linkLabelEdit1);
            LoginPanel.Controls.Add(ErrorLabel);
            LoginPanel.Controls.Add(ResetPasswordLink);
            LoginPanel.Controls.Add(PasswordTextBox);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Controls.Add(CalcelButton);
            LoginPanel.Controls.Add(LoginButton);
            LoginPanel.Location = new Point(449, 198);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(471, 348);
            LoginPanel.TabIndex = 10;
            // 
            // LoginForm
            // 
            AccessibleRole = AccessibleRole.Application;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1386, 840);
            Controls.Add(panel1);
            DrawerWidth = 0;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1386, 840);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimumSize = new Size(1386, 0);
            Name = "LoginForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Management App";
            FormClosed += LoginForm_FormClosed;
            panel1.ResumeLayout(false);
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit UsernameTextBox;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit PasswordTextBox;
        private ReaLTaiizor.Controls.MaterialButton LoginButton;
        private ReaLTaiizor.Controls.MaterialButton CalcelButton;
        private ReaLTaiizor.Controls.LinkLabelEdit linkLabelEdit1;
        private ReaLTaiizor.Controls.LinkLabelEdit ResetPasswordLink;
        private Label label1;
        private ReaLTaiizor.Controls.LabelEdit ErrorLabel;
        private Panel panel1;
        private Panel LoginPanel;
    }
}
namespace TaskManagementApp.Forms
{
    partial class NewCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCategoryForm));
            CategoryTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            CancelButton = new ReaLTaiizor.Controls.MaterialButton();
            NewCategoryButton = new ReaLTaiizor.Controls.MaterialButton();
            SuspendLayout();
            // 
            // CategoryTextBox
            // 
            CategoryTextBox.AnimateReadOnly = false;
            CategoryTextBox.AutoCompleteMode = AutoCompleteMode.None;
            CategoryTextBox.AutoCompleteSource = AutoCompleteSource.None;
            CategoryTextBox.BackgroundImageLayout = ImageLayout.None;
            CategoryTextBox.CharacterCasing = CharacterCasing.Normal;
            CategoryTextBox.Depth = 0;
            CategoryTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            CategoryTextBox.HideSelection = true;
            CategoryTextBox.Hint = "Category name";
            CategoryTextBox.LeadingIcon = null;
            CategoryTextBox.Location = new Point(59, 112);
            CategoryTextBox.MaxLength = 30;
            CategoryTextBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            CategoryTextBox.Name = "CategoryTextBox";
            CategoryTextBox.PasswordChar = '\0';
            CategoryTextBox.PrefixSuffixText = null;
            CategoryTextBox.ReadOnly = false;
            CategoryTextBox.RightToLeft = RightToLeft.No;
            CategoryTextBox.SelectedText = "";
            CategoryTextBox.SelectionLength = 0;
            CategoryTextBox.SelectionStart = 0;
            CategoryTextBox.ShortcutsEnabled = true;
            CategoryTextBox.Size = new Size(312, 48);
            CategoryTextBox.TabIndex = 1;
            CategoryTextBox.TabStop = false;
            CategoryTextBox.TextAlign = HorizontalAlignment.Left;
            CategoryTextBox.TrailingIcon = null;
            CategoryTextBox.UseAccent = false;
            CategoryTextBox.UseSystemPasswordChar = false;
            CategoryTextBox.Click += CategoryTextBox_Click;
            CategoryTextBox.KeyPress += NameTextBox_KeyPress;
            // 
            // CancelButton
            // 
            CancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CancelButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            CancelButton.Depth = 0;
            CancelButton.HighEmphasis = true;
            CancelButton.Icon = null;
            CancelButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            CancelButton.Location = new Point(344, 200);
            CancelButton.Margin = new Padding(4, 6, 4, 6);
            CancelButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            CancelButton.Name = "CancelButton";
            CancelButton.NoAccentTextColor = Color.Empty;
            CancelButton.Size = new Size(77, 36);
            CancelButton.TabIndex = 9;
            CancelButton.Text = "cancel";
            CancelButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            CancelButton.UseAccentColor = false;
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // NewCategoryButton
            // 
            NewCategoryButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            NewCategoryButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            NewCategoryButton.Depth = 0;
            NewCategoryButton.Enabled = false;
            NewCategoryButton.HighEmphasis = true;
            NewCategoryButton.Icon = null;
            NewCategoryButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            NewCategoryButton.Location = new Point(272, 200);
            NewCategoryButton.Margin = new Padding(4, 6, 4, 6);
            NewCategoryButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            NewCategoryButton.Name = "NewCategoryButton";
            NewCategoryButton.NoAccentTextColor = Color.Empty;
            NewCategoryButton.Size = new Size(64, 36);
            NewCategoryButton.TabIndex = 8;
            NewCategoryButton.Text = "add";
            NewCategoryButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            NewCategoryButton.UseAccentColor = false;
            NewCategoryButton.UseVisualStyleBackColor = true;
            NewCategoryButton.Click += NewCategoryButton_Click;
            // 
            // NewCategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 248);
            Controls.Add(CancelButton);
            Controls.Add(NewCategoryButton);
            Controls.Add(CategoryTextBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(432, 248);
            Name = "NewCategoryForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "New category";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit CategoryTextBox;
        private ReaLTaiizor.Controls.MaterialButton CancelButton;
        private ReaLTaiizor.Controls.MaterialButton NewCategoryButton;
    }
}
namespace TaskManagementApp.Forms
{
    partial class TaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
            TaskDescriptionBox = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            TaskTitleBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            NewTaskLabel = new ReaLTaiizor.Controls.MaterialLabel();
            DeadlineLabel = new ReaLTaiizor.Controls.MaterialLabel();
            AddTaskButton = new ReaLTaiizor.Controls.MaterialButton();
            CancelButton = new ReaLTaiizor.Controls.MaterialButton();
            DeadlinePicker = new DateTimePicker();
            IdBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            StatusBox = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            DescriptionWordsCount = new ReaLTaiizor.Controls.MaterialLabel();
            TitleWordsCount = new ReaLTaiizor.Controls.MaterialLabel();
            CategoryBox = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel5 = new ReaLTaiizor.Controls.MaterialLabel();
            PriorityBox = new ReaLTaiizor.Controls.MaterialComboBox();
            SuspendLayout();
            // 
            // TaskDescriptionBox
            // 
            TaskDescriptionBox.AnimateReadOnly = false;
            TaskDescriptionBox.BackgroundImageLayout = ImageLayout.None;
            TaskDescriptionBox.CharacterCasing = CharacterCasing.Normal;
            TaskDescriptionBox.Depth = 0;
            TaskDescriptionBox.HideSelection = true;
            TaskDescriptionBox.Location = new Point(165, 189);
            TaskDescriptionBox.MaxLength = 32767;
            TaskDescriptionBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TaskDescriptionBox.Name = "TaskDescriptionBox";
            TaskDescriptionBox.PasswordChar = '\0';
            TaskDescriptionBox.ReadOnly = false;
            TaskDescriptionBox.ScrollBars = ScrollBars.None;
            TaskDescriptionBox.SelectedText = "";
            TaskDescriptionBox.SelectionLength = 0;
            TaskDescriptionBox.SelectionStart = 0;
            TaskDescriptionBox.ShortcutsEnabled = true;
            TaskDescriptionBox.Size = new Size(375, 125);
            TaskDescriptionBox.TabIndex = 0;
            TaskDescriptionBox.TabStop = false;
            TaskDescriptionBox.TextAlign = HorizontalAlignment.Left;
            TaskDescriptionBox.UseAccent = false;
            TaskDescriptionBox.UseSystemPasswordChar = false;
            TaskDescriptionBox.KeyPress += TaskDescriptionBox_KeyPress;
            TaskDescriptionBox.TextChanged += TaskDescriptionBox_TextChanged;
            // 
            // TaskTitleBox
            // 
            TaskTitleBox.AnimateReadOnly = false;
            TaskTitleBox.AutoCompleteMode = AutoCompleteMode.None;
            TaskTitleBox.AutoCompleteSource = AutoCompleteSource.None;
            TaskTitleBox.BackgroundImageLayout = ImageLayout.None;
            TaskTitleBox.CharacterCasing = CharacterCasing.Normal;
            TaskTitleBox.Depth = 0;
            TaskTitleBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TaskTitleBox.HideSelection = true;
            TaskTitleBox.LeadingIcon = null;
            TaskTitleBox.Location = new Point(111, 116);
            TaskTitleBox.MaxLength = 32767;
            TaskTitleBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TaskTitleBox.Name = "TaskTitleBox";
            TaskTitleBox.PasswordChar = '\0';
            TaskTitleBox.PrefixSuffixText = null;
            TaskTitleBox.ReadOnly = false;
            TaskTitleBox.RightToLeft = RightToLeft.No;
            TaskTitleBox.SelectedText = "";
            TaskTitleBox.SelectionLength = 0;
            TaskTitleBox.SelectionStart = 0;
            TaskTitleBox.ShortcutsEnabled = true;
            TaskTitleBox.Size = new Size(429, 36);
            TaskTitleBox.TabIndex = 1;
            TaskTitleBox.TabStop = false;
            TaskTitleBox.TextAlign = HorizontalAlignment.Left;
            TaskTitleBox.TrailingIcon = null;
            TaskTitleBox.UseAccent = false;
            TaskTitleBox.UseSystemPasswordChar = false;
            TaskTitleBox.UseTallSize = false;
            TaskTitleBox.KeyPress += TaskTitleBox_KeyPress;
            TaskTitleBox.TextChanged += TaskTitleBox_TextChanged;
            // 
            // NewTaskLabel
            // 
            NewTaskLabel.AutoSize = true;
            NewTaskLabel.Depth = 0;
            NewTaskLabel.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            NewTaskLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            NewTaskLabel.Location = new Point(59, 58);
            NewTaskLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            NewTaskLabel.Name = "NewTaskLabel";
            NewTaskLabel.Size = new Size(100, 29);
            NewTaskLabel.TabIndex = 2;
            NewTaskLabel.Text = "New task";
            // 
            // DeadlineLabel
            // 
            DeadlineLabel.Depth = 0;
            DeadlineLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            DeadlineLabel.Location = new Point(59, 346);
            DeadlineLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            DeadlineLabel.Name = "DeadlineLabel";
            DeadlineLabel.Size = new Size(79, 30);
            DeadlineLabel.TabIndex = 4;
            DeadlineLabel.Text = "Deadline:";
            DeadlineLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddTaskButton
            // 
            AddTaskButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddTaskButton.AutoSize = false;
            AddTaskButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddTaskButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            AddTaskButton.Depth = 0;
            AddTaskButton.Enabled = false;
            AddTaskButton.HighEmphasis = true;
            AddTaskButton.Icon = null;
            AddTaskButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            AddTaskButton.Location = new Point(391, 733);
            AddTaskButton.Margin = new Padding(4, 6, 4, 6);
            AddTaskButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            AddTaskButton.Name = "AddTaskButton";
            AddTaskButton.NoAccentTextColor = Color.Empty;
            AddTaskButton.Size = new Size(64, 36);
            AddTaskButton.TabIndex = 5;
            AddTaskButton.Text = "Add";
            AddTaskButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            AddTaskButton.UseAccentColor = false;
            AddTaskButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelButton.AutoSize = false;
            CancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CancelButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            CancelButton.Depth = 0;
            CancelButton.HighEmphasis = true;
            CancelButton.Icon = null;
            CancelButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            CancelButton.Location = new Point(463, 733);
            CancelButton.Margin = new Padding(4, 6, 4, 6);
            CancelButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            CancelButton.Name = "CancelButton";
            CancelButton.NoAccentTextColor = Color.Empty;
            CancelButton.Size = new Size(77, 36);
            CancelButton.TabIndex = 6;
            CancelButton.Text = "Cancel";
            CancelButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            CancelButton.UseAccentColor = false;
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // DeadlinePicker
            // 
            DeadlinePicker.CustomFormat = " yyyy-MM-dd HH:mm";
            DeadlinePicker.Format = DateTimePickerFormat.Custom;
            DeadlinePicker.Location = new Point(144, 349);
            DeadlinePicker.Name = "DeadlinePicker";
            DeadlinePicker.ShowUpDown = true;
            DeadlinePicker.Size = new Size(150, 27);
            DeadlinePicker.TabIndex = 9;
            // 
            // IdBox
            // 
            IdBox.AnimateReadOnly = false;
            IdBox.AutoCompleteMode = AutoCompleteMode.None;
            IdBox.AutoCompleteSource = AutoCompleteSource.None;
            IdBox.BackgroundImageLayout = ImageLayout.None;
            IdBox.CharacterCasing = CharacterCasing.Normal;
            IdBox.Depth = 0;
            IdBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            IdBox.HideSelection = true;
            IdBox.LeadingIcon = null;
            IdBox.Location = new Point(217, 58);
            IdBox.MaxLength = 32767;
            IdBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            IdBox.Name = "IdBox";
            IdBox.PasswordChar = '\0';
            IdBox.PrefixSuffixText = null;
            IdBox.ReadOnly = false;
            IdBox.RightToLeft = RightToLeft.No;
            IdBox.SelectedText = "";
            IdBox.SelectionLength = 0;
            IdBox.SelectionStart = 0;
            IdBox.ShortcutsEnabled = true;
            IdBox.Size = new Size(83, 48);
            IdBox.TabIndex = 10;
            IdBox.TabStop = false;
            IdBox.TextAlign = HorizontalAlignment.Left;
            IdBox.TrailingIcon = null;
            IdBox.UseSystemPasswordChar = false;
            IdBox.Visible = false;
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(59, 393);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(59, 30);
            materialLabel1.TabIndex = 11;
            materialLabel1.Text = "Status:";
            materialLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StatusBox
            // 
            StatusBox.AutoResize = false;
            StatusBox.BackColor = Color.FromArgb(255, 255, 255);
            StatusBox.Depth = 0;
            StatusBox.DrawMode = DrawMode.OwnerDrawVariable;
            StatusBox.DropDownHeight = 118;
            StatusBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusBox.DropDownWidth = 121;
            StatusBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            StatusBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            StatusBox.FormattingEnabled = true;
            StatusBox.IntegralHeight = false;
            StatusBox.ItemHeight = 29;
            StatusBox.Items.AddRange(new object[] { "Not started", "In progress", "Completed" });
            StatusBox.Location = new Point(124, 393);
            StatusBox.MaxDropDownItems = 4;
            StatusBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            StatusBox.Name = "StatusBox";
            StatusBox.Size = new Size(151, 35);
            StatusBox.StartIndex = 0;
            StatusBox.TabIndex = 13;
            StatusBox.UseAccent = false;
            StatusBox.UseTallSize = false;
            // 
            // materialLabel2
            // 
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(59, 189);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(100, 30);
            materialLabel2.TabIndex = 14;
            materialLabel2.Text = "Description:";
            materialLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialLabel3
            // 
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(59, 116);
            materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(46, 30);
            materialLabel3.TabIndex = 15;
            materialLabel3.Text = "Title:";
            materialLabel3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DescriptionWordsCount
            // 
            DescriptionWordsCount.AutoSize = true;
            DescriptionWordsCount.Depth = 0;
            DescriptionWordsCount.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            DescriptionWordsCount.Location = new Point(165, 317);
            DescriptionWordsCount.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            DescriptionWordsCount.Name = "DescriptionWordsCount";
            DescriptionWordsCount.Size = new Size(53, 19);
            DescriptionWordsCount.TabIndex = 16;
            DescriptionWordsCount.Text = "0/1000";
            // 
            // TitleWordsCount
            // 
            TitleWordsCount.AutoSize = true;
            TitleWordsCount.Depth = 0;
            TitleWordsCount.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            TitleWordsCount.Location = new Point(111, 155);
            TitleWordsCount.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TitleWordsCount.Name = "TitleWordsCount";
            TitleWordsCount.Size = new Size(35, 19);
            TitleWordsCount.TabIndex = 17;
            TitleWordsCount.Text = "0/60";
            // 
            // CategoryBox
            // 
            CategoryBox.AutoResize = false;
            CategoryBox.BackColor = Color.FromArgb(255, 255, 255);
            CategoryBox.Depth = 0;
            CategoryBox.DrawMode = DrawMode.OwnerDrawVariable;
            CategoryBox.DropDownHeight = 118;
            CategoryBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryBox.DropDownWidth = 121;
            CategoryBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CategoryBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CategoryBox.FormattingEnabled = true;
            CategoryBox.IntegralHeight = false;
            CategoryBox.ItemHeight = 29;
            CategoryBox.Location = new Point(144, 446);
            CategoryBox.MaxDropDownItems = 4;
            CategoryBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            CategoryBox.Name = "CategoryBox";
            CategoryBox.Size = new Size(151, 35);
            CategoryBox.StartIndex = 0;
            CategoryBox.TabIndex = 18;
            CategoryBox.UseAccent = false;
            CategoryBox.UseTallSize = false;
            // 
            // materialLabel4
            // 
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(50, 446);
            materialLabel4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(88, 30);
            materialLabel4.TabIndex = 19;
            materialLabel4.Text = "Category:";
            materialLabel4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialLabel5
            // 
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(50, 504);
            materialLabel5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(68, 30);
            materialLabel5.TabIndex = 20;
            materialLabel5.Text = "Priority:";
            materialLabel5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PriorityBox
            // 
            PriorityBox.AutoResize = false;
            PriorityBox.BackColor = Color.FromArgb(255, 255, 255);
            PriorityBox.Depth = 0;
            PriorityBox.DrawMode = DrawMode.OwnerDrawVariable;
            PriorityBox.DropDownHeight = 118;
            PriorityBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PriorityBox.DropDownWidth = 121;
            PriorityBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            PriorityBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            PriorityBox.FormattingEnabled = true;
            PriorityBox.IntegralHeight = false;
            PriorityBox.ItemHeight = 29;
            PriorityBox.Items.AddRange(new object[] { "1 - lowest", "2 - low", "3 - medium ", "4 - high", "5 - highest" });
            PriorityBox.Location = new Point(124, 499);
            PriorityBox.MaxDropDownItems = 4;
            PriorityBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            PriorityBox.Name = "PriorityBox";
            PriorityBox.Size = new Size(131, 35);
            PriorityBox.StartIndex = 0;
            PriorityBox.TabIndex = 21;
            PriorityBox.UseAccent = false;
            PriorityBox.UseTallSize = false;
            // 
            // TaskForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(604, 800);
            Controls.Add(PriorityBox);
            Controls.Add(materialLabel5);
            Controls.Add(materialLabel4);
            Controls.Add(CategoryBox);
            Controls.Add(TitleWordsCount);
            Controls.Add(DescriptionWordsCount);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(StatusBox);
            Controls.Add(materialLabel1);
            Controls.Add(IdBox);
            Controls.Add(DeadlinePicker);
            Controls.Add(CancelButton);
            Controls.Add(AddTaskButton);
            Controls.Add(DeadlineLabel);
            Controls.Add(NewTaskLabel);
            Controls.Add(TaskTitleBox);
            Controls.Add(TaskDescriptionBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(604, 800);
            Name = "TaskForm";
            Padding = new Padding(3, 24, 3, 3);
            Sizable = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Task Management App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialLabel NewTaskLabel;
        private ReaLTaiizor.Controls.MaterialLabel DeadlineLabel;
        private ReaLTaiizor.Controls.MaterialButton CancelButton;
        public ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit TaskDescriptionBox;
        public ReaLTaiizor.Controls.MaterialTextBoxEdit TaskTitleBox;
        public DateTimePicker DeadlinePicker;
        public ReaLTaiizor.Controls.MaterialTextBoxEdit IdBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        public ReaLTaiizor.Controls.MaterialComboBox StatusBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialLabel DescriptionWordsCount;
        private ReaLTaiizor.Controls.MaterialLabel TitleWordsCount;
        public ReaLTaiizor.Controls.MaterialComboBox CategoryBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
        public ReaLTaiizor.Controls.MaterialComboBox PriorityBox;
        public ReaLTaiizor.Controls.MaterialButton AddTaskButton;
    }
}
namespace TaskManagementApp
{
    partial class DashboardForm
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
            components = new System.ComponentModel.Container();
            ReaLTaiizor.Child.Material.MaterialListBoxItem materialListBoxItem1 = new ReaLTaiizor.Child.Material.MaterialListBoxItem();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            MainMenuControl = new ReaLTaiizor.Controls.MaterialTabControl();
            TasksPage = new TabPage();
            panel1 = new Panel();
            TasksThisMonthL = new Label();
            TasksCompletedProgBar = new ReaLTaiizor.Controls.MaterialProgressBar();
            label3 = new Label();
            label2 = new Label();
            AvTaskDurVal = new Label();
            label1 = new Label();
            ExportButton = new ReaLTaiizor.Controls.MaterialButton();
            ImportButton = new ReaLTaiizor.Controls.MaterialButton();
            CategoryBox = new ReaLTaiizor.Controls.MaterialListBox();
            NoTasksLabel = new ReaLTaiizor.Controls.MaterialLabel();
            RefreshButton = new ReaLTaiizor.Controls.MaterialButton();
            NewTaskButton = new ReaLTaiizor.Controls.MaterialButton();
            TasksList = new ReaLTaiizor.Controls.PoisonDataGridView();
            Id = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Deadline = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Priority = new DataGridViewTextBoxColumn();
            EditCol = new DataGridViewButtonColumn();
            DeleteCol = new DataGridViewButtonColumn();
            SharingsPage = new TabPage();
            NoSharingsLabel = new ReaLTaiizor.Controls.MaterialLabel();
            TasksIdComboBox = new ReaLTaiizor.Controls.MaterialComboBox();
            ShareUsersBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TasksComboBox = new ReaLTaiizor.Controls.MaterialComboBox();
            ShareButton = new ReaLTaiizor.Controls.MaterialButton();
            SharingsTable = new ReaLTaiizor.Controls.PoisonDataGridView();
            SharingIdCol = new DataGridViewTextBoxColumn();
            TaskIdCol = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            SharedByCol = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            MoreCol = new DataGridViewButtonColumn();
            DelSharingCol = new DataGridViewButtonColumn();
            SettingsPage = new TabPage();
            LoginStatusSwitch = new ReaLTaiizor.Controls.MaterialSwitch();
            pictureBox4 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            SaveSettingsButton = new ReaLTaiizor.Controls.MaterialButton();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            BlueThemeRadioButton = new ReaLTaiizor.Controls.MaterialRadioButton();
            GreenThemeRadioButton = new ReaLTaiizor.Controls.MaterialRadioButton();
            RedThemeRadioButton = new ReaLTaiizor.Controls.MaterialRadioButton();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            UserPage = new TabPage();
            aloneNotice1 = new ReaLTaiizor.Controls.AloneNotice();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            DeleteAccountButton = new ReaLTaiizor.Controls.MaterialButton();
            RegisterButton = new ReaLTaiizor.Controls.MaterialButton();
            ConfirmPasswordTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            PasswordTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            EmailTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            UsernameTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            SurnameTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            NameTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            LogoutButton = new ReaLTaiizor.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            CategoryMenu = new ContextMenuStrip(components);
            DeleteOption = new ToolStripMenuItem();
            NewCategoryOption = new ToolStripMenuItem();
            MessageTimer = new System.Windows.Forms.Timer(components);
            ImportTasksDialog = new OpenFileDialog();
            ExportTasksDialog = new SaveFileDialog();
            MainMenuControl.SuspendLayout();
            TasksPage.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TasksList).BeginInit();
            SharingsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SharingsTable).BeginInit();
            SettingsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            UserPage.SuspendLayout();
            CategoryMenu.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(0, 0);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(200, 100);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "tabPage3";
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(0, 0);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(200, 100);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "tabPage4";
            // 
            // MainMenuControl
            // 
            MainMenuControl.Controls.Add(TasksPage);
            MainMenuControl.Controls.Add(SharingsPage);
            MainMenuControl.Controls.Add(SettingsPage);
            MainMenuControl.Controls.Add(UserPage);
            MainMenuControl.Depth = 0;
            MainMenuControl.Dock = DockStyle.Fill;
            MainMenuControl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuControl.HotTrack = true;
            MainMenuControl.ImageList = imageList1;
            MainMenuControl.ItemSize = new Size(70, 40);
            MainMenuControl.Location = new Point(3, 64);
            MainMenuControl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            MainMenuControl.Multiline = true;
            MainMenuControl.Name = "MainMenuControl";
            MainMenuControl.Padding = new Point(9, 3);
            MainMenuControl.RightToLeftLayout = true;
            MainMenuControl.SelectedIndex = 0;
            MainMenuControl.Size = new Size(1236, 667);
            MainMenuControl.TabIndex = 6;
            // 
            // TasksPage
            // 
            TasksPage.BackgroundImageLayout = ImageLayout.None;
            TasksPage.Controls.Add(panel1);
            TasksPage.Controls.Add(ExportButton);
            TasksPage.Controls.Add(ImportButton);
            TasksPage.Controls.Add(CategoryBox);
            TasksPage.Controls.Add(NoTasksLabel);
            TasksPage.Controls.Add(RefreshButton);
            TasksPage.Controls.Add(NewTaskButton);
            TasksPage.Controls.Add(TasksList);
            TasksPage.ImageKey = "task.png";
            TasksPage.Location = new Point(4, 44);
            TasksPage.Name = "TasksPage";
            TasksPage.Padding = new Padding(3);
            TasksPage.Size = new Size(1228, 619);
            TasksPage.TabIndex = 0;
            TasksPage.Text = "Tasks";
            // 
            // panel1
            // 
            panel1.Controls.Add(TasksThisMonthL);
            panel1.Controls.Add(TasksCompletedProgBar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(AvTaskDurVal);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(204, 565);
            panel1.Name = "panel1";
            panel1.Size = new Size(1007, 48);
            panel1.TabIndex = 8;
            // 
            // TasksThisMonthL
            // 
            TasksThisMonthL.AutoSize = true;
            TasksThisMonthL.Location = new Point(428, 9);
            TasksThisMonthL.Name = "TasksThisMonthL";
            TasksThisMonthL.Size = new Size(21, 25);
            TasksThisMonthL.TabIndex = 5;
            TasksThisMonthL.Text = "v";
            // 
            // TasksCompletedProgBar
            // 
            TasksCompletedProgBar.Depth = 0;
            TasksCompletedProgBar.Location = new Point(659, 16);
            TasksCompletedProgBar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TasksCompletedProgBar.Name = "TasksCompletedProgBar";
            TasksCompletedProgBar.Size = new Size(125, 18);
            TasksCompletedProgBar.Style = ProgressBarStyle.Continuous;
            TasksCompletedProgBar.TabIndex = 4;
            TasksCompletedProgBar.UseAccentColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(501, 9);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 3;
            label3.Text = "Tasks completed: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 9);
            label2.Name = "label2";
            label2.Size = new Size(153, 25);
            label2.TabIndex = 2;
            label2.Text = "Tasks this month: ";
            // 
            // AvTaskDurVal
            // 
            AvTaskDurVal.AutoSize = true;
            AvTaskDurVal.Location = new Point(216, 9);
            AvTaskDurVal.Name = "AvTaskDurVal";
            AvTaskDurVal.Size = new Size(21, 25);
            AvTaskDurVal.TabIndex = 1;
            AvTaskDurVal.Text = "v";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(195, 25);
            label1.TabIndex = 0;
            label1.Text = "Average task duration: ";
            // 
            // ExportButton
            // 
            ExportButton.AutoSize = false;
            ExportButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ExportButton.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            ExportButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ExportButton.Depth = 0;
            ExportButton.HighEmphasis = true;
            ExportButton.Icon = null;
            ExportButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ExportButton.Location = new Point(286, 9);
            ExportButton.Margin = new Padding(4, 6, 4, 6);
            ExportButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ExportButton.Name = "ExportButton";
            ExportButton.NoAccentTextColor = Color.Empty;
            ExportButton.Size = new Size(85, 32);
            ExportButton.TabIndex = 7;
            ExportButton.Text = "Export";
            ExportButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            ExportButton.UseAccentColor = false;
            ExportButton.UseMnemonic = false;
            ExportButton.UseVisualStyleBackColor = false;
            ExportButton.Click += ExportButton_Click;
            // 
            // ImportButton
            // 
            ImportButton.AutoSize = false;
            ImportButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ImportButton.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            ImportButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ImportButton.Depth = 0;
            ImportButton.HighEmphasis = true;
            ImportButton.Icon = null;
            ImportButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ImportButton.Location = new Point(193, 9);
            ImportButton.Margin = new Padding(4, 6, 4, 6);
            ImportButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ImportButton.Name = "ImportButton";
            ImportButton.NoAccentTextColor = Color.Empty;
            ImportButton.Size = new Size(85, 32);
            ImportButton.TabIndex = 6;
            ImportButton.Text = "import";
            ImportButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            ImportButton.UseAccentColor = false;
            ImportButton.UseMnemonic = false;
            ImportButton.UseVisualStyleBackColor = false;
            ImportButton.Click += ImportButton_Click;
            // 
            // CategoryBox
            // 
            CategoryBox.BackColor = SystemColors.Control;
            CategoryBox.BorderColor = Color.LightGray;
            CategoryBox.Depth = 0;
            CategoryBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialListBoxItem1.SecondaryText = "";
            materialListBoxItem1.Tag = null;
            materialListBoxItem1.Text = "All";
            CategoryBox.Items.Add(materialListBoxItem1);
            CategoryBox.Location = new Point(18, 51);
            CategoryBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            CategoryBox.Name = "CategoryBox";
            CategoryBox.SelectedIndex = -1;
            CategoryBox.SelectedItem = null;
            CategoryBox.Size = new Size(167, 200);
            CategoryBox.TabIndex = 5;
            CategoryBox.SelectedIndexChanged += materialListBox2_SelectedIndexChanged;
            CategoryBox.MouseClick += CategoryBox_MouseClick;
            // 
            // NoTasksLabel
            // 
            NoTasksLabel.AutoSize = true;
            NoTasksLabel.Depth = 0;
            NoTasksLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            NoTasksLabel.Location = new Point(567, 86);
            NoTasksLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            NoTasksLabel.Name = "NoTasksLabel";
            NoTasksLabel.Size = new Size(109, 19);
            NoTasksLabel.TabIndex = 3;
            NoTasksLabel.Text = "No tasks found";
            NoTasksLabel.Visible = false;
            // 
            // RefreshButton
            // 
            RefreshButton.AutoSize = false;
            RefreshButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RefreshButton.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            RefreshButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            RefreshButton.Depth = 0;
            RefreshButton.HighEmphasis = true;
            RefreshButton.Icon = null;
            RefreshButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            RefreshButton.Location = new Point(100, 9);
            RefreshButton.Margin = new Padding(4, 6, 4, 6);
            RefreshButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            RefreshButton.Name = "RefreshButton";
            RefreshButton.NoAccentTextColor = Color.Empty;
            RefreshButton.Size = new Size(85, 32);
            RefreshButton.TabIndex = 2;
            RefreshButton.Text = "refresh";
            RefreshButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            RefreshButton.UseAccentColor = false;
            RefreshButton.UseMnemonic = false;
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // NewTaskButton
            // 
            NewTaskButton.AutoSize = false;
            NewTaskButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            NewTaskButton.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            NewTaskButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            NewTaskButton.Depth = 0;
            NewTaskButton.HighEmphasis = true;
            NewTaskButton.Icon = null;
            NewTaskButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            NewTaskButton.Location = new Point(7, 10);
            NewTaskButton.Margin = new Padding(4, 6, 4, 6);
            NewTaskButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            NewTaskButton.Name = "NewTaskButton";
            NewTaskButton.NoAccentTextColor = Color.Empty;
            NewTaskButton.Size = new Size(85, 32);
            NewTaskButton.TabIndex = 1;
            NewTaskButton.Text = "+ new task";
            NewTaskButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            NewTaskButton.UseAccentColor = false;
            NewTaskButton.UseMnemonic = false;
            NewTaskButton.UseVisualStyleBackColor = false;
            NewTaskButton.Click += NewTaskButton_Click;
            // 
            // TasksList
            // 
            TasksList.AllowUserToAddRows = false;
            TasksList.AllowUserToDeleteRows = false;
            TasksList.AllowUserToResizeColumns = false;
            TasksList.AllowUserToResizeRows = false;
            TasksList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TasksList.BackgroundColor = Color.FromArgb(255, 255, 255);
            TasksList.BorderStyle = BorderStyle.None;
            TasksList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            TasksList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 175, 219);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            TasksList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            TasksList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TasksList.Columns.AddRange(new DataGridViewColumn[] { Id, Title, Description, Deadline, Status, Category, Priority, EditCol, DeleteCol });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(0, 175, 219);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            TasksList.DefaultCellStyle = dataGridViewCellStyle10;
            TasksList.EnableHeadersVisualStyles = false;
            TasksList.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            TasksList.GridColor = Color.FromArgb(255, 255, 255);
            TasksList.HighLightPercentage = 0F;
            TasksList.Location = new Point(204, 51);
            TasksList.Name = "TasksList";
            TasksList.ReadOnly = true;
            TasksList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(0, 175, 219);
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            TasksList.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            TasksList.RowHeadersVisible = false;
            TasksList.RowHeadersWidth = 51;
            TasksList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            TasksList.RowTemplate.Height = 29;
            TasksList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TasksList.Size = new Size(1007, 508);
            TasksList.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Custom;
            TasksList.TabIndex = 0;
            TasksList.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            TasksList.UseCustomBackColor = true;
            TasksList.UseCustomForeColor = true;
            TasksList.Visible = false;
            TasksList.CellContentClick += TasksList_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // Title
            // 
            Title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Title.DefaultCellStyle = dataGridViewCellStyle2;
            Title.HeaderText = "Title";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Description.DefaultCellStyle = dataGridViewCellStyle3;
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // Deadline
            // 
            Deadline.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.Format = "g";
            dataGridViewCellStyle4.NullValue = null;
            Deadline.DefaultCellStyle = dataGridViewCellStyle4;
            Deadline.HeaderText = "Deadline";
            Deadline.MinimumWidth = 6;
            Deadline.Name = "Deadline";
            Deadline.ReadOnly = true;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Status.DefaultCellStyle = dataGridViewCellStyle5;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // Category
            // 
            Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            Category.DefaultCellStyle = dataGridViewCellStyle6;
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // Priority
            // 
            Priority.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.White;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            Priority.DefaultCellStyle = dataGridViewCellStyle7;
            Priority.HeaderText = "Priority";
            Priority.MinimumWidth = 6;
            Priority.Name = "Priority";
            Priority.ReadOnly = true;
            // 
            // EditCol
            // 
            EditCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            EditCol.DefaultCellStyle = dataGridViewCellStyle8;
            EditCol.FlatStyle = FlatStyle.Popup;
            EditCol.HeaderText = "";
            EditCol.MinimumWidth = 6;
            EditCol.Name = "EditCol";
            EditCol.ReadOnly = true;
            EditCol.Text = "Edit";
            EditCol.UseColumnTextForButtonValue = true;
            EditCol.Width = 125;
            // 
            // DeleteCol
            // 
            DeleteCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            DeleteCol.DefaultCellStyle = dataGridViewCellStyle9;
            DeleteCol.FlatStyle = FlatStyle.Popup;
            DeleteCol.HeaderText = "";
            DeleteCol.MinimumWidth = 6;
            DeleteCol.Name = "DeleteCol";
            DeleteCol.ReadOnly = true;
            DeleteCol.Text = "Delete";
            DeleteCol.UseColumnTextForButtonValue = true;
            DeleteCol.Width = 125;
            // 
            // SharingsPage
            // 
            SharingsPage.Controls.Add(NoSharingsLabel);
            SharingsPage.Controls.Add(TasksIdComboBox);
            SharingsPage.Controls.Add(ShareUsersBox);
            SharingsPage.Controls.Add(TasksComboBox);
            SharingsPage.Controls.Add(ShareButton);
            SharingsPage.Controls.Add(SharingsTable);
            SharingsPage.ImageKey = "share32.png";
            SharingsPage.Location = new Point(4, 44);
            SharingsPage.Name = "SharingsPage";
            SharingsPage.Size = new Size(1228, 619);
            SharingsPage.TabIndex = 3;
            SharingsPage.Text = "Sharings";
            // 
            // NoSharingsLabel
            // 
            NoSharingsLabel.AutoSize = true;
            NoSharingsLabel.Depth = 0;
            NoSharingsLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            NoSharingsLabel.Location = new Point(533, 173);
            NoSharingsLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            NoSharingsLabel.Name = "NoSharingsLabel";
            NoSharingsLabel.Size = new Size(132, 19);
            NoSharingsLabel.TabIndex = 6;
            NoSharingsLabel.Text = "No sharings found";
            NoSharingsLabel.Visible = false;
            // 
            // TasksIdComboBox
            // 
            TasksIdComboBox.AutoResize = false;
            TasksIdComboBox.BackColor = Color.FromArgb(255, 255, 255);
            TasksIdComboBox.Depth = 0;
            TasksIdComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            TasksIdComboBox.DropDownHeight = 174;
            TasksIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TasksIdComboBox.DropDownWidth = 121;
            TasksIdComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            TasksIdComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            TasksIdComboBox.FormattingEnabled = true;
            TasksIdComboBox.Hint = "Tasks";
            TasksIdComboBox.IntegralHeight = false;
            TasksIdComboBox.ItemHeight = 43;
            TasksIdComboBox.Location = new Point(1110, 24);
            TasksIdComboBox.MaxDropDownItems = 4;
            TasksIdComboBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TasksIdComboBox.Name = "TasksIdComboBox";
            TasksIdComboBox.Size = new Size(97, 49);
            TasksIdComboBox.StartIndex = 0;
            TasksIdComboBox.TabIndex = 5;
            TasksIdComboBox.Visible = false;
            // 
            // ShareUsersBox
            // 
            ShareUsersBox.AnimateReadOnly = false;
            ShareUsersBox.AutoCompleteMode = AutoCompleteMode.None;
            ShareUsersBox.AutoCompleteSource = AutoCompleteSource.None;
            ShareUsersBox.BackgroundImageLayout = ImageLayout.None;
            ShareUsersBox.CharacterCasing = CharacterCasing.Normal;
            ShareUsersBox.Depth = 0;
            ShareUsersBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ShareUsersBox.HideSelection = true;
            ShareUsersBox.Hint = "Share with user(s)";
            ShareUsersBox.LeadingIcon = null;
            ShareUsersBox.Location = new Point(433, 25);
            ShareUsersBox.MaxLength = 32767;
            ShareUsersBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            ShareUsersBox.Name = "ShareUsersBox";
            ShareUsersBox.PasswordChar = '\0';
            ShareUsersBox.PrefixSuffixText = null;
            ShareUsersBox.ReadOnly = false;
            ShareUsersBox.RightToLeft = RightToLeft.No;
            ShareUsersBox.SelectedText = "";
            ShareUsersBox.SelectionLength = 0;
            ShareUsersBox.SelectionStart = 0;
            ShareUsersBox.ShortcutsEnabled = true;
            ShareUsersBox.ShowAssistiveText = true;
            ShareUsersBox.Size = new Size(312, 64);
            ShareUsersBox.TabIndex = 4;
            ShareUsersBox.TabStop = false;
            ShareUsersBox.TextAlign = HorizontalAlignment.Left;
            ShareUsersBox.TrailingIcon = null;
            ShareUsersBox.UseAccent = false;
            ShareUsersBox.UseSystemPasswordChar = false;
            ShareUsersBox.TextChanged += ShareUsersBox_TextChanged;
            // 
            // TasksComboBox
            // 
            TasksComboBox.AutoResize = false;
            TasksComboBox.BackColor = Color.FromArgb(255, 255, 255);
            TasksComboBox.Depth = 0;
            TasksComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            TasksComboBox.DropDownHeight = 174;
            TasksComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TasksComboBox.DropDownWidth = 121;
            TasksComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            TasksComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            TasksComboBox.FormattingEnabled = true;
            TasksComboBox.Hint = "Tasks to share";
            TasksComboBox.IntegralHeight = false;
            TasksComboBox.ItemHeight = 43;
            TasksComboBox.Location = new Point(16, 24);
            TasksComboBox.MaxDropDownItems = 4;
            TasksComboBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TasksComboBox.Name = "TasksComboBox";
            TasksComboBox.Size = new Size(411, 49);
            TasksComboBox.StartIndex = 0;
            TasksComboBox.TabIndex = 3;
            TasksComboBox.UseAccent = false;
            // 
            // ShareButton
            // 
            ShareButton.AutoSize = false;
            ShareButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ShareButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ShareButton.Depth = 0;
            ShareButton.Enabled = false;
            ShareButton.HighEmphasis = true;
            ShareButton.Icon = null;
            ShareButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ShareButton.Location = new Point(762, 25);
            ShareButton.Margin = new Padding(4, 6, 4, 6);
            ShareButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ShareButton.Name = "ShareButton";
            ShareButton.NoAccentTextColor = Color.Empty;
            ShareButton.Size = new Size(120, 48);
            ShareButton.TabIndex = 2;
            ShareButton.Text = "share task";
            ShareButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ShareButton.UseAccentColor = false;
            ShareButton.UseMnemonic = false;
            ShareButton.UseVisualStyleBackColor = false;
            ShareButton.Click += ShareButton_Click;
            // 
            // SharingsTable
            // 
            SharingsTable.AllowUserToAddRows = false;
            SharingsTable.AllowUserToDeleteRows = false;
            SharingsTable.AllowUserToResizeColumns = false;
            SharingsTable.AllowUserToResizeRows = false;
            SharingsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SharingsTable.BackgroundColor = Color.FromArgb(255, 255, 255);
            SharingsTable.BorderStyle = BorderStyle.None;
            SharingsTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
            SharingsTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(0, 175, 219);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            SharingsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            SharingsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SharingsTable.Columns.AddRange(new DataGridViewColumn[] { SharingIdCol, TaskIdCol, dataGridViewTextBoxColumn2, SharedByCol, dataGridViewTextBoxColumn7, MoreCol, DelSharingCol });
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle18.SelectionBackColor = Color.FromArgb(0, 175, 219);
            dataGridViewCellStyle18.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            SharingsTable.DefaultCellStyle = dataGridViewCellStyle18;
            SharingsTable.EnableHeadersVisualStyles = false;
            SharingsTable.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            SharingsTable.GridColor = Color.FromArgb(255, 255, 255);
            SharingsTable.HighLightPercentage = 0F;
            SharingsTable.Location = new Point(16, 101);
            SharingsTable.Name = "SharingsTable";
            SharingsTable.ReadOnly = true;
            SharingsTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle19.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle19.SelectionBackColor = Color.FromArgb(0, 175, 219);
            dataGridViewCellStyle19.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            SharingsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            SharingsTable.RowHeadersVisible = false;
            SharingsTable.RowHeadersWidth = 51;
            SharingsTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            SharingsTable.RowTemplate.Height = 29;
            SharingsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SharingsTable.Size = new Size(1191, 484);
            SharingsTable.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Custom;
            SharingsTable.TabIndex = 1;
            SharingsTable.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            SharingsTable.UseCustomBackColor = true;
            SharingsTable.UseCustomForeColor = true;
            SharingsTable.Visible = false;
            SharingsTable.CellContentClick += SharingsTable_CellContentClick;
            // 
            // SharingIdCol
            // 
            SharingIdCol.HeaderText = "Id";
            SharingIdCol.MinimumWidth = 6;
            SharingIdCol.Name = "SharingIdCol";
            SharingIdCol.ReadOnly = true;
            SharingIdCol.Visible = false;
            SharingIdCol.Width = 125;
            // 
            // TaskIdCol
            // 
            TaskIdCol.HeaderText = "TaskId";
            TaskIdCol.MinimumWidth = 6;
            TaskIdCol.Name = "TaskIdCol";
            TaskIdCol.ReadOnly = true;
            TaskIdCol.Visible = false;
            TaskIdCol.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewTextBoxColumn2.HeaderText = "Title";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // SharedByCol
            // 
            SharedByCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = Color.White;
            dataGridViewCellStyle14.SelectionForeColor = Color.Black;
            SharedByCol.DefaultCellStyle = dataGridViewCellStyle14;
            SharedByCol.HeaderText = "Shared By";
            SharedByCol.MinimumWidth = 6;
            SharedByCol.Name = "SharedByCol";
            SharedByCol.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.BackColor = Color.White;
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = Color.White;
            dataGridViewCellStyle15.SelectionForeColor = Color.Black;
            dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewTextBoxColumn7.HeaderText = "SharedWith";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // MoreCol
            // 
            MoreCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = Color.White;
            dataGridViewCellStyle16.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = Color.White;
            dataGridViewCellStyle16.SelectionForeColor = Color.Black;
            MoreCol.DefaultCellStyle = dataGridViewCellStyle16;
            MoreCol.FlatStyle = FlatStyle.Popup;
            MoreCol.HeaderText = "";
            MoreCol.MinimumWidth = 6;
            MoreCol.Name = "MoreCol";
            MoreCol.ReadOnly = true;
            MoreCol.Text = "more...";
            MoreCol.UseColumnTextForButtonValue = true;
            MoreCol.Width = 125;
            // 
            // DelSharingCol
            // 
            DelSharingCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle17.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle17.SelectionForeColor = Color.Black;
            DelSharingCol.DefaultCellStyle = dataGridViewCellStyle17;
            DelSharingCol.FlatStyle = FlatStyle.Popup;
            DelSharingCol.HeaderText = "";
            DelSharingCol.MinimumWidth = 6;
            DelSharingCol.Name = "DelSharingCol";
            DelSharingCol.ReadOnly = true;
            DelSharingCol.Text = "stop sharing";
            DelSharingCol.UseColumnTextForButtonValue = true;
            DelSharingCol.Width = 125;
            // 
            // SettingsPage
            // 
            SettingsPage.Controls.Add(LoginStatusSwitch);
            SettingsPage.Controls.Add(pictureBox4);
            SettingsPage.Controls.Add(pictureBox9);
            SettingsPage.Controls.Add(pictureBox5);
            SettingsPage.Controls.Add(pictureBox8);
            SettingsPage.Controls.Add(pictureBox6);
            SettingsPage.Controls.Add(pictureBox7);
            SettingsPage.Controls.Add(SaveSettingsButton);
            SettingsPage.Controls.Add(materialLabel2);
            SettingsPage.Controls.Add(BlueThemeRadioButton);
            SettingsPage.Controls.Add(GreenThemeRadioButton);
            SettingsPage.Controls.Add(RedThemeRadioButton);
            SettingsPage.Controls.Add(pictureBox3);
            SettingsPage.Controls.Add(pictureBox2);
            SettingsPage.Controls.Add(pictureBox1);
            SettingsPage.ImageKey = "settings.png";
            SettingsPage.Location = new Point(4, 44);
            SettingsPage.Name = "SettingsPage";
            SettingsPage.Size = new Size(1228, 619);
            SettingsPage.TabIndex = 2;
            SettingsPage.Text = "Settings";
            // 
            // LoginStatusSwitch
            // 
            LoginStatusSwitch.Anchor = AnchorStyles.Left;
            LoginStatusSwitch.Depth = 0;
            LoginStatusSwitch.Location = new Point(46, 366);
            LoginStatusSwitch.Margin = new Padding(0);
            LoginStatusSwitch.MouseLocation = new Point(-1, -1);
            LoginStatusSwitch.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            LoginStatusSwitch.Name = "LoginStatusSwitch";
            LoginStatusSwitch.Ripple = false;
            LoginStatusSwitch.Size = new Size(156, 37);
            LoginStatusSwitch.TabIndex = 15;
            LoginStatusSwitch.TabStop = false;
            LoginStatusSwitch.Text = "auto login";
            LoginStatusSwitch.UseAccentColor = false;
            LoginStatusSwitch.UseVisualStyleBackColor = false;
            LoginStatusSwitch.CheckedChanged += LoginStatusSwitch_CheckedChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.OrangeRed;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Location = new Point(124, 241);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(78, 78);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Salmon;
            pictureBox9.BorderStyle = BorderStyle.FixedSingle;
            pictureBox9.Location = new Point(85, 202);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(117, 117);
            pictureBox9.TabIndex = 14;
            pictureBox9.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Green;
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Location = new Point(376, 241);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(78, 78);
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.LightGreen;
            pictureBox8.BorderStyle = BorderStyle.FixedSingle;
            pictureBox8.Location = new Point(337, 202);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(117, 117);
            pictureBox8.TabIndex = 13;
            pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.MediumBlue;
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.Location = new Point(631, 241);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(78, 78);
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.RoyalBlue;
            pictureBox7.BorderStyle = BorderStyle.FixedSingle;
            pictureBox7.Location = new Point(592, 202);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(117, 117);
            pictureBox7.TabIndex = 12;
            pictureBox7.TabStop = false;
            // 
            // SaveSettingsButton
            // 
            SaveSettingsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveSettingsButton.AutoSize = false;
            SaveSettingsButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SaveSettingsButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            SaveSettingsButton.Depth = 0;
            SaveSettingsButton.HighEmphasis = true;
            SaveSettingsButton.Icon = null;
            SaveSettingsButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            SaveSettingsButton.Location = new Point(1044, 537);
            SaveSettingsButton.Margin = new Padding(4, 6, 4, 6);
            SaveSettingsButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            SaveSettingsButton.Name = "SaveSettingsButton";
            SaveSettingsButton.NoAccentTextColor = Color.Empty;
            SaveSettingsButton.Size = new Size(120, 36);
            SaveSettingsButton.TabIndex = 11;
            SaveSettingsButton.Text = "Save";
            SaveSettingsButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            SaveSettingsButton.UseAccentColor = false;
            SaveSettingsButton.UseVisualStyleBackColor = true;
            SaveSettingsButton.Click += SaveSettingsButton_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            materialLabel2.Location = new Point(46, 38);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(63, 24);
            materialLabel2.TabIndex = 10;
            materialLabel2.Text = "Theme";
            // 
            // BlueThemeRadioButton
            // 
            BlueThemeRadioButton.AutoSize = true;
            BlueThemeRadioButton.Depth = 0;
            BlueThemeRadioButton.Location = new Point(553, 107);
            BlueThemeRadioButton.Margin = new Padding(0);
            BlueThemeRadioButton.MouseLocation = new Point(-1, -1);
            BlueThemeRadioButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            BlueThemeRadioButton.Name = "BlueThemeRadioButton";
            BlueThemeRadioButton.Ripple = true;
            BlueThemeRadioButton.Size = new Size(66, 37);
            BlueThemeRadioButton.TabIndex = 6;
            BlueThemeRadioButton.TabStop = true;
            BlueThemeRadioButton.Text = "Blue";
            BlueThemeRadioButton.UseAccentColor = false;
            BlueThemeRadioButton.UseVisualStyleBackColor = true;
            BlueThemeRadioButton.CheckedChanged += BlueThemeRadioButton_CheckedChanged;
            // 
            // GreenThemeRadioButton
            // 
            GreenThemeRadioButton.AutoSize = true;
            GreenThemeRadioButton.Depth = 0;
            GreenThemeRadioButton.Location = new Point(298, 107);
            GreenThemeRadioButton.Margin = new Padding(0);
            GreenThemeRadioButton.MouseLocation = new Point(-1, -1);
            GreenThemeRadioButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            GreenThemeRadioButton.Name = "GreenThemeRadioButton";
            GreenThemeRadioButton.Ripple = true;
            GreenThemeRadioButton.Size = new Size(76, 37);
            GreenThemeRadioButton.TabIndex = 5;
            GreenThemeRadioButton.TabStop = true;
            GreenThemeRadioButton.Text = "Green";
            GreenThemeRadioButton.UseAccentColor = false;
            GreenThemeRadioButton.UseVisualStyleBackColor = true;
            GreenThemeRadioButton.CheckedChanged += GreenThemeRadioButton_CheckedChanged;
            // 
            // RedThemeRadioButton
            // 
            RedThemeRadioButton.AutoSize = true;
            RedThemeRadioButton.Depth = 0;
            RedThemeRadioButton.Location = new Point(46, 107);
            RedThemeRadioButton.Margin = new Padding(0);
            RedThemeRadioButton.MouseLocation = new Point(-1, -1);
            RedThemeRadioButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            RedThemeRadioButton.Name = "RedThemeRadioButton";
            RedThemeRadioButton.Ripple = true;
            RedThemeRadioButton.Size = new Size(62, 37);
            RedThemeRadioButton.TabIndex = 4;
            RedThemeRadioButton.TabStop = true;
            RedThemeRadioButton.Text = "Red";
            RedThemeRadioButton.UseAccentColor = false;
            RedThemeRadioButton.UseVisualStyleBackColor = true;
            RedThemeRadioButton.CheckedChanged += RedThemeRadioButton_CheckedChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(553, 163);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(156, 156);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(298, 163);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(156, 156);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(46, 163);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 156);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // UserPage
            // 
            UserPage.Controls.Add(aloneNotice1);
            UserPage.Controls.Add(materialLabel1);
            UserPage.Controls.Add(DeleteAccountButton);
            UserPage.Controls.Add(RegisterButton);
            UserPage.Controls.Add(ConfirmPasswordTextBox);
            UserPage.Controls.Add(PasswordTextBox);
            UserPage.Controls.Add(EmailTextBox);
            UserPage.Controls.Add(UsernameTextBox);
            UserPage.Controls.Add(SurnameTextBox);
            UserPage.Controls.Add(NameTextBox);
            UserPage.Controls.Add(LogoutButton);
            UserPage.ImageKey = "user2.png";
            UserPage.Location = new Point(4, 44);
            UserPage.Name = "UserPage";
            UserPage.Padding = new Padding(3);
            UserPage.RightToLeft = RightToLeft.No;
            UserPage.Size = new Size(1228, 619);
            UserPage.TabIndex = 1;
            UserPage.Text = "Account";
            // 
            // aloneNotice1
            // 
            aloneNotice1.BackColor = Color.FromArgb(255, 253, 232);
            aloneNotice1.BorderColor = Color.White;
            aloneNotice1.BorderStyle = BorderStyle.None;
            aloneNotice1.Enabled = false;
            aloneNotice1.ForeColor = Color.DarkGoldenrod;
            aloneNotice1.Location = new Point(294, 372);
            aloneNotice1.Multiline = true;
            aloneNotice1.Name = "aloneNotice1";
            aloneNotice1.ReadOnly = true;
            aloneNotice1.Size = new Size(312, 115);
            aloneNotice1.TabIndex = 19;
            aloneNotice1.Text = "Password must:\r\n1.  Have at least 8 characters length.\r\n2.  Have at least one digit.\r\n3.  Have at least one uppercase letter.\r\n4.  Have at least one special symbol.";
            // 
            // materialLabel1
            // 
            materialLabel1.BackColor = Color.Transparent;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H4;
            materialLabel1.HighEmphasis = true;
            materialLabel1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            materialLabel1.Location = new Point(466, 75);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(319, 63);
            materialLabel1.TabIndex = 18;
            materialLabel1.Text = "Account information";
            // 
            // DeleteAccountButton
            // 
            DeleteAccountButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DeleteAccountButton.BackColor = Color.Red;
            DeleteAccountButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            DeleteAccountButton.Depth = 0;
            DeleteAccountButton.HighEmphasis = false;
            DeleteAccountButton.Icon = null;
            DeleteAccountButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            DeleteAccountButton.Location = new Point(379, 507);
            DeleteAccountButton.Margin = new Padding(4, 6, 4, 6);
            DeleteAccountButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            DeleteAccountButton.Name = "DeleteAccountButton";
            DeleteAccountButton.NoAccentTextColor = Color.Empty;
            DeleteAccountButton.Size = new Size(145, 36);
            DeleteAccountButton.TabIndex = 17;
            DeleteAccountButton.Text = "delete account";
            DeleteAccountButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            DeleteAccountButton.UseAccentColor = false;
            DeleteAccountButton.UseVisualStyleBackColor = true;
            DeleteAccountButton.Click += DeleteAccountButton_Click;
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
            RegisterButton.Location = new Point(294, 507);
            RegisterButton.Margin = new Padding(4, 6, 4, 6);
            RegisterButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            RegisterButton.Name = "RegisterButton";
            RegisterButton.NoAccentTextColor = Color.Empty;
            RegisterButton.Size = new Size(77, 36);
            RegisterButton.TabIndex = 16;
            RegisterButton.Text = "update";
            RegisterButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            RegisterButton.UseAccentColor = false;
            RegisterButton.UseVisualStyleBackColor = true;
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
            ConfirmPasswordTextBox.Location = new Point(623, 302);
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
            ConfirmPasswordTextBox.TabIndex = 15;
            ConfirmPasswordTextBox.TabStop = false;
            ConfirmPasswordTextBox.TextAlign = HorizontalAlignment.Left;
            ConfirmPasswordTextBox.TrailingIcon = Properties.Resources.pass_hide;
            ConfirmPasswordTextBox.UseAccent = false;
            ConfirmPasswordTextBox.UseSystemPasswordChar = true;
            ConfirmPasswordTextBox.TrailingIconClick += ConfirmPasswordTextBox_TrailingIconClick;
            ConfirmPasswordTextBox.TextChanged += ConfirmPasswordTextBox_TextChanged;
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
            PasswordTextBox.Location = new Point(294, 302);
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
            PasswordTextBox.TabIndex = 14;
            PasswordTextBox.TabStop = false;
            PasswordTextBox.TextAlign = HorizontalAlignment.Left;
            PasswordTextBox.TrailingIcon = null;
            PasswordTextBox.UseAccent = false;
            PasswordTextBox.UseSystemPasswordChar = true;
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
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
            EmailTextBox.Location = new Point(623, 232);
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
            EmailTextBox.TabIndex = 13;
            EmailTextBox.TabStop = false;
            EmailTextBox.TextAlign = HorizontalAlignment.Left;
            EmailTextBox.TrailingIcon = null;
            EmailTextBox.UseAccent = false;
            EmailTextBox.UseSystemPasswordChar = false;
            EmailTextBox.TextChanged += EmailTextBox_TextChanged;
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
            UsernameTextBox.Location = new Point(294, 232);
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
            UsernameTextBox.TabIndex = 12;
            UsernameTextBox.TabStop = false;
            UsernameTextBox.TextAlign = HorizontalAlignment.Left;
            UsernameTextBox.TrailingIcon = null;
            UsernameTextBox.UseAccent = false;
            UsernameTextBox.UseSystemPasswordChar = false;
            UsernameTextBox.TextChanged += UsernameTextBox_TextChanged;
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
            SurnameTextBox.Location = new Point(623, 162);
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
            SurnameTextBox.TabIndex = 11;
            SurnameTextBox.TabStop = false;
            SurnameTextBox.TextAlign = HorizontalAlignment.Left;
            SurnameTextBox.TrailingIcon = null;
            SurnameTextBox.UseAccent = false;
            SurnameTextBox.UseSystemPasswordChar = false;
            SurnameTextBox.TextChanged += SurnameTextBox_TextChanged;
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
            NameTextBox.Location = new Point(294, 162);
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
            NameTextBox.TabIndex = 10;
            NameTextBox.TabStop = false;
            NameTextBox.TextAlign = HorizontalAlignment.Left;
            NameTextBox.TrailingIcon = null;
            NameTextBox.UseAccent = false;
            NameTextBox.UseSystemPasswordChar = false;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // LogoutButton
            // 
            LogoutButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LogoutButton.AutoSize = false;
            LogoutButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LogoutButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            LogoutButton.Depth = 0;
            LogoutButton.ForeColor = Color.White;
            LogoutButton.HighEmphasis = true;
            LogoutButton.Icon = Properties.Resources.logout;
            LogoutButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            LogoutButton.Location = new Point(1099, 574);
            LogoutButton.Margin = new Padding(4, 6, 4, 6);
            LogoutButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            LogoutButton.Name = "LogoutButton";
            LogoutButton.NoAccentTextColor = Color.Empty;
            LogoutButton.Size = new Size(122, 36);
            LogoutButton.TabIndex = 0;
            LogoutButton.Text = "Logout";
            LogoutButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            LogoutButton.UseAccentColor = false;
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "settings.png");
            imageList1.Images.SetKeyName(1, "task.png");
            imageList1.Images.SetKeyName(2, "user2.png");
            imageList1.Images.SetKeyName(3, "share32.png");
            // 
            // CategoryMenu
            // 
            CategoryMenu.ImageScalingSize = new Size(20, 20);
            CategoryMenu.Items.AddRange(new ToolStripItem[] { DeleteOption, NewCategoryOption });
            CategoryMenu.Name = "CategoryMenu";
            CategoryMenu.ShowImageMargin = false;
            CategoryMenu.Size = new Size(157, 52);
            CategoryMenu.Text = "Delete";
            // 
            // DeleteOption
            // 
            DeleteOption.Name = "DeleteOption";
            DeleteOption.Size = new Size(156, 24);
            DeleteOption.Text = "Delete selected";
            DeleteOption.Click += DeleteOption_Click;
            // 
            // NewCategoryOption
            // 
            NewCategoryOption.Name = "NewCategoryOption";
            NewCategoryOption.Size = new Size(156, 24);
            NewCategoryOption.Text = "Add category";
            NewCategoryOption.Click += NewCategoryOption_Click;
            // 
            // MessageTimer
            // 
            MessageTimer.Tick += MessageTimer_Tick;
            // 
            // ImportTasksDialog
            // 
            ImportTasksDialog.Filter = "JSON files (.json) | *.json";
            ImportTasksDialog.FileOk += ImportTasksDialog_FileOk;
            // 
            // ExportTasksDialog
            // 
            ExportTasksDialog.FileName = "Untitled";
            ExportTasksDialog.Filter = "JSON files (.json) | *.json";
            ExportTasksDialog.FileOk += ExportTasksDialog_FileOk;
            // 
            // DashboardForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1242, 734);
            Controls.Add(MainMenuControl);
            DrawerHighlightWithAccent = false;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = MainMenuControl;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1242, 734);
            MinimumSize = new Size(1242, 0);
            Name = "DashboardForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Management App";
            FormClosed += DashboardForm_FormClosed;
            MainMenuControl.ResumeLayout(false);
            TasksPage.ResumeLayout(false);
            TasksPage.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TasksList).EndInit();
            SharingsPage.ResumeLayout(false);
            SharingsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SharingsTable).EndInit();
            SettingsPage.ResumeLayout(false);
            SettingsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            UserPage.ResumeLayout(false);
            UserPage.PerformLayout();
            CategoryMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPage3;
        private TabPage tabPage4;
        private ReaLTaiizor.Controls.MaterialTabControl MainMenuControl;
        private TabPage TasksPage;
        private TabPage UserPage;
        private TabPage SettingsPage;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialButton LogoutButton;
        private ReaLTaiizor.Controls.MaterialButton NewTaskButton;
        public ReaLTaiizor.Controls.PoisonDataGridView TasksList;
        private ReaLTaiizor.Controls.MaterialButton RefreshButton;
        public ReaLTaiizor.Controls.MaterialLabel NoTasksLabel;
        private ReaLTaiizor.Controls.MaterialSwitch LoginStatusSwitch;
        private ContextMenuStrip CategoryMenu;
        private ToolStripMenuItem DeleteOption;
        private ToolStripMenuItem NewCategoryOption;
        public ReaLTaiizor.Controls.MaterialListBox CategoryBox;
        private ReaLTaiizor.Controls.AloneNotice aloneNotice1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialButton DeleteAccountButton;
        private ReaLTaiizor.Controls.MaterialButton RegisterButton;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit ConfirmPasswordTextBox;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit PasswordTextBox;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit EmailTextBox;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit UsernameTextBox;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit SurnameTextBox;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit NameTextBox;
        private TabPage SharingsPage;
        public ReaLTaiizor.Controls.PoisonDataGridView SharingsTable;
        private ReaLTaiizor.Controls.MaterialComboBox TasksComboBox;
        private ReaLTaiizor.Controls.MaterialButton ShareButton;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit ShareUsersBox;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Deadline;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Priority;
        private DataGridViewButtonColumn EditCol;
        private DataGridViewButtonColumn DeleteCol;
        private ReaLTaiizor.Controls.MaterialComboBox TasksIdComboBox;
        public ReaLTaiizor.Controls.MaterialLabel NoSharingsLabel;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private ReaLTaiizor.Controls.MaterialRadioButton BlueThemeRadioButton;
        private ReaLTaiizor.Controls.MaterialRadioButton GreenThemeRadioButton;
        private ReaLTaiizor.Controls.MaterialRadioButton RedThemeRadioButton;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialButton SaveSettingsButton;
        private PictureBox pictureBox7;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private System.Windows.Forms.Timer MessageTimer;
        private DataGridViewTextBoxColumn SharingIdCol;
        private DataGridViewTextBoxColumn TaskIdCol;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn SharedByCol;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewButtonColumn MoreCol;
        private DataGridViewButtonColumn DelSharingCol;
        private ReaLTaiizor.Controls.MaterialButton ExportButton;
        private ReaLTaiizor.Controls.MaterialButton ImportButton;
        private OpenFileDialog ImportTasksDialog;
        private SaveFileDialog ExportTasksDialog;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label AvTaskDurVal;
        private Label TasksThisMonthL;
        private ReaLTaiizor.Controls.MaterialProgressBar TasksCompletedProgBar;
    }
}
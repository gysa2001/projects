namespace quoridor_v2
{
    partial class Start
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
            label1 = new Label();
            HumanOption = new RadioButton();
            AIOption = new RadioButton();
            label2 = new Label();
            StartButton = new Button();
            QuitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(168, 48);
            label1.Name = "label1";
            label1.Size = new Size(164, 38);
            label1.TabIndex = 0;
            label1.Text = "\"Quoridor\"";
            // 
            // HumanOption
            // 
            HumanOption.AutoSize = true;
            HumanOption.Location = new Point(183, 146);
            HumanOption.Name = "HumanOption";
            HumanOption.Size = new Size(123, 24);
            HumanOption.TabIndex = 1;
            HumanOption.TabStop = true;
            HumanOption.Text = "Human player";
            HumanOption.UseVisualStyleBackColor = true;
            // 
            // AIOption
            // 
            AIOption.AutoSize = true;
            AIOption.Location = new Point(183, 176);
            AIOption.Name = "AIOption";
            AIOption.Size = new Size(89, 24);
            AIOption.TabIndex = 2;
            AIOption.TabStop = true;
            AIOption.Text = "AI player";
            AIOption.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(183, 109);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 3;
            label2.Text = "Choose opponent:";
            // 
            // StartButton
            // 
            StartButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartButton.Location = new Point(63, 225);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(187, 35);
            StartButton.TabIndex = 4;
            StartButton.Text = "Start game";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // QuitButton
            // 
            QuitButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuitButton.Location = new Point(256, 225);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(187, 35);
            QuitButton.TabIndex = 5;
            QuitButton.Text = "Quit game";
            QuitButton.UseVisualStyleBackColor = true;
            QuitButton.Click += button1_Click;
            // 
            // Start
            // 
            AcceptButton = StartButton;
            AccessibleRole = AccessibleRole.Dial;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 302);
            Controls.Add(QuitButton);
            Controls.Add(StartButton);
            Controls.Add(label2);
            Controls.Add(AIOption);
            Controls.Add(HumanOption);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Start";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quoridor";
            FormClosing += Start_FormClosing;
            FormClosed += Start_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton HumanOption;
        private RadioButton AIOption;
        private Label label2;
        private Button QuitButton;
        public Button StartButton;
    }
}
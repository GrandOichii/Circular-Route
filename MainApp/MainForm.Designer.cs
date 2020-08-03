namespace MainApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.PlayLabel = new System.Windows.Forms.Label();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.LanguageBox = new System.Windows.Forms.ComboBox();
            this.GoBackButton1 = new System.Windows.Forms.Button();
            this.GoBackButton2 = new System.Windows.Forms.Button();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.TutorialButton = new System.Windows.Forms.Button();
            this.PlayPanel = new System.Windows.Forms.Panel();
            this.DifficultyBox = new System.Windows.Forms.ComboBox();
            this.MainPanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.PlayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.QuitButton);
            this.MainPanel.Controls.Add(this.SettingsButton);
            this.MainPanel.Controls.Add(this.PlayButton);
            this.MainPanel.Controls.Add(this.TitleLabel);
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(391, 405);
            this.MainPanel.TabIndex = 0;
            // 
            // QuitButton
            // 
            this.QuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.QuitButton.Location = new System.Drawing.Point(116, 226);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(160, 34);
            this.QuitButton.TabIndex = 3;
            this.QuitButton.Text = "QUIT";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SettingsButton.Location = new System.Drawing.Point(116, 174);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(160, 35);
            this.SettingsButton.TabIndex = 2;
            this.SettingsButton.Text = "SETTINGS";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PlayButton.Location = new System.Drawing.Point(116, 122);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(160, 35);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "PLAY";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.TitleLabel.Location = new System.Drawing.Point(91, 25);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(223, 39);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Circular Route";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.SettingsLabel.Location = new System.Drawing.Point(91, 25);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(223, 39);
            this.SettingsLabel.TabIndex = 1;
            this.SettingsLabel.Text = "Settings";
            this.SettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayLabel
            // 
            this.PlayLabel.AutoSize = true;
            this.PlayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.PlayLabel.Location = new System.Drawing.Point(91, 25);
            this.PlayLabel.Name = "PlayLabel";
            this.PlayLabel.Size = new System.Drawing.Size(223, 39);
            this.PlayLabel.TabIndex = 0;
            this.PlayLabel.Text = "Circular Route";
            this.PlayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.SettingsLabel);
            this.SettingsPanel.Controls.Add(this.LanguageLabel);
            this.SettingsPanel.Controls.Add(this.LanguageBox);
            this.SettingsPanel.Controls.Add(this.GoBackButton1);
            this.SettingsPanel.Location = new System.Drawing.Point(12, 12);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(391, 405);
            this.SettingsPanel.TabIndex = 0;
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.BackColor = System.Drawing.Color.LightGray;
            this.LanguageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LanguageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LanguageLabel.Location = new System.Drawing.Point(86, 137);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(127, 46);
            this.LanguageLabel.TabIndex = 2;
            this.LanguageLabel.Text = "LANGUAGE";
            this.LanguageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LanguageBox
            // 
            this.LanguageBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.LanguageBox.Items.AddRange(new object[] {
            "RUS",
            "ENG"});
            this.LanguageBox.Location = new System.Drawing.Point(222, 141);
            this.LanguageBox.Name = "LanguageBox";
            this.LanguageBox.Size = new System.Drawing.Size(110, 37);
            this.LanguageBox.TabIndex = 3;
            this.LanguageBox.SelectedIndexChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // GoBackButton1
            // 
            this.GoBackButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.GoBackButton1.Location = new System.Drawing.Point(86, 211);
            this.GoBackButton1.Name = "GoBackButton1";
            this.GoBackButton1.Size = new System.Drawing.Size(246, 48);
            this.GoBackButton1.TabIndex = 0;
            this.GoBackButton1.Text = "GO BACK";
            this.GoBackButton1.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // GoBackButton2
            // 
            this.GoBackButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.GoBackButton2.Location = new System.Drawing.Point(116, 226);
            this.GoBackButton2.Name = "GoBackButton2";
            this.GoBackButton2.Size = new System.Drawing.Size(160, 35);
            this.GoBackButton2.TabIndex = 4;
            this.GoBackButton2.Text = "GO BACK";
            this.GoBackButton2.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // StartGameButton
            // 
            this.StartGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.StartGameButton.Location = new System.Drawing.Point(116, 122);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(100, 35);
            this.StartGameButton.TabIndex = 1;
            this.StartGameButton.Text = "START!";
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // TutorialButton
            // 
            this.TutorialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TutorialButton.Location = new System.Drawing.Point(116, 174);
            this.TutorialButton.Name = "TutorialButton";
            this.TutorialButton.Size = new System.Drawing.Size(160, 35);
            this.TutorialButton.TabIndex = 3;
            this.TutorialButton.Text = "HOW TO PLAY";
            this.TutorialButton.Click += new System.EventHandler(this.TutorialButton_Click);
            // 
            // PlayPanel
            // 
            this.PlayPanel.Controls.Add(this.PlayLabel);
            this.PlayPanel.Controls.Add(this.StartGameButton);
            this.PlayPanel.Controls.Add(this.DifficultyBox);
            this.PlayPanel.Controls.Add(this.TutorialButton);
            this.PlayPanel.Controls.Add(this.GoBackButton2);
            this.PlayPanel.Location = new System.Drawing.Point(12, 12);
            this.PlayPanel.Name = "PlayPanel";
            this.PlayPanel.Size = new System.Drawing.Size(391, 405);
            this.PlayPanel.TabIndex = 1;
            // 
            // DifficultyBox
            // 
            this.DifficultyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DifficultyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.DifficultyBox.Items.AddRange(new object[] {
            "6",
            "8"});
            this.DifficultyBox.Location = new System.Drawing.Point(222, 120);
            this.DifficultyBox.Name = "DifficultyBox";
            this.DifficultyBox.Size = new System.Drawing.Size(54, 37);
            this.DifficultyBox.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 429);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.PlayPanel);
            this.Name = "MainForm";
            this.Text = "CircularRoute";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.SettingsPanel.ResumeLayout(false);
            this.PlayPanel.ResumeLayout(false);
            this.PlayPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Panel PlayPanel;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.Label SettingsLabel;
        private System.Windows.Forms.Label PlayLabel;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button GoBackButton1;
        private System.Windows.Forms.Button GoBackButton2;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Button TutorialButton;
        private System.Windows.Forms.ComboBox DifficultyBox;
        private System.Windows.Forms.ComboBox LanguageBox;
    }
}


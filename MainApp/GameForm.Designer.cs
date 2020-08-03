namespace MainApp
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.TimerCounter = new System.Windows.Forms.Timer(this.components);
            this.CreateGridButton = new System.Windows.Forms.Button();
            this.LoadGridButton = new System.Windows.Forms.Button();
            this.RandomButton = new System.Windows.Forms.Button();
            this.ChangeNameButton = new System.Windows.Forms.Button();
            this.LeaderboardsButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.ControlTipLabel = new System.Windows.Forms.Label();
            this.DirPanel = new System.Windows.Forms.Panel();
            this.GridPanel = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelCreatingButton = new System.Windows.Forms.Button();
            this.CancelSolvingButton = new System.Windows.Forms.Button();
            this.GiveUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NameLabel.Location = new System.Drawing.Point(13, 13);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(62, 26);
            this.NameLabel.TabIndex = 13;
            this.NameLabel.Text = "label1";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerLabel
            // 
            this.TimerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TimerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TimerLabel.Location = new System.Drawing.Point(244, 13);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(200, 26);
            this.TimerLabel.TabIndex = 12;
            this.TimerLabel.Text = "label1";
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimerCounter
            // 
            this.TimerCounter.Tick += new System.EventHandler(this.TimerCounter_Tick);
            // 
            // CreateGridButton
            // 
            this.CreateGridButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CreateGridButton.Location = new System.Drawing.Point(656, 13);
            this.CreateGridButton.Name = "CreateGridButton";
            this.CreateGridButton.Size = new System.Drawing.Size(132, 43);
            this.CreateGridButton.TabIndex = 11;
            this.CreateGridButton.Text = "Create yout grid";
            this.CreateGridButton.UseVisualStyleBackColor = true;
            this.CreateGridButton.Click += new System.EventHandler(this.CreateGridButton_Click);
            // 
            // LoadGridButton
            // 
            this.LoadGridButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LoadGridButton.Location = new System.Drawing.Point(656, 62);
            this.LoadGridButton.Name = "LoadGridButton";
            this.LoadGridButton.Size = new System.Drawing.Size(132, 43);
            this.LoadGridButton.TabIndex = 10;
            this.LoadGridButton.Text = "Load";
            this.LoadGridButton.UseVisualStyleBackColor = true;
            this.LoadGridButton.Click += new System.EventHandler(this.LoadGridButton_Click);
            // 
            // RandomButton
            // 
            this.RandomButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RandomButton.Location = new System.Drawing.Point(656, 111);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(132, 43);
            this.RandomButton.TabIndex = 9;
            this.RandomButton.Text = "Solve Random";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // ChangeNameButton
            // 
            this.ChangeNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeNameButton.Location = new System.Drawing.Point(656, 206);
            this.ChangeNameButton.Name = "ChangeNameButton";
            this.ChangeNameButton.Size = new System.Drawing.Size(132, 43);
            this.ChangeNameButton.TabIndex = 8;
            this.ChangeNameButton.Text = "Change Name";
            this.ChangeNameButton.UseVisualStyleBackColor = true;
            this.ChangeNameButton.Click += new System.EventHandler(this.ChangeNameButton_Click);
            // 
            // LeaderboardsButton
            // 
            this.LeaderboardsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LeaderboardsButton.Location = new System.Drawing.Point(656, 255);
            this.LeaderboardsButton.Name = "LeaderboardsButton";
            this.LeaderboardsButton.Size = new System.Drawing.Size(132, 43);
            this.LeaderboardsButton.TabIndex = 7;
            this.LeaderboardsButton.Text = "Leaderboards";
            this.LeaderboardsButton.UseVisualStyleBackColor = true;
            this.LeaderboardsButton.Click += new System.EventHandler(this.LeaderboardsButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(656, 357);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(132, 43);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // UpButton
            // 
            this.UpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.UpButton.Location = new System.Drawing.Point(440, 239);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(63, 63);
            this.UpButton.TabIndex = 4;
            this.UpButton.Text = "🠕";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LeftButton.Location = new System.Drawing.Point(371, 299);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(63, 63);
            this.LeftButton.TabIndex = 3;
            this.LeftButton.Text = "🠔";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.RightButton.Location = new System.Drawing.Point(509, 299);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(63, 63);
            this.RightButton.TabIndex = 2;
            this.RightButton.Text = "🠖";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DownButton.Location = new System.Drawing.Point(440, 357);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(63, 63);
            this.DownButton.TabIndex = 1;
            this.DownButton.Text = "🠗";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // ControlTipLabel
            // 
            this.ControlTipLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlTipLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ControlTipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ControlTipLabel.Location = new System.Drawing.Point(316, 52);
            this.ControlTipLabel.Name = "ControlTipLabel";
            this.ControlTipLabel.Size = new System.Drawing.Size(334, 172);
            this.ControlTipLabel.TabIndex = 0;
            this.ControlTipLabel.Text = "Cotrol tip:\r\nLOL";
            // 
            // DirPanel
            // 
            this.DirPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DirPanel.Location = new System.Drawing.Point(12, 52);
            this.DirPanel.Name = "DirPanel";
            this.DirPanel.Size = new System.Drawing.Size(297, 297);
            this.DirPanel.TabIndex = 17;
            // 
            // GridPanel
            // 
            this.GridPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GridPanel.Location = new System.Drawing.Point(12, 52);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(297, 297);
            this.GridPanel.TabIndex = 18;
            this.GridPanel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GridPanel_PreviewKeyDown);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveButton.Location = new System.Drawing.Point(13, 377);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(132, 43);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelCreatingButton
            // 
            this.CancelCreatingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelCreatingButton.Location = new System.Drawing.Point(177, 377);
            this.CancelCreatingButton.Name = "CancelCreatingButton";
            this.CancelCreatingButton.Size = new System.Drawing.Size(132, 43);
            this.CancelCreatingButton.TabIndex = 16;
            this.CancelCreatingButton.Text = "Cancel";
            this.CancelCreatingButton.UseVisualStyleBackColor = true;
            this.CancelCreatingButton.Click += new System.EventHandler(this.CancelCreatingButton_Click);
            // 
            // CancelSolvingButton
            // 
            this.CancelSolvingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelSolvingButton.Location = new System.Drawing.Point(177, 377);
            this.CancelSolvingButton.Name = "CancelSolvingButton";
            this.CancelSolvingButton.Size = new System.Drawing.Size(132, 43);
            this.CancelSolvingButton.TabIndex = 19;
            this.CancelSolvingButton.Text = "Cancel";
            this.CancelSolvingButton.UseVisualStyleBackColor = true;
            this.CancelSolvingButton.Click += new System.EventHandler(this.CancelSolvingButton_Click);
            // 
            // GiveUpButton
            // 
            this.GiveUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GiveUpButton.Location = new System.Drawing.Point(13, 377);
            this.GiveUpButton.Name = "GiveUpButton";
            this.GiveUpButton.Size = new System.Drawing.Size(132, 43);
            this.GiveUpButton.TabIndex = 20;
            this.GiveUpButton.Text = "Give up";
            this.GiveUpButton.Click += new System.EventHandler(this.GiveUpButton_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelSolvingButton);
            this.Controls.Add(this.CancelCreatingButton);
            this.Controls.Add(this.GiveUpButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DirPanel);
            this.Controls.Add(this.GridPanel);
            this.Controls.Add(this.ControlTipLabel);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.LeaderboardsButton);
            this.Controls.Add(this.ChangeNameButton);
            this.Controls.Add(this.RandomButton);
            this.Controls.Add(this.LoadGridButton);
            this.Controls.Add(this.CreateGridButton);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "GameForm";
            this.Text = "Circular Route";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Timer TimerCounter;
        private System.Windows.Forms.Button CreateGridButton;
        private System.Windows.Forms.Button LoadGridButton;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.Button ChangeNameButton;
        private System.Windows.Forms.Button LeaderboardsButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Label ControlTipLabel;
        private System.Windows.Forms.Panel DirPanel;
        private System.Windows.Forms.Panel GridPanel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelCreatingButton;
        private System.Windows.Forms.Button CancelSolvingButton;
        private System.Windows.Forms.Button GiveUpButton;
    }
}
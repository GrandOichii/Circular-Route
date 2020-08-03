namespace MainApp
{
    partial class TutorialForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.RulesImage = new System.Windows.Forms.PictureBox();
            this.RulesText = new System.Windows.Forms.RichTextBox();
            this.NextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RulesImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.TitleLabel.Location = new System.Drawing.Point(143, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(135, 41);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Tutorial";
            // 
            // RulesImage
            // 
            this.RulesImage.Location = new System.Drawing.Point(22, 73);
            this.RulesImage.Name = "RulesImage";
            this.RulesImage.Size = new System.Drawing.Size(200, 200);
            this.RulesImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RulesImage.TabIndex = 1;
            this.RulesImage.TabStop = false;
            // 
            // RulesText
            // 
            this.RulesText.Enabled = false;
            this.RulesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.RulesText.Location = new System.Drawing.Point(228, 73);
            this.RulesText.Name = "RulesText";
            this.RulesText.Size = new System.Drawing.Size(194, 200);
            this.RulesText.TabIndex = 2;
            this.RulesText.Text = "";
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NextButton.Location = new System.Drawing.Point(143, 302);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(135, 49);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // TutorialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 380);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.RulesText);
            this.Controls.Add(this.RulesImage);
            this.Controls.Add(this.TitleLabel);
            this.Name = "TutorialForm";
            this.Text = "Circular Route Tutorial";
            ((System.ComponentModel.ISupportInitialize)(this.RulesImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox RulesImage;
        private System.Windows.Forms.RichTextBox RulesText;
        private System.Windows.Forms.Button NextButton;
    }
}
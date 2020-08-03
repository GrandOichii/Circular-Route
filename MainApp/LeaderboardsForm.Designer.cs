namespace MainApp
{
    partial class LeaderboardsForm
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
            this.LeaderData6 = new System.Windows.Forms.DataGridView();
            this.LeaderData8 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.LeaderData6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeaderData8)).BeginInit();
            this.SuspendLayout();
            // 
            // LeaderData6
            // 
            this.LeaderData6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeaderData6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LeaderData6.Location = new System.Drawing.Point(13, 13);
            this.LeaderData6.Name = "LeaderData6";
            this.LeaderData6.Size = new System.Drawing.Size(775, 221);
            this.LeaderData6.TabIndex = 0;
            // 
            // LeaderData8
            // 
            this.LeaderData8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeaderData8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LeaderData8.Location = new System.Drawing.Point(13, 240);
            this.LeaderData8.Name = "LeaderData8";
            this.LeaderData8.Size = new System.Drawing.Size(775, 221);
            this.LeaderData8.TabIndex = 1;
            // 
            // LeaderboardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.LeaderData8);
            this.Controls.Add(this.LeaderData6);
            this.Name = "LeaderboardsForm";
            this.Text = "Leaderboards";
            ((System.ComponentModel.ISupportInitialize)(this.LeaderData6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeaderData8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView LeaderData6;
        private System.Windows.Forms.DataGridView LeaderData8;
    }
}
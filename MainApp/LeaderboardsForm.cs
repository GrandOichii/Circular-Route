using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CRLib;

namespace MainApp
{
    public partial class LeaderboardsForm : Form
    {
        List<PlayerInfo> info6;
        List<PlayerInfo> info8;
        public LeaderboardsForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }
        /// <summary>
        /// Initializes the form
        /// </summary>
        /// <param name="info6">The infotrmation on the top 8 times for side 6</param>
        /// <param name="info8">The infotrmation on the top 8 times for side 8</param>
        public void Initialize(List<PlayerInfo> info6, List<PlayerInfo> info8)
        {
            CenterToScreen();

            this.info6 = info6;
            this.info8 = info8;
    
            SetUpDataGridViews();

            ShowDialog();
        }
        /// <summary>
        /// Sets the DataGridView elements
        /// </summary>
        private void SetUpDataGridViews()
        {
            LeaderData6.Rows.Clear();
            LeaderData6.ReadOnly = true;
            LeaderData6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LeaderData6.ColumnCount = 3;
            LeaderData6.Columns[0].Name = "Name";
            LeaderData6.Columns[1].Name = "Side";
            LeaderData6.Columns[2].Name = "Time";
            foreach (var player in info6)
                LeaderData6.Rows.Add(new string[] { player.Name, player.Side.ToString(), $"{player.Time:F2}"});

            LeaderData8.Rows.Clear();
            LeaderData8.ReadOnly = true;
            LeaderData8.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LeaderData8.ColumnCount = 3;
            LeaderData8.Columns[0].Name = "Name";
            LeaderData8.Columns[1].Name = "Side";
            LeaderData8.Columns[2].Name = "Time";
            foreach (var player in info8)
                LeaderData8.Rows.Add(new string[] { player.Name, player.Side.ToString(), $"{player.Time:F2}"});
        }
    }
}

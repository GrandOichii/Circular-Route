using System;
using System.ComponentModel;
using System.Media;
using System.Drawing;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CRLib;

namespace MainApp
{
    public partial class GameForm : Form
    {
        #region Static Values
        private static readonly string leaderboards6Path = "lead6.bin";
        private static readonly string leaderboards8Path = "lead8.bin";
        #endregion
        #region Values
        private NameForm NameForm;
        private LeaderboardsForm leaderForm;
        private FormsCRGrid gridIm;
        private PictureBox[,] picGrid;
        private PictureBox[,] picDir;
        private List<PlayerInfo> leaders6;
        private List<PlayerInfo> leaders8;
        private bool russian;
        private bool gameActive;
        private string playerName;
        private int side;
        private double ticks;
        private bool editingOn;
        #endregion
        #region Constructors
        public GameForm()
        {
            InitializeComponent();
            playerName = Environment.UserName;
            NameForm = new NameForm();
            leaderForm = new LeaderboardsForm();
            FormClosing += GameForm_Closing;
        }
        #endregion
        #region Public Methods
        /// <summary>
        /// Initializes the form
        /// </summary>
        /// <param name="side">The side of the grid</param>
        /// <param name="russian">True if the text should be in russian</param>
        public void Initialize(int side, bool russian)
        {
            CenterToScreen();

            gameActive = false;
            editingOn = false;
            SetSideButtonsEnabled(true);

            this.russian = russian;
            this.side = side;
            ResetTimer();

            if (side == 6)
                Size = new Size(816 + 10, 489 + 10);
            else Size = new Size(926 + 10, 579 + 10);

            UpdateName();

            if (russian)
            {
                CreateGridButton.Text = "Создать свое поле";
                LoadGridButton.Text = "Загрузить";
                RandomButton.Text = "Случайное поле";
                ChangeNameButton.Text = "Поменять имя";
                LeaderboardsButton.Text = "Рекорды";
                CloseButton.Text = "Закрыть";
                ControlTipLabel.Text = "Подсказка управления:\nВы можете использовать кнопки направления на вашей клавиатуре или кнопки снизу чтобы выстраивать ваш маршрут.";
                GiveUpButton.Text = "Сдаться";
                CancelSolvingButton.Text = "Отмена";
            }
            else
            {
                CreateGridButton.Text = "Create your grid";
                LoadGridButton.Text = "Load";
                RandomButton.Text = "Solve random";
                ChangeNameButton.Text = "Change Name";
                LeaderboardsButton.Text = "Leaderoards";
                CloseButton.Text = "Close";
                ControlTipLabel.Text = "Control tip:\nYou can use the arrow keys on your keyboard or the arrow buttons down below to navigate your route.";
                GiveUpButton.Text = "Give up";
                CancelSolvingButton.Text = "Cancel";
            }

            

            try
            {
                leaders6 = PlayerInfo.Load(leaderboards6Path);
            }
            catch (IOException)
            {
                leaders6 = new List<PlayerInfo>
                {
                    new PlayerInfo("Bob", 6, 300)
                };
                PlayerInfo.Save(leaders6, leaderboards6Path);
            }

            try
            {
                leaders8 = PlayerInfo.Load(leaderboards8Path);
            }
            catch (IOException)
            {
                leaders8 = new List<PlayerInfo>
                {
                    new PlayerInfo("Bob", 8, 600)
                };
                PlayerInfo.Save(leaders8, leaderboards8Path);
            }


            SetArrowButtonsEnabled(false);

            SaveButton.Hide();
            CancelCreatingButton.Hide();
            CancelSolvingButton.Hide();
            GiveUpButton.Hide();


            FillPanel();
            ShowDialog();
        }
        #endregion
        #region Methods
        /// <summary>
        /// Sets the enabled property of the arrow arrows
        /// </summary>
        /// <param name="value">True if the arrow buttons should be enabled</param>
        private void SetArrowButtonsEnabled(bool value)
        {
            UpButton.Enabled = value;
            DownButton.Enabled = value;
            LeftButton.Enabled = value;
            RightButton.Enabled = value;
        }
        /// <summary>
        /// Sets the enabled property of the side arrows
        /// </summary>
        /// <param name="value">True if the side buttons should be enabled</param>
        private void SetSideButtonsEnabled(bool value)
        {
            CreateGridButton.Enabled = value;
            LoadGridButton.Enabled = value;
            RandomButton.Enabled = value;
            ChangeNameButton.Enabled = value;
            LeaderboardsButton.Enabled = value;
        }
        /// <summary>
        /// Updates the name label
        /// </summary>
        private void UpdateName()
        {
            string text = russian ? "Ваше имя" : "Your name";
            NameLabel.Text = $"{text}: {playerName}";
        }
        /// <summary>
        /// Updates the timer label
        /// </summary>
        private void UpdateTimer()
        {
            string text = russian ? "Таймер" : "Timer";
            TimerLabel.Text = $"{text}: {ticks}";
        }
        /// <summary>
        /// Resets the timer
        /// </summary>
        /// <returns>Returns the time on the timer</returns>
        private double ResetTimer()
        {
            double time = ticks;
            ticks = 0;
            TimerCounter.Enabled = false;
            UpdateTimer();
            return time;
        }
        /// <summary>
        /// Fills the grid and the direction panels
        /// </summary>
        private void FillPanel()
        {
            gridIm = new FormsCRGrid(side);

            // =====================direction part======================
            DirPanel.Size = new Size(51 * side + 1, 51 * side + 1);
            DirPanel.Controls.Clear();

            FillPicDir();
            for (int i = 0; i < side; i++)
                for (int j = 0; j < side; j++)
                    DirPanel.Controls.Add(picDir[i, j]);


            // =======================grid part=========================
            GridPanel.Size = new Size(51 * side + 1, 51 * side + 1);
            GridPanel.Controls.Clear();

            FillPicGrid();
            for (int i = 0; i < side; i++)
                for (int j = 0; j < side; j++)
                    GridPanel.Controls.Add(picGrid[i, j]);
            DirPanel.BringToFront();
        }
        /// <summary>
        /// Resets and updates the dir panel, then brings it to front
        /// </summary>
        private void ResetPicDir()
        {
            gridIm.CleanDirections();
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    picDir[i, j].Image = gridIm.GetDirPic(i, j);
                }
            }
            DirPanel.BringToFront();
        }
        /// <summary>
        /// Fills the direction pictures array
        /// </summary>
        private void FillPicDir()
        {
            picDir = new PictureBox[side, side];
            for (int i = 0; i < side; i++)
                for (int j = 0; j < side; j++)
                {
                    picDir[i, j] = new PictureBox()
                    {
                        Size = new Size(50, 50),
                        BorderStyle = BorderStyle.FixedSingle,
                        Location = new Point(j * 51, i * 51),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Image = gridIm.GetDirPic(i, j)
                    };
                    int ti = i, tj = j;
                    picDir[i, j].Click += delegate
                    {
                        if (editingOn)
                        {
                            gridIm.Directions[ti, tj] = (gridIm.Directions[ti, tj] + 1) % 3;
                            picDir[ti, tj].Image = gridIm.GetDirPic(ti, tj);
                        }
                    };
                }
        }
        /// <summary>
        /// Fills the grid pictures array
        /// </summary>
        private void FillPicGrid()
        {
            picGrid = new PictureBox[side, side];
            for (int i = 0; i < side; i++)
                for (int j = 0; j < side; j++)
                {
                    picGrid[i, j] = new PictureBox()
                    {
                        Size = new Size(50, 50),
                        BorderStyle = BorderStyle.FixedSingle,
                        Location = new Point(j * 51, i * 51),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Image = i == 0 && j == 0 ? FormsCRGrid.GetGridImage(14, 0) : FormsCRGrid.GetGridImage(0, 0)
                    };
                }
        }
        /// <summary>
        /// Updates the grid panel
        /// </summary>
        private void UpdateGridPanel()
        {
            for (int i = 0; i < side; i++)
                for (int j = 0; j < side; j++)
                    picGrid[i, j].Image = gridIm.GetGridPic(i, j);
        }
        /// <summary>
        /// Finishes the game
        /// </summary>
        /// <param name="won"></param>
        private void FinishGame(bool won)
        {
            double time = ResetTimer();
            if (gameActive && won) 
            {
                var result = MessageBox.Show(russian ? $"Вы нашли путь!\nВаше время: {time:F1}\nХотите сохранить ваш результат?" : $"You found the route!\nYour time: {time:F1}\nDo you wish to save your result?", "Circular Route", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SaveResult(time);
                }
            }
            if (!won)
            {
                // play the loss sound effect
                MessageBox.Show(russian ? "Вы проиграли! Удачи в следующий раз..." : "You lost! Better luck next time...", "Circular Route");
            }
            gameActive = false;
            UpdateTimer();
            SetArrowButtonsEnabled(false);
            ResetPicDir();
            SetSideButtonsEnabled(true);
            CancelSolvingButton.Hide();
            GiveUpButton.Hide();
        }

        private void BeginSolving()
        {
            gridIm.ResetPos();
            gridIm.Grid[0, 0] = 41;

            editingOn = true;
            SetSideButtonsEnabled(false);

            UpdateGridPanel();

            CancelSolvingButton.Show();
            GiveUpButton.Show();
            GridPanel.BringToFront();

            SetArrowButtonsEnabled(true);

            GridPanel.Focus();

            TimerCounter.Enabled = true;
        }

        private void SaveResult(double time)
        {
            if (side == 6)
            {
                leaders6.Add(new PlayerInfo(playerName, side, time));
                leaders6.Sort((p1, p2) => p1.Time.CompareTo(p2.Time));
                if (leaders6.Count > 8)
                    leaders6 = leaders6.GetRange(0, 8);
                PlayerInfo.Save(leaders6, leaderboards6Path);
            }
            if (side == 8)
            {
                leaders8.Add(new PlayerInfo(playerName, side, time));
                leaders8.Sort((p1, p2) => p1.Time.CompareTo(p2.Time));
                if (leaders8.Count > 8)
                    leaders8 = leaders6.GetRange(0, 8);
                PlayerInfo.Save(leaders8, leaderboards8Path);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Right) || (keyData == Keys.Left) ||
                (keyData == Keys.Up) || (keyData == Keys.Down))
            {
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private async void GiveUpAsync()
        {
            editingOn = false;
            if (MessageBox.Show(russian ? "Вы уверены, что хотите сдаться?" : "Are you sure you want to give up?", "Circular Route", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gameActive = false;
                ResetTimer();
                SetArrowButtonsEnabled(false);

                bool res = false;
                GiveUpButton.Text = "Solving";
                GiveUpButton.Enabled = false;
                gridIm.SolvingAllowed = true;

                await Task.Run(() =>
                {
                    res = gridIm.Solve();
                });
                if (gridIm.SolvingAllowed)
                {
                    UpdateGridPanel();

                    if (!res)
                    {
                        MessageBox.Show(russian ? "Данную сетку невозможно решить" : "This grid is unsolvable", "Circular Route");
                    }
                    GiveUpButton.Text = "Give up";
                    GiveUpButton.Enabled = true;

                    FinishGame(false);
                }
            }
        }

        private async void GenerateRandomAsync()
        {
            RandomButton.Text = russian ? "Генерирую..." : "Generating...";
            RandomButton.Enabled = false;
            gridIm.SolvingAllowed = true;
            SetSideButtonsEnabled(false);
            await Task.Run(() =>
            {
                gridIm.RandomizeDir();
            });
            RandomButton.Text = russian ? "Случайный" : "Solve Random";
            RandomButton.Enabled = true;
            gridIm.CleanGrid();
            gameActive = true;
            BeginSolving();
        }

        private async void SaveAsync()
        {
            bool res = false;
            editingOn = false;
            SaveButton.Text = "Solving";
            SaveButton.Enabled = false;
            gridIm.SolvingAllowed = true;

            await Task.Run(() =>
            {
                res = gridIm.Solve();
            });

            if (gridIm.SolvingAllowed)
            {
                if (!res)
                {
                    MessageBox.Show(russian ? "Данную сетку невозможно решить" : "This grid is unsolvable", "Circular Route");
                    editingOn = true;
                    SaveButton.Text = "Save";
                    SaveButton.Enabled = true;
                    return;
                }
                GridPanel.BringToFront();
                UpdateGridPanel();

                using (SaveFileDialog sf = new SaveFileDialog())
                {
                    sf.FileName = "grid";
                    sf.Filter = "Grid direction file (*.crdir)|*.crdir";
                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        gridIm.SaveDirections(sf.FileName);
                        MessageBox.Show(russian ? "Сохранено!" : "Saved", "Circular Route");
                        editingOn = false;
                        SetSideButtonsEnabled(true);

                        SaveButton.Hide();
                        CancelCreatingButton.Hide();

                        ResetPicDir();
                    }
                    else
                    {
                        DirPanel.BringToFront();
                        editingOn = true;
                    }
                    SaveButton.Text = "Save";
                    SaveButton.Enabled = true;
                }
            }
        }

        #endregion
        #region Handlers
        private void ChangeNameButton_Click(object sender, EventArgs e)
        {
            NameForm.Initialize(playerName, russian);
            if (NameForm.Changed)
                playerName = NameForm.PlayerName;
            UpdateName();
        }

        private void CreateGridButton_Click(object sender, EventArgs e)
        {
            editingOn = true;
            SetSideButtonsEnabled(false);

            SaveButton.Show();
            CancelCreatingButton.Show();

            ResetPicDir();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TimerCounter_Tick(object sender, EventArgs e)
        {
            ticks += 0.1;
            string text = russian ? "Таймер" : "Timer";
            TimerLabel.Text = $"{text}: {ticks:F1}";
        }

        private void GameForm_Closing(object sender, CancelEventArgs e)
        {
            TimerCounter.Stop();
        }

        private void CancelCreatingButton_Click(object sender, EventArgs e)
        {
            gridIm.SolvingAllowed = false;
            editingOn = false;
            SetSideButtonsEnabled(true);
            SaveButton.Hide();
            CancelCreatingButton.Hide();
            SaveButton.Text = "Save";
            SaveButton.Enabled = true;
            ResetPicDir();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveAsync();
        }

        private void LoadGridButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "Grid direction file (*.crdir)|*.crdir";
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    gameActive = true;
                    try 
                    {
                        gridIm.LoadDirections(fd.FileName, side);
                        gridIm.CleanGrid();
                        

                        BeginSolving();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(russian ? "Неправильный размер решетки" : "Incorrect grid size", "Circular route");
                        SetSideButtonsEnabled(true);
                        gameActive = false;
                        return;
                    }
                }
            }
        }

        private void CancelSolvingButton_Click(object sender, EventArgs e)
        {
            gridIm.SolvingAllowed = false;
            CancelSolvingButton.Hide();
            GiveUpButton.Hide();
            ResetTimer();
            SetArrowButtonsEnabled(false);
            SetSideButtonsEnabled(true);
            GiveUpButton.Text = "Give up";
            GiveUpButton.Enabled = true;
            ResetPicDir();
        }

        private void GridPanel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            GridPanel.Focus();
            if (gameActive)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        UpButton_Click(this, EventArgs.Empty);
                        break;
                    case Keys.Down:
                        DownButton_Click(this, EventArgs.Empty);
                        break;
                    case Keys.Left:
                        LeftButton_Click(this, EventArgs.Empty);
                        break;
                    case Keys.Right:
                        RightButton_Click(this, EventArgs.Empty);
                        break;
                }
            }
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            bool res = gridIm.GoUp();
            UpdateGridPanel();
            if (res)
            {
                FinishGame(true);
                return;
            }
                
            GridPanel.Focus();
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            bool res = gridIm.GoLeft();
            UpdateGridPanel();
            if (res)
            {
                FinishGame(true);
                return;
            }
            GridPanel.Focus();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            gridIm.GoRight();
            UpdateGridPanel();
            GridPanel.Focus();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            gridIm.GoDown();
            UpdateGridPanel();
            GridPanel.Focus();
        }

        private void GiveUpButton_Click(object sender, EventArgs e)
        {
            GiveUpAsync();
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            GenerateRandomAsync();
        }

        private void LeaderboardsButton_Click(object sender, EventArgs e)
        {
            leaderForm.Initialize(leaders6, leaders8);
        }
        #endregion
    }
}

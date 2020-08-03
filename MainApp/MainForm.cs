using System;
using System.Media;
using System.Drawing;
using System.Windows.Forms;
namespace MainApp
{
    public partial class MainForm : Form
    {
        #region Properties
        private bool Russian
        {
            get
            {
                if (LanguageBox.Text == "RUS")
                    return true;
                return false;
            }
        }
        #endregion
        #region Static Values
        static SoundPlayer clickSound;
        static readonly string clickSoundPath = "sfx/Windows Default.wav";
        #endregion
        #region Values
        private TutorialForm DemoForm;
        private GameForm GameForm;
        #endregion
        #region Constructors
        public MainForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            DifficultyBox.Text = "6";
            LanguageBox.Text = "ENG";
            MainPanel.BackgroundImage = new Bitmap("images/background.jpg");
            MainPanel.BackgroundImageLayout = ImageLayout.Stretch;

            PlayPanel.BackgroundImage = new Bitmap("images/background.jpg");
            PlayPanel.BackgroundImageLayout = ImageLayout.Stretch;

            SettingsPanel.BackgroundImage = new Bitmap("images/background.jpg");
            SettingsPanel.BackgroundImageLayout = ImageLayout.Stretch;


            clickSound = new SoundPlayer(clickSoundPath);
            DemoForm = new TutorialForm();
            GameForm = new GameForm();
            CenterToScreen();
            MainPanel.Show();
        }
        #endregion
        #region Handlers
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            MainPanel.Hide();
            PlayPanel.Hide();
            SettingsPanel.Show();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            SettingsPanel.Hide();
            PlayPanel.Hide();
            MainPanel.Show();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            MainPanel.Hide();
            SettingsPanel.Hide();
            PlayPanel.Show();
        }

        private void TutorialButton_Click(object sender, EventArgs e)
        {
            DemoForm.Initialize(Russian);
        }

        private void SettingsChanged(object sender, EventArgs e)
        {
            if (Russian)
            {
                LanguageLabel.Text = "ЯЗЫК";
                QuitButton.Text = "ВЫЙТИ";
                SettingsButton.Text = "НАСТРОЙКИ";
                PlayButton.Text = "ИГРАТЬ";
                TitleLabel.Text = "Кольцевой Маршрут";
                TitleLabel.Font = new Font("Microsoft Sans Serif", 16F);
                SettingsLabel.Text = "Настройки";
                PlayLabel.Text = "Кольцевой Маршрут";
                PlayLabel.Font = new Font("Microsoft Sans Serif", 16F);
                GoBackButton1.Text = "НАЗАД";
                GoBackButton2.Text = "НАЗАД";
                StartGameButton.Text = "НАЧАТЬ!";
                TutorialButton.Text = "КАК ИГРАТЬ";
            }
            else
            {
                LanguageLabel.Text = "LANGUAGE";
                QuitButton.Text = "QUIT";
                SettingsButton.Text = "SETTINGS";
                PlayButton.Text = "PLAY";
                TitleLabel.Text = "Circular Route";
                TitleLabel.Font = new Font("Microsoft Sans Serif", 24F);
                SettingsLabel.Text = "Settings";
                PlayLabel.Text = "Circular Route";
                PlayLabel.Font = new Font("Microsoft Sans Serif", 24F);
                GoBackButton1.Text = "GO BACK";
                GoBackButton2.Text = "GO BACK";
                StartGameButton.Text = "START";
                TutorialButton.Text = "HOW TO PLAY";
            }
        }

        private void PlaySound(object sender, EventArgs e)
        {
            clickSound.Play();
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            Hide();
            GameForm.Initialize(int.Parse(DifficultyBox.Text), Russian);
            Show();
        }
        #endregion
    }
}

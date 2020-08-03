using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainApp
{
    public partial class NameForm : Form
    {
        bool russian;
        public bool Changed { get; private set; }
        public string PlayerName { get => NameText.Text; }
        public NameForm()
        {
            InitializeComponent();
            NameText.KeyDown += NameForm_KeyDown;
        }

        private void NameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SaveButton_Click(this, EventArgs.Empty);
        }
        /// <summary>
        /// Initializes the form
        /// </summary>
        /// <param name="originalName">Player's original name</param>
        /// <param name="russian">True if language is russian</param>
        public void Initialize(string originalName, bool russian)
        {
            Changed = false;
            NameText.Text = originalName;
            this.russian = russian;

            if (russian)
            {
                TitleLabel.Text = "Введите имя";
                TitleLabel.Location = new Point(37, 13);
                SaveButton.Text = "Сохранить";
                CButton.Text = "Отмена";
            }
            else
            {
                TitleLabel.Text = "Change your name";
                TitleLabel.Location = new Point(13, 13);
                SaveButton.Text = "Save";
                CButton.Text = "Cancel";
            }

            CenterToScreen();
            ShowDialog();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (NameText.Text != "")
            {
                Changed = true;
                Close();
            }
            else MessageBox.Show(russian ? "Имя не может быть пустым!" : "Name can't be empty!", "Circular route");
        }
    }
}

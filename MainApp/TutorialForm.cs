using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainApp
{
    public partial class TutorialForm : Form
    {
        int state;
        bool russian;
        static readonly string imagesPath = @"tutorial\";
        static readonly string rulesText1_Rus = "Необходимо продолжить \"кольцевой\"(замкнутый) маршрут по игровому " +
            "полю так, чтобы посетить каждую ячейку. Перемещаться можно только по горизонтали и по вертикали.";
        static readonly string rulesText1_Eng = "You have to continue the \"circular\"(closed) route on the grid " +
            ", so that it crosses every cell. You can move only horizontally and vertically.";
        static readonly string rulesText2_Rus = "Серые ячейки являются своеобразными указателями: в светло-серых " +
            "ячейках следует повернуть на девяносто градусов, в темно-серых - продолжить путь прямо.";
        static readonly string rulesText2_Eng = "Gray cells are sort of pointers: when crossing light gray cells " +
            "you HAVE to turn right or left, in dark gray cells you can\'t turn.";

        public TutorialForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
        }

        public void Initialize(bool russian)
        {
            this.russian = russian;
            CenterToScreen();
            state = 1;
            NextButton.Text = "Next";
            if (russian)
            {
                TitleLabel.Text = "Как Играть";
                NextButton.Text = "Дальше";
                RulesText.Text = rulesText1_Rus;
            }
            else
            {
                TitleLabel.Text = "How to Play";
                NextButton.Text = "Next";
                RulesText.Text = rulesText1_Eng;
            }

            RulesImage.Image = new Bitmap(string.Concat(imagesPath, "tutorial1.jpg"));
            ShowDialog();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                NextButton.Text = russian ? "Выйти" : "Quit";
                if (russian)
                    RulesText.Text = rulesText2_Rus;
                else RulesText.Text = rulesText2_Eng;
                RulesImage.Image = new Bitmap(imagesPath + "tutorial2.jpg");
                ++state;
                return;
            }
            Close();
        }
    }
}

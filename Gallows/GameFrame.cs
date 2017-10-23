using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gallows
{
    public partial class GameFrame : Form
    {
        //Уровень сложности
        LevelDifficulty levelDif;
        //Имя игрока
        string name;
        //Квествовое слово
        string questWord;
        //Счётчик ошибок при выборе буквы
        public int countError;
        int countWin;
        //Сколько букв угадано. Для победы countWin == guessedLetters
        int guessedLetters;
        //Коллекция которая хранит ссылки на texBox которые отображат questWord
        public readonly List<TextBox> listBoxLetters = new List<TextBox>();

        public float scale = 0.1F;
        public int scale_c = 0;
        public bool bboool = true;
        public string str;

        public GameFrame(LevelDifficulty levelDif, string name, string questWord)
        {
            this.levelDif = levelDif;
            this.name = name;
            this.questWord = questWord;

            DrawWord();
            InitializeComponent();

            countError = 0;
            //Счётчик сколько надо угадать слов, кроме первых 2 открытых
            countWin = questWord.Length;
            guessedLetters = 0;

        }
        #region Отрисовка слова и отдельных букв
        //Отрисовака всего слова в начале игры
        private void DrawWord()
        {
            Point point = new Point();
            switch (levelDif)
            {
                case LevelDifficulty.Easy:
                    {
                        point = new Point(580, 75);
                        break;
                    }
                case LevelDifficulty.Normal:
                    {
                        point = new Point(510, 75);
                        break;
                    }
                case LevelDifficulty.Hard:
                    {
                        point = new Point(450, 75);
                        break;
                    }
            }

            for (int i = 0; i < this.questWord.Length; i++)
            {
                TextBox boxLetter = new TextBox();

                boxLetter.BackColor = System.Drawing.Color.Black;
                boxLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
                boxLetter.ForeColor = System.Drawing.Color.Gold;
                boxLetter.Location = point;
                boxLetter.Name = "boxLetter" + i;
                boxLetter.Size = new System.Drawing.Size(32, 32);
                boxLetter.Text = "#";
                boxLetter.Enabled = true;
                boxLetter.Visible = false;
                boxLetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                listBoxLetters.Add(boxLetter);

                this.Controls.Add(boxLetter);
                point.X += 26;
            }
        }
        public void VisibleWordT()
        {
            foreach (var item in listBoxLetters)
            {
                item.Visible = true;
            }
        }
        public void VisibleWordF()
        {
            foreach (var item in listBoxLetters)
            {
                item.Visible = false;
            }
        }
        //Открытие определённной буквы
        private void OpenLetter(int index)
        {
            string str = "" + questWord[index];
            listBoxLetters[index].Text = str.ToUpper();
        }
        public void OpenFirstLastLetter()
        {

            for (int i = 0; i < questWord.Length; i++)
            {
                if (questWord[i] == questWord[0] || questWord[i] == questWord[questWord.Length - 1])
                {
                    OpenLetter(i);
                    countWin--;
                }
            }
            char first = questWord.ToUpper()[0];
            char last = questWord.ToUpper()[questWord.Length - 1];

            for (int i = 0; i < 32; i++)
                if ((panel1.Controls[i].Text[0] == first)
                    || (panel1.Controls[i].Text[0] == last))
                    panel1.Controls[i].Enabled = false;
        }
        #endregion

        #region Методы обновления висельницы, GameOver, YouWin
        //Метод обновляет висельницу в зависимости от колличества жизней
        public void UpdateVisel(bool num)
        {
            str = "pics/visel" + countError + ".png";//строка доступа к изображению, зависит от кол-во ошибок
            if (num)
            {
                pictureBox2.Image = Image.FromFile(str);
            };
        }
        public void GameOver(bool num)
        {
            VisibleWordF();
            scale = 0.1F; scale_c = 0;
            pictureBox2.Visible = false;
            panel1.Visible = false;
            pictureBox1.Image = Image.FromFile("pics/gameover.png");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Size = new Size((int)(765 * scale), (int)(460 * scale));

            pictureBox1.Visible = true;
            end.Enabled = true;

            str = name + ", эх Вы..! :(((\nЯ даже не знаю что и сказать... :(((\nБыло же так легко.\nВам должно быть очень стыдно!\n\n";

            if (num)
            {
                DialogResult result = MessageBox.Show(str + "Начать заново?", "Game Over", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var form = Application.OpenForms[0];
                    form.Show();
                    this.Hide();
                }
                else if (result == DialogResult.No)
                {
                    Environment.Exit(0);
                }
            };
        }
        public void YouWin(bool num)
        {
            VisibleWordF();
            scale = 0.1F; scale_c = 0;
            pictureBox2.Visible = false;
            panel1.Visible = false;
            pictureBox1.Image = Image.FromFile("pics/youwin.png");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Size = new Size((int)(765 * scale), (int)(460 * scale));

            pictureBox1.Visible = true;
            end.Enabled = true;

            str = name + ", ух Ты!!!\nСлов нет!!!\nЭто было нелегко!\nНо Вы справились!!!\nДолжно быть Вы гордитесь собой.\n\n";
            if (num)
            {
                DialogResult result = MessageBox.Show(str + "Начать заново?", "You Win!!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var form = Application.OpenForms[0];
                    form.Show();
                    this.Hide();
                }
                else if (result == DialogResult.No)
                {
                    Environment.Exit(0);
                }
            }
        }
        #endregion

        //Здесь добавляются обработки наведения/покидания пикчербокса мышью
        private void GameFrame_Load(object sender, EventArgs e)
        {
            pictureBox1.MouseEnter += new EventHandler(pictureBox1_MouseEnter);
            pictureBox1.MouseLeave += new EventHandler(pictureBox1_MouseLeave);
        }

        #region Анимация начала/конца игры - обрабочики таймера
        public void timer1_Tick_1(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size((int)(765 * scale), (int)(460 * scale));
            pictureBox1.Location = new Point(450 - (pictureBox1.Size.Width / 2), 225 - (pictureBox1.Size.Height / 2));

            scale = scale + 0.1F - (0.02F * scale_c);
            if (scale >= (0.2F * scale_c))
                if (scale_c < 4)
                    scale_c++;

            if (scale >= 1)
            {
                start.Enabled = false;
                bboool = false;
            };

        }

        public void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size((int)(560 * scale), (int)(130 * scale));
            pictureBox1.Location = new Point(450 - (pictureBox1.Size.Width / 2), 225 - (pictureBox1.Size.Height / 2));

            scale = scale + 0.1F - (0.02F * scale_c);
            if (scale >= (0.2F * scale_c))
                if (scale_c < 4)
                    scale_c++;
            if (scale >= 1)
            {
                end.Enabled = false;
            };

        }
        #endregion

        #region обработчики наведения/покидания пикчербокса мышью
        public void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (!bboool)
            {
                (sender as PictureBox).Size = new Size((int)(765 * .95F), (int)(460 * .95F));
                (sender as PictureBox).Location = new Point(450 - ((sender as PictureBox).Size.Width / 2), 225 - ((sender as PictureBox).Size.Height / 2));
            }

        }
        public void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (!bboool)
            {
                (sender as PictureBox).Size = new Size(765, 460);
                (sender as PictureBox).Location = new Point(450 - ((sender as PictureBox).Size.Width / 2), 225 - ((sender as PictureBox).Size.Height / 2));
            }
        }
        #endregion

        // Нажатие на картинку Старт.
        public void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!bboool)
            {

                VisibleWordT();
                (sender as PictureBox).Visible = false;
                pictureBox2.Visible = true;
                panel1.Visible = true;
                bboool = true;

                OpenFirstLastLetter();
            };

        }

        //Нажатие на кнопку с буквой
        private void ClickOnLetter(object sender, EventArgs e)
        {
            LetterOn((sender as Button));
        }

        public bool LetterOn(Button sender)
        {
            bool isFind = false;
            questWord = questWord.ToUpper();
            if (sender != null)
            {
                //При сравнении не учитываем первый(нулевой) символ и последний. Ибо они уже открыты
                for (int i = 1; i < questWord.Length - 1; i++)
                {
                    if (questWord[i].Equals(sender.Text[0]))
                    {
                        OpenLetter(i);
                        guessedLetters++;
                        isFind = true;
                    }
                }
            }
            if (isFind == false)
            {
                countError++;
                UpdateVisel(true);
            }
            if (guessedLetters == countWin)
            {
                YouWin(true);

            }
            if (countError == 9)
            {
                GameOver(true);
            }
            
            sender.Enabled = false;
            return isFind;
        }

        private void GameFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count <= 2)
                Environment.Exit(0);
        }

    }

}

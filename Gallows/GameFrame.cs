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
        int countError;
        int countWin;
        //Сколько букв угадано. Для победы countWin == guessedLetters
        int guessedLetters;
        //Коллекция которая хранит ссылки на texBox которые отображат questWord
        List<TextBox> listBoxLetters = new List<TextBox>();

        float scale = 0.1F;
        int scale_c = 0;
        bool bboool = true;

        public GameFrame(LevelDifficulty levelDif, string name, string questWord)
        {
            this.levelDif = levelDif;
            this.name = name;
            this.questWord = questWord;

            DrawWord(questWord);
            InitializeComponent();
            
            
            

            countError = 0;
            //Счётчик сколько надо угадать слов, кроме первых 2 открытых
            countWin = questWord.Length - 2;
            guessedLetters = 0;


            this.Show();            
        }
 
        //Отрисовака всего слова в начале игры
        public void DrawWord(string word)
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
            
            for (int i = 0; i < word.Length; i++)
            {
                TextBox boxLetter = new TextBox();

                boxLetter.BackColor = System.Drawing.Color.Black;
                boxLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
                boxLetter.ForeColor = System.Drawing.Color.Gold;
                boxLetter.Location = point;
                boxLetter.Name = "boxLetter" + i;
                boxLetter.Size = new System.Drawing.Size(32, 32);
                boxLetter.TabIndex = 12;
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

        #region Методы обновления висельницы, GameOver, YouWin
        //Метод обновляет висельницу в зависимости от колличества жизней
        private void UpdateVisel()
        {
            string str = "pics/visel" + countError + ".png";//строка доступа к изображению, зависит от кол-во ошибок
            pictureBox2.Image = Image.FromFile(str);
        }

        private void GameOver()
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

            DialogResult result = MessageBox.Show("Начать заново?", "Game Over", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var form = Application.OpenForms[0];
                form.Show();
                this.Close();
            }
            else if(result == DialogResult.No)
            {
                Application.Exit();
            }       
        }

        private void YouWin()
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

            DialogResult result = MessageBox.Show("Начать заново?", "You Win!!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var form = Application.OpenForms[0];
                form.Show();
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                Application.Exit();
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
        private void timer1_Tick_1(object sender, EventArgs e)
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
        private void timer2_Tick(object sender, EventArgs e)
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
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (!bboool)
            {
                pictureBox1.Size = new Size((int)(765 * .95F), (int)(460 * .95F));
                pictureBox1.Location = new Point(450 - (pictureBox1.Size.Width / 2), 225 - (pictureBox1.Size.Height / 2));
            }

        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (!bboool)
            {
                pictureBox1.Size = new Size(765, 460);
                pictureBox1.Location = new Point(450 - (pictureBox1.Size.Width / 2), 225 - (pictureBox1.Size.Height / 2));
            }
        }
        #endregion
        
        // Нажатие на картинку Старт.
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!bboool)
            {
                pictureBox1.Visible = false;
                VisibleWordT();
                pictureBox2.Visible = true;
                panel1.Visible = true;
                bboool = true;
                OpenLetter(0);
                OpenLetter(questWord.Length - 1);
            };           

        }

        //Нажатие на кнопку с буквой
        private void button25_Click(object sender, EventArgs e)
        {
            bool isFind = false;
            questWord = questWord.ToUpper();
            if (sender is Button)
            {
                //При сравнении не учитываем первый(нулевой) символ и последний. Ибо они уже открыты
                for (int i = 1; i < questWord.Length - 1; i++)
                {                    
                    if (questWord[i].Equals((sender as Button).Text[0]))
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
                UpdateVisel();
            }
            if(guessedLetters == countWin)
            {
                YouWin();
                
            }
            if(countError == 9)
            {
                GameOver();                
            }

            (sender as Button).Enabled = false;
            
        }

        private void GameFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System.Drawing;
using Gallows;
using System.Collections.Generic;

namespace GameFrameTest
{
    [TestClass]
    public class GameFrameTest
    {

        #region Линника Тесты
        [TestMethod]
        public void GameFrame_DrawWord_Word()
        {
            GameFrame game = new GameFrame(LevelDifficulty.Easy, "Лёша", "марка");

            List<TextBox> expected = new List<TextBox>();
            Point point = new Point(580, 75);
            for (int i = 0; i < 5; i++)
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

                expected.Add(boxLetter);
                point.X += 26;
            }
            for (int i = 0; i < 5; i++)
            {               
                Assert.AreEqual(expected[i].BackColor, game.listBoxLetters[i].BackColor);
                Assert.AreEqual(expected[i].Font, game.listBoxLetters[i].Font);
                Assert.AreEqual(expected[i].ForeColor, game.listBoxLetters[i].ForeColor);
                Assert.AreEqual(expected[i].Location, game.listBoxLetters[i].Location);
                Assert.AreEqual(expected[i].Name, game.listBoxLetters[i].Name);
                Assert.AreEqual(expected[i].Size, game.listBoxLetters[i].Size);
                Assert.AreEqual(expected[i].Text, game.listBoxLetters[i].Text);
                Assert.AreEqual(expected[i].Enabled, game.listBoxLetters[i].Enabled);
                Assert.AreEqual(expected[i].Visible, game.listBoxLetters[i].Visible);
                Assert.AreEqual(expected[i].TextAlign, game.listBoxLetters[i].TextAlign);
            }            
        }
        [TestMethod]
        public void GameFrame_OpenFirstLastLetter_Open2Letter()
        {
            GameFrame game = new GameFrame(LevelDifficulty.Easy, "Лёша", "марка");
            game.OpenFirstLastLetter();
            Assert.AreEqual("М", game.Controls[0].Text);
            Assert.AreEqual("А", game.Controls[4].Text);
        }
        [TestMethod]        
        public void GameFrame_LetterOn_TrueLetter()
        {
            GameFrame game = new GameFrame(LevelDifficulty.Easy, "Лёша", "марка");
            Button button = new Button();
            button.Text = "А";             
            Assert.IsTrue(game.LetterOn(button));
        }
        [TestMethod]
        public void GameFrame_LetterOn_FalseLetter()
        {
            GameFrame game = new GameFrame(LevelDifficulty.Easy, "Леша", "марка");
            Button button = new Button();
            button.Text = "Ж";
            Assert.IsFalse(game.LetterOn(button));
        }

        [TestMethod]
        public void GameFrame_PictureBox1_MouseEnter_95proc()
        {
            GameFrame game = new GameFrame(LevelDifficulty.Easy, "Женя", "марка");
            game.bboool = false;
            PictureBox pictureBox1 = new PictureBox();
            game.pictureBox1_MouseEnter(pictureBox1, new EventArgs());
            Assert.AreEqual(pictureBox1.Height, (int)(460 * .95F));
            Assert.AreEqual(pictureBox1.Width, (int)(765 * .95F));
        }
        [TestMethod]
        public void GameFrame_PictureBox1_MouseLeave_100proc()
        {
            GameFrame game = new GameFrame(LevelDifficulty.Easy, "Женя", "марка");
            game.bboool = false;
            PictureBox pictureBox1 = new PictureBox();
            game.pictureBox1_MouseLeave(pictureBox1, new EventArgs());
            Assert.AreEqual(pictureBox1.Height, 460);
            Assert.AreEqual(pictureBox1.Width, 765);
        }
        
        #endregion

        #region Бухтиярова тесты
        [TestMethod]
        public void GameFrame_pictureBox1_Click_some_par()
        {
            GameFrame game = new GameFrame(LevelDifficulty.Easy, "Женя", "марка");
            game.bboool = false;
            PictureBox pictureBox1 = new PictureBox();
            game.pictureBox1_Click(pictureBox1, new EventArgs());
            Assert.AreEqual(pictureBox1.Visible, false);
            Assert.AreEqual(game.bboool, true);
        }
        [TestMethod]
        public void GameFrame_YouWin_name_plus_str()
        {
            string name = "Женя";
            string str = ", ух Ты!!!\nСлов нет!!!\nЭто было нелегко!\nНо Вы справились!!!\nДолжно быть Вы гордитесь собой.\n\n";
            GameFrame game = new GameFrame(LevelDifficulty.Easy, name, "марка");
            game.YouWin(false);
            Assert.AreEqual(game.str, name + str);
        }
        [TestMethod]
        public void GameFrame_GameOver_name_plus_str()
        {
            string name = "Женя";
            string str = ", эх Вы..! :(((\nЯ даже не знаю что и сказать... :(((\nБыло же так легко.\nВам должно быть очень стыдно!\n\n";
            GameFrame game = new GameFrame(LevelDifficulty.Easy, name, "марка");
            game.GameOver(false);
            Assert.AreEqual(game.str, name + str);
        }
        [TestMethod]
        public void GameFrame_UpdateVisel_num_of_file()
        {
            string str1 = "pics/visel";
            string str2 = ".png";
            GameFrame game = new GameFrame(LevelDifficulty.Easy, "Женя", "марка");
            game.UpdateVisel(false);
            Assert.AreEqual(game.str, str1 + game.countError + str2);
        }

        #region GameFrame_Timer1()
        [TestMethod]
        public void GameFrame_Timer1_0_1()
        {
            float a, b;
            float c = 0.1F;
            GameFrame game = new GameFrame(LevelDifficulty.Easy, "Женя", "марка");
            for (int i = 0; i < 0; i++)
                game.timer1_Tick_1(new object(), new EventArgs());

            a = game.scale;
            game.timer1_Tick_1(new object(), new EventArgs());
            b = game.scale;

            Assert.AreEqual(b-a, c);
        }
        [TestMethod]
        public void GameFrame_Timer1_1_2()
        {
            float a, b;
            float c = 0.08F;
            GameFrame game = new GameFrame(LevelDifficulty.Easy, "Женя", "марка");
            for (int i = 0; i < 1; i++)
                game.timer1_Tick_1(new object(), new EventArgs());

            a = game.scale;
            game.timer1_Tick_1(new object(), new EventArgs());
            b = game.scale;

            Assert.AreEqual(b - a, c);
        }
        [TestMethod]
        public void GameFrame_Timer1_3_4()
        {
            float a, b;
            float c = 0.06F;
            GameFrame game = new GameFrame(LevelDifficulty.Easy, "Женя", "марка");
            for (int i = 0; i < 3; i++)
                game.timer1_Tick_1(new object(), new EventArgs());

            a = game.scale;
            game.timer1_Tick_1(new object(), new EventArgs());
            b = game.scale;

            Assert.AreEqual(b - a, c, .00001F);
        }
        [TestMethod]
        public void GameFrame_Timer1_7_8()
        {
            float a, b;
            float c = 0.04F;
            GameFrame game = new GameFrame(LevelDifficulty.Easy, "Женя", "марка");
            for (int i = 0; i < 7; i++)
                game.timer1_Tick_1(new object(), new EventArgs());

            a = game.scale;
            game.timer1_Tick_1(new object(), new EventArgs());
            b = game.scale;

            Assert.AreEqual(b - a, c, .00001F);
        }
        [TestMethod]
        public void GameFrame_Timer1_20_21()
        {
            float a, b;
            float c = 0.02F;
            GameFrame game = new GameFrame(LevelDifficulty.Easy, "Женя", "марка");
            for (int i = 0; i < 20; i++)
                game.timer1_Tick_1(new object(), new EventArgs());

            a = game.scale;
            game.timer1_Tick_1(new object(), new EventArgs());
            b = game.scale;

            Assert.AreEqual((b - a), c, .00001F);
        }
        [TestMethod]
        public void GameFrame_Timer1_100()
        {
            GameFrame game = new GameFrame(LevelDifficulty.Easy, "Женя", "марка");
            for (int i = 0; i < 100; i++)
                game.timer1_Tick_1(new object(), new EventArgs());

            Assert.AreEqual((game.scale >= 1), true);
        }
        #endregion
        #region GameFrame_Timer2()
        [TestMethod]
        public void GameFrame_Timer2_0_1()
        {
            float a, b;
            float c = 0.1F;
            GameFrame game = new GameFrame(LevelDifficulty.Easy, "Женя", "марка");
            for (int i = 0; i < 0; i++)
                game.timer2_Tick(new object(), new EventArgs());

            a = game.scale;
            game.timer2_Tick(new object(), new EventArgs());
            b = game.scale;

            Assert.AreEqual(b - a, c, .00001F);
        }
        [TestMethod]
        public void GameFrame_Timer2_1_2()
        {
            float a, b;
            float c = 0.08F;
            GameFrame game = new GameFrame(LevelDifficulty.Easy, "Женя", "марка");
            for (int i = 0; i < 1; i++)
                game.timer2_Tick(new object(), new EventArgs());

            a = game.scale;
            game.timer2_Tick(new object(), new EventArgs());
            b = game.scale;

            Assert.AreEqual(b - a, c, .00001F);
        }
        [TestMethod]
        public void GameFrame_Timer2_3_4()
        {
            float a, b;
            float c = 0.06F;
            GameFrame game = new GameFrame(LevelDifficulty.Easy, "Женя", "марка");
            for (int i = 0; i < 3; i++)
                game.timer2_Tick(new object(), new EventArgs());

            a = game.scale;
            game.timer2_Tick(new object(), new EventArgs());
            b = game.scale;

            Assert.AreEqual(b - a, c, .00001F);
        }
        [TestMethod]
        public void GameFrame_Timer2_7_8()
        {
            float a, b;
            float c = 0.04F;
            GameFrame game = new GameFrame(LevelDifficulty.Easy, "Женя", "марка");
            for (int i = 0; i < 7; i++)
                game.timer2_Tick(new object(), new EventArgs());

            a = game.scale;
            game.timer2_Tick(new object(), new EventArgs());
            b = game.scale;

            Assert.AreEqual(b - a, c, .00001F);
        }
        [TestMethod]
        public void GameFrame_Timer2_20_21()
        {
            float a, b;
            float c = 0.02F;
            GameFrame game = new GameFrame(LevelDifficulty.Easy, "Женя", "марка");
            for (int i = 0; i < 20; i++)
                game.timer2_Tick(new object(), new EventArgs());

            a = game.scale;
            game.timer2_Tick(new object(), new EventArgs());
            b = game.scale;

            Assert.AreEqual(b - a, c, .00001F);
        }
        [TestMethod]
        public void GameFrame_Timer2_100()
        {
            GameFrame game = new GameFrame(LevelDifficulty.Easy, "Женя", "марка");
            for (int i = 0; i < 100; i++)
                game.timer2_Tick(new object(), new EventArgs());

            Assert.AreEqual((game.scale >= 1), true);
        }
        #endregion

        #endregion

    }
}

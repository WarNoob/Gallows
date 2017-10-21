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
            GameFrame game = new GameFrame(LevelDifficulty.Easy, "Лёша", "марка");
            Button button = new Button();
            button.Text = "Ж";
            Assert.IsFalse(game.LetterOn(button));
        }
    }
}

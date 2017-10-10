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
    public partial class InitFrame : Form
    {
        //Коллекции для хранения слов по сложности
        List<QuestWord> easyList;
        List<QuestWord> normList;
        List<QuestWord> hardList;
        //Уровень сложности игры
        LevelDifficulty level;
        string name;
        string questWord;
        Random random;
        public InitFrame()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            random = new Random();
            this.name = textBoxPlayerName.Text;         

            if (radioButtonEasy.Enabled)
                level =  LevelDifficulty.Easy;
            else if (radioButtonNorm.Enabled)
                level = LevelDifficulty.Normal;
            else
                level = LevelDifficulty.Hard;

            
            switch(level)
            {
                case LevelDifficulty.Easy:
                    {
                        questWord = easyList[random.Next(easyList.Count)].Word;
                        break;
                    }
                case LevelDifficulty.Normal:
                    {
                        questWord = normList[random.Next(normList.Count)].Word;
                        break;
                    }
                case LevelDifficulty.Hard:
                    {
                        questWord = hardList[random.Next(hardList.Count)].Word;
                        break;
                    }
            }
                

            GameFrame frm = new GameFrame(level, name, questWord);
            

            this.Hide();                 
        }
        private void InitList()
        {
            easyList = new List<QuestWord>
            {
                new QuestWord() {Word = "курсив" },
                new QuestWord() {Word = "минута" },
                new QuestWord() {Word = "солдат" },
                new QuestWord() {Word = "черный" },
                new QuestWord() {Word = "третий" },
                new QuestWord() {Word = "приказ" },
                new QuestWord() {Word = "тишина" },
                new QuestWord() {Word = "победа" },
                new QuestWord() {Word = "журнал" },
                new QuestWord() {Word = "восемь" }
            };
            normList = new List<QuestWord>
            {
                new QuestWord() {Word = "абитуриент" },
                new QuestWord() {Word = "абстракция" },
                new QuestWord() {Word = "автомобиль" },
                new QuestWord() {Word = "беспорядок" },
                new QuestWord() {Word = "вулканолог" },
                new QuestWord() {Word = "газопровод" },
                new QuestWord() {Word = "директорат" },
                new QuestWord() {Word = "жемчужница" },
                new QuestWord() {Word = "метрология" },
                new QuestWord() {Word = "субстанция" }
            };
            hardList = new List<QuestWord>
            {
                new QuestWord() {Word = "железнодорожник" },
                new QuestWord() {Word = "благопристойный" },
                new QuestWord() {Word = "агрообъединение" },
                new QuestWord() {Word = "беспристрастный" },
                new QuestWord() {Word = "вспомогательный" },
                new QuestWord() {Word = "гипнотизировать" },
                new QuestWord() {Word = "диагностировать" },
                new QuestWord() {Word = "костедробильный" },
                new QuestWord() {Word = "нефтедобывающий" },
                new QuestWord() {Word = "общефедеральный" }
            };
        }
    }
}

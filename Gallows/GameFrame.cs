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
        //Коллекции для хранения слов по сложности
        List<QuestWord> easyList;
        List<QuestWord> normList;
        List<QuestWord> hardList;
        //Уровень сложности игры
        LevelDifficulty levelDif;
        //Имя игрока
        string name;
        public void MyLine()
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(new Pen(Color.Red), 20, 10, 300, 100);
        }
        public GameFrame(LevelDifficulty levelDif, string name)
        {
            InitializeComponent();
            
            this.levelDif = levelDif;
            this.name = name;
            this.Show();
        }

        //Из-за того что первую форму надо скрыть а не
        //закрыть, при открытии второй(иначе главный потиок программы закрываться и 
        //прилажение закрываеться) нужен этот обработчик
        private void GameFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

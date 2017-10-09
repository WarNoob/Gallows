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
        List<QuestWord> easyList;
        List<QuestWord> normList;
        List<QuestWord> hardList;
        public void MyLine()
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(new Pen(Color.Red), 20, 10, 300, 100);
        }
        public GameFrame()
        {
            InitializeComponent();            
        }

        private void GameFrame_Load(object sender, EventArgs e)
        {
            MyLine();
        }
       
    }
}

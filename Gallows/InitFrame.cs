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
        public LevelDifficulty level;
        public string name;
        public InitFrame()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            GameFrame frm = new GameFrame();
            //Передача ссылки на родитель. Что бы можно было работать с закрытыми полями из другой формы
            frm.Owner = this;
            this.name = textBoxPlayerName.Text;

            if (radioButtonEasy.Enabled)
                level = LevelDifficulty.Easy;
            else if (radioButtonNorm.Enabled)
                level = LevelDifficulty.Normal;
            else
                level = LevelDifficulty.Hard;

            frm.Show();
            this.Close();
        }
    }
}

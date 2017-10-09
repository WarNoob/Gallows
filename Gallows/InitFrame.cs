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
        public InitFrame()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            GameFrame frm = new GameFrame();
            //Передача ссылки на родитель. Что бы можно было работать с закрытыми полями из другой формы
            frm.Owner = this;
            frm.Show();
            this.Close();
        }
    }
}

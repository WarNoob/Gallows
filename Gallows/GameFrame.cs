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
        public GameFrame()
        {
            InitializeComponent();
        }

    }
}

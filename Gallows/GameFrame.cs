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
        public GameFrame()
        {
            InitializeComponent();
        }

        private void GameFrame_Load(object sender, EventArgs e)
        {
            pictureBox1.MouseEnter += new EventHandler(pictureBox1_MouseEnter);
            pictureBox1.MouseLeave += new EventHandler(pictureBox1_MouseLeave);
        }

        private float scale = 0.1F;
        private int scale_c = 0;
        private bool bboool = false;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size((int)(765 * scale), (int)(460 * scale));
            pictureBox1.Location = new Point(385 - (pictureBox1.Size.Width / 2), 230 - (pictureBox1.Size.Height / 2));

            scale = scale + 0.1F - (0.02F * scale_c);
            if (scale >= (0.2F * scale_c))
                if (scale_c < 4)
                    scale_c++;

            if (scale >= 1)
            {
                start.Enabled = false;
            };
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size((int)(560 * scale), (int)(130 * scale));
            pictureBox1.Location = new Point(385 - (pictureBox1.Size.Width / 2), 230 - (pictureBox1.Size.Height / 2));

            scale = scale + 0.1F - (0.02F * scale_c);
            if (scale >= (0.2F * scale_c))
                if (scale_c < 4)
                    scale_c++;

            if (scale >= 1)
            {
                end.Enabled = false;
            };
        }



        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (!bboool)
                pictureBox1.Image = Image.FromFile("pics/start2.png");
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if(!bboool)
                pictureBox1.Image = Image.FromFile("pics/start1.png");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!bboool)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                panel1.Visible = true;
                bboool = true;
            };
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("pics/visel0.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("pics/visel1.png");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("pics/visel2.png");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("pics/visel3.png");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("pics/visel4.png");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("pics/visel5.png");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("pics/visel6.png");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("pics/visel7.png");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("pics/visel8.png");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("pics/visel9.png");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            scale = 0.1F; scale_c = 0;
            pictureBox2.Visible = false;
            panel1.Visible = false;
            pictureBox1.Image = Image.FromFile("pics/youwin.png");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Size = new Size((int)(765 * scale), (int)(460 * scale));

            pictureBox1.Visible = true;
            end.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            scale = 0.1F; scale_c = 0;
            pictureBox2.Visible = false;
            panel1.Visible = false;
            pictureBox1.Image = Image.FromFile("pics/gameover.png");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Size = new Size((int)(765 * scale), (int)(460 * scale));

            pictureBox1.Visible = true;
            end.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

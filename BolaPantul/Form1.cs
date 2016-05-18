using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BolaPantul
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();

            timer.Enabled = true;
            timer.Interval = 10;
            timer.Tick += timer_Tick;
        }

        int moveX = 10;
        int moveY = 10;

        private void timer_Tick(Object sender, EventArgs e)
        {

            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            if (y <= 1)
            {
                if ((moveX * moveY) == -100)
                {
                    moveX = 10;
                }
                else
                {
                    moveX = -10;
                }
                moveY = 10;
            }
            else if (x >= (this.Width - pictureBox1.Size.Width))
            {
                if ((moveX * moveY) == 100)
                {
                    moveY = 10;
                }
                else
                {
                    moveY = -10;
                }
                moveX = -10;
            }
            else if (y >= (this.Height - pictureBox1.Size.Height))
            {
                if ((moveX * moveY) == -100)
                {
                    moveX = -10;
                }
                else
                {
                    moveX = 10;
                }
                moveY = -10;
            }
            else if (x <= 1)
            {
                if ((moveX * moveY) == 100)
                {
                    moveY = -10;
                }
                else
                {
                    moveY = 10;
                }
                moveX = 10;
            }

            pictureBox1.Location = new Point(x += moveX, y += moveY);
        }
    }
}

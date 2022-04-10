using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S4ta
{
    public partial class Form1 : Form
    {
        int gravity = 5;
        int treeSpeed = 6;
        int hutSpeed = 6;
        int moonSpeed = 6;
        int SnowflakesSpeed = 6;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sleight.Top += gravity;
            tree.Left -= treeSpeed;
            hut.Left -= hutSpeed;
            moon.Left -= moonSpeed;
            Snowflakes.Left -= SnowflakesSpeed;
            score.Text = $"Game Over!";

            if(tree.Left < -80)
            {
                tree.Left = 500;
                score++;
            }

            if(hut.Left < -60)
            {
                hut.Left = 600;
                score++;
            }

            if(moon.Left < - 80)
            {
                moon.Left = 700;
                score++;
            }

            if(Snowflakes.Left < -80)
            {
                Snowflakes.Left = 100;
                score++;
            }

            if(sleight.Top < -25)
            {
                gameOver();
            }
             
            if(sleight.Bounds.IntersectsWith(tree.Bounds) || sleight.Bounds.IntersectsWith(hut.Bounds)) || sleight.Bounds.IntersectsWith(ground.Bounds))
            {
                gameOver();
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void gameOver()
        {
            timer1.Stop();
            score.Text = $"Game Over!";
            playAgain.Visible = true;
        }

        private void playAgain_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}

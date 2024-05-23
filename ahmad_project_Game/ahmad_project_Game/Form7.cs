using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ahmad_project_Game
{
    public partial class Form77 : Form
    {
        public Form77()
        {
            InitializeComponent();
        }
        int g = 10;
        public int score = 0;
        int pipespeed = 8;
        private void timer1_Tick(object sender, EventArgs e)
        {
            beard.Top += g;
            botomm.Left -= pipespeed;
            topp.Left -= pipespeed;
            label2.Text = score.ToString();

            if (botomm.Left < -50)
            {
                botomm.Left = 800;
                score++;
            }
            if (topp.Left < -80)
            {
                topp.Left = 900;
                score++;
            }
            if (beard.Bounds.IntersectsWith(botomm.Bounds) || beard.Bounds.IntersectsWith(topp.Bounds) || beard.Bounds.IntersectsWith(ground.Bounds)){

                endgame();
            }

            
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void Form77_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                g = -10;
            }
        }

        private void Form77_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                g = 10;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
        private void endgame()
        {
            timer1.Stop();
            label2.Text += "game over";

            this.Hide();
            Form f9 = new Form9();
            f9.Show();
        }

    }
}

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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f5 = new Form5();
            f5.Show();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f8 = new Form77();
            f8.Show();
        }
    }
}

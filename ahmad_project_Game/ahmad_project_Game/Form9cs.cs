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
    public partial class Form9cs : Form
    {
        public Form9cs()
        {
            InitializeComponent();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f8 = new Form77();
            f8.Show();
        }

        private void Form9cs_Load(object sender, EventArgs e)
        {
            
        }
    }
}

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int g = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += g;
        }
    }
}

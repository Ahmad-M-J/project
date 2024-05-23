namespace ahmad_project_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f2 = new Form2();
            f2.Show();
        }
    }
}

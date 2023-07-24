namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ytbDownloader().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new pictursDownloader().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new filesAndSitesDownloader().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
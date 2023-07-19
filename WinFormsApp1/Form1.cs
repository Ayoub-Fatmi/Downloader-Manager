namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Hide();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // Change the label's text
            label1.Text = "Label clicked!";

            // Perform some action or display a message
            MessageBox.Show("Label clicked!");
            this.Hide();
            // Navigate to another form or page
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }
    }
}
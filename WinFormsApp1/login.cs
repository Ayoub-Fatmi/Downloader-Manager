using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void signUpBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            new signUp().Show();
        }

        private void loginBut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTB.Text) || string.IsNullOrWhiteSpace(usernameTB.Text))
            {
                label4.Text = "wrong informations!!";
                label4.Location = new Point(119, 225);
            }
            else
            {
                string connectionString = "server=localhost;database=netforms;user=root;password=;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM users WHERE username=@username AND password=@password";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", usernameTB.Text);
                        command.Parameters.AddWithValue("@password", passwordTB.Text);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string username = reader.GetString(reader.GetOrdinal("username"));
                                MessageBox.Show($"Welcome {username}");
                                this.Hide();
                                new Form1().Show();
                            }
                            else
                            {
                                label4.Text = "wrong informations!!";
                                label4.Location = new Point(113, 177);
                            }
                        }
                    }
                }
            }
        }
    }
}

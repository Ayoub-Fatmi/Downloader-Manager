using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }

        private void signUpBut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sPasswordTB.Text) || string.IsNullOrWhiteSpace(sUsernameTB.Text))
            {
                label3.Text = "wrong informations!!";
                label3.Location = new Point(113, 177);
            }
            else
            {
                string connectionString = "server=localhost;database=netforms;user=root;password=;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO users (username, password) VALUES (@username, @password)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", sUsernameTB.Text);
                        command.Parameters.AddWithValue("@password", sPasswordTB.Text);
                        try
                        {
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                label3.Hide();
                                MessageBox.Show("congratulations");
                                this.Hide();
                                new login().Show();
                            }
                        } 
                        catch
                        {
                            label3.Text = "wrong informations!!";
                            label3.Location = new Point(113, 177);
                        }
                    }
                }
            }
        }
    }
}

/*
//sites
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace WinFormsApp1
{
    public partial class mainInterface : Form
    {
        public mainInterface()
        {
            InitializeComponent();
        }
        /*private bool IsUrlValid(string url)
        {
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "http://" + url;
            }
            try
            {
                // Create a WebRequest for the URL
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";

                // Get the response
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    // Check if the response status code indicates success
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        // URL is valid and accessible
                        return true;
                    }
                }
            }
            catch (WebException ex)
            {
                // An error occurred while accessing the URL
                // You can handle specific types of exceptions or log the error
                // Uncomment the following line if you want to log the error
                // Console.WriteLine($"Error: {ex.Message}");
            }

            // URL is invalid or inaccessible
            return false;
        }*-/
private async void button1_Click(object sender, EventArgs e)
        {
    /*using (WebClient client = new WebClient())
    {
        try
        {
            // Display the SaveFileDialog to let the user choose the download path
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = Path.GetFileName(textBox1.Text); // Set the default file name

            if (Path.GetExtension(new Uri(textBox1.Text).AbsolutePath) ==""){
                MessageBox.Show($"without");
                Uri uri = new Uri(textBox1.Text);
                saveFileDialog.FileName = uri.Segments.Last() + ".html"; // Set the default file name
                if (Path.GetFileName(textBox1.Text) == "")
                {
                    string domain = uri.Host;
                    // Extract the domain name without the subdomains
                    string[] subdomains = domain.Split('.');
                    string domainName = subdomains[subdomains.Length - 2];
                    saveFileDialog.FileName = domainName + ".html"; // Set the default file name
                }
            }
            else
            {
                saveFileDialog.FileName = Path.GetFileName(textBox1.Text); // Set the default file name
                MessageBox.Show($"{saveFileDialog.FileName}");
            }
            saveFileDialog.Filter = "All Files (*.*)|*.*"; // Set the file type filter

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Start the download with the selected save path
                client.DownloadFile(textBox1.Text, saveFileDialog.FileName);
                MessageBox.Show("Download completed successfully.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred during the download: {ex.Message}");
        }
    }**-/

}
}
}*/

//pictures
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class mainInterface : Form
    {
        public mainInterface()
        {
            InitializeComponent();
        }
        public static string GetVideoId(string youtubeUrl)
        {
            string pattern = @"(?:youtube\.com\/watch\?v=|youtu\.be\/)([\w-]+)";
            Match match = Regex.Match(youtubeUrl, pattern);

            if (match.Success)
            {
                return match.Groups[1].Value;
            }

            // Return null if no video ID is found
            return null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string imageUrl = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(imageUrl))
            {
                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        //google image
                        if (imageUrl.StartsWith("data:image/jpeg;base64,"))
                        {
                            byte[] imageData = Convert.FromBase64String(imageUrl.Split(',')[1]);
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                pictureBox1.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(GetVideoId(imageUrl)))
                            {
                                //ytb thumbn
                                imageUrl = "https://img.youtube.com/vi/" + GetVideoId(imageUrl) + "/hqdefault.jpg";
                                
                            }
                            //image with normal link
                            byte[] imageData = webClient.DownloadData(imageUrl);
                            using (MemoryStream stream = new MemoryStream(imageData))
                            {
                                pictureBox1.Image = Image.FromStream(stream);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error downloading the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid image URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
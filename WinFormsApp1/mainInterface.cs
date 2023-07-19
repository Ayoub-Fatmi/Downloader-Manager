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
        }*/
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
            }*/
            /*var youtube = new YoutubeClient();

            // You can specify either the video URL or its ID
            var videoUrl = "https://youtube.com/watch?v=u_yIGGhubZs";
            var video = await youtube.Videos.GetAsync(videoUrl);

            var title = video.Title; // "Collections - Blender 2.80 Fundamentals"
            var author = video.Author.ChannelTitle; // "Blender"
            var duration = video.Duration; // 00:07:20

            MessageBox.Show($"{title} {author} {duration}");*/
            /*var youtube = new YoutubeClient();

            var videoUrl = "https://youtube.com/watch?v=u_yIGGhubZs";
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoUrl);

            // Get highest quality muxed stream
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            // Get the actual stream
            var stream = await youtube.Videos.Streams.GetAsync(streamInfo);
            // Download the stream to a file
            await youtube.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");*/
        }
    }
}

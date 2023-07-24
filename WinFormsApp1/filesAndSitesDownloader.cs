
//files and sites
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Net.Mime;


namespace WinFormsApp1
{
    public partial class filesAndSitesDownloader : Form
    {
        public filesAndSitesDownloader()
        {
            InitializeComponent();
        }

        public static string IsFileLink(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "HEAD"; // Use the HEAD method to fetch headers only, not the whole content

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    // Get the content type from the response headers
                    string contentType = response.ContentType.ToLower();
                    if (contentType.Contains("text/html"))
                    {
                        return "site";
                    }
                    else
                    {
                        ContentDisposition contentDisposition = new ContentDisposition(response.Headers["Content-Disposition"]);
                        string fileName = contentDisposition.FileName;
                        return fileName;
                    }
                }
            }
            catch (WebException ex)
            {
                // An error occurred while accessing the URL
                // Handle or log the error if needed
                Debug.WriteLine($"Error: {ex.Message}");
            }
            return "error";
        }
        private async void button1_Click_1(object sender, EventArgs e)
        {

            using (WebClient client = new WebClient())
            {
                Uri uri = new Uri(textBox1.Text);
                IsFileLink(uri.ToString());
                try
                {
                    // Display the SaveFileDialog to let the user choose the download path
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.FileName = Path.GetFileName(textBox1.Text); // Set the default file name

                    if (IsFileLink(uri.ToString()) == "site")
                    {

                        if (Path.GetExtension(new Uri(textBox1.Text).AbsolutePath) == "")
                        {
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
                            saveFileDialog.FileName = uri.Segments.Last();
                        }

                    }
                    else if (Path.GetExtension(new Uri(textBox1.Text).AbsolutePath) == "" && IsFileLink(uri.ToString()) != "site")
                    {
                        saveFileDialog.FileName = IsFileLink(uri.ToString()); // Set the default file name
                    }
                    else
                    {
                        saveFileDialog.FileName = Path.GetFileName(textBox1.Text); // Set the default file name
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
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }
    }
}

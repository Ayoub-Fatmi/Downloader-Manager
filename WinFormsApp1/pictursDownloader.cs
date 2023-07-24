//pictures
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class pictursDownloader : Form
    {
        public pictursDownloader()
        {
            InitializeComponent();
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
                        if (imageUrl.StartsWith("data:image/"))
                        {
                            /*byte[] imageData = Convert.FromBase64String(imageUrl.Split(',')[1]);
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                pictureBox1.Image = Image.FromStream(ms);
                            }*/
                            // Extract the image type from the data URI
                            string imageType = imageUrl.Substring("data:image/".Length);
                            string picName = "picture";
                            int commaIndex = imageType.IndexOf(';');
                            int picIndex = imageType.IndexOf(',');
                            if (commaIndex != -1 && picIndex != -1)
                            {
                                picName = imageType.Substring(picIndex + 1, picIndex + 7);
                                imageType = imageType.Substring(0, commaIndex);
                            }

                            // Show SaveFileDialog to let the user choose the download path
                            SaveFileDialog saveFileDialog = new SaveFileDialog();
                            saveFileDialog.FileName = $"{picName}.{imageType}";
                            saveFileDialog.Filter = $"Image Files|*.{imageType}";
                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                // Decode and save the image from the data URI to the selected path
                                byte[] imageData = Convert.FromBase64String(imageUrl.Split(',')[1]);
                                File.WriteAllBytes(saveFileDialog.FileName, imageData);
                                MessageBox.Show("Download completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            SaveFileDialog saveFileDialog = new SaveFileDialog();
                            if (!string.IsNullOrEmpty(GetVideoId(imageUrl)))
                            {
                                //ytb thumbn
                                saveFileDialog.FileName = $"{GetVideoId(imageUrl)}-hqdefault.jpg";
                                Debug.WriteLine("azze " + GetVideoId(imageUrl) + " " + imageUrl);
                                imageUrl = "https://img.youtube.com/vi/" + GetVideoId(imageUrl) + "/hqdefault.jpg";
                                saveFileDialog.Filter = $"Image Files|*.jpg";
                            }
                            else
                            {
                                saveFileDialog.FileName = GetImageInfo(imageUrl);
                                saveFileDialog.Filter = $"Image Files|*{Path.GetExtension(GetImageInfo(imageUrl))}";
                            }

                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                byte[] imageData = webClient.DownloadData(imageUrl);
                                /*using (MemoryStream stream = new MemoryStream(imageData))
                                {
                                    pictureBox1.Image = Image.FromStream(stream);
                                }*/
                                File.WriteAllBytes(saveFileDialog.FileName, imageData);
                                MessageBox.Show("Download completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public static string GetImageInfo(string imageUrl)
        {
            try
            {
                // Extract the filename with query parameters (if any) from the URL
                string filenameWithQuery = Path.GetFileName(imageUrl);

                // Remove the query parameters (if any) from the filename
                string filename = RemoveQueryParameters(filenameWithQuery);

                // Extract the file extension
                string extension = Path.GetExtension(filename);

                // Extract the file name without extension
                string nameWithoutExtension = Path.GetFileNameWithoutExtension(filename);

                Console.WriteLine($"Filename without query parameters: {filename}");
                Console.WriteLine($"File Extension: {extension}");
                Console.WriteLine($"File Name without Extension: {nameWithoutExtension}");
                return filename;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return "";
        }

        private static string RemoveQueryParameters(string filenameWithQuery)
        {
            int queryIndex = filenameWithQuery.IndexOf('?');
            if (queryIndex != -1)
            {
                return filenameWithQuery.Substring(0, queryIndex);
            }
            return filenameWithQuery;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();

        }
    }
}
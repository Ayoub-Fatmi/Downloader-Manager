//youtube videos
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class ytbDownloader : Form
    {
        private ytbDownloadProgress progressf;

        public ytbDownloader()
        {
            InitializeComponent();

        }
        private static bool IsYouTubeUrlValid(string url)
        {
            string pattern = @"^(http(s)?:\/\/)?((w){3}\.)?(m\.)?youtu(be|\.be)?(\.com)?\/.+";
            Regex regex = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Match match = regex.Match(url);

            return match.Success;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxQuality.SelectedItem == null || textBox1.Text == "" || IsYouTubeUrlValid(textBox1.Text) == false)
            {
                MessageBox.Show("Please select a quality option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedQuality = "247";
            switch (comboBoxQuality.SelectedItem.ToString())
            {
                case "1080p":
                    selectedQuality = "248";
                    break;
                case "720p":
                    selectedQuality = "247";
                    break;
                case "480p":
                    selectedQuality = "244";
                    break;
                case "360p":
                    selectedQuality = "243";
                    break;
                case "240p":
                    selectedQuality = "242";
                    break;
                case "144p":
                    selectedQuality = "278";
                    break;
                case "mp3":
                    selectedQuality = "249";
                    break;
                default:
                    break;
            }
            string outputDirectory;

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();
                if (result != DialogResult.OK || string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    return;
                }

                outputDirectory = folderBrowserDialog.SelectedPath;
            }

            string command = $"youtube-dl --output \"{outputDirectory}\\%(title)s ({comboBoxQuality.SelectedItem.ToString()}).%(ext)s\" -f \"{selectedQuality}\" {textBox1.Text}";

            progressf = new ytbDownloadProgress();
            this.Hide();
            progressf.Show();

            await Task.Run(() =>
            {
                using (Process process = new Process())
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/C {command}",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    process.StartInfo = startInfo;
                    process.OutputDataReceived += Process_OutputDataReceived;
                    process.ErrorDataReceived += Process_ErrorDataReceived;
                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();
                    process.WaitForExit();

                    /*int exitCode = process.ExitCode;
                    if (exitCode == 0)
                    {
                        MessageBox.Show("Download completed successfully!");

                    }
                    else
                    {
                        MessageBox.Show("Download f!" + exitCode);
                    }*/
                }
            });
            progressf.Close(); // Close the progress form after download completion.
            this.Show(); // Show the main form again after the download is complete.
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                if (e.Data.Contains("[download]") && e.Data.Contains("ETA"))
                {
                    progressf.caller(e.Data);
                }
            }
        }

        private void Process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }
    }
}
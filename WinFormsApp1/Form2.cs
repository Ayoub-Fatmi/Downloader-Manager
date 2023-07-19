using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        // Declare the progress form variable at the class level
        private progress progressf;

        public Form2()
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

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (comboBoxQuality.SelectedItem == null || textBox1.Text == "" || IsYouTubeUrlValid(textBox1.Text) ==false)
            {
                MessageBox.Show("Please select a quality option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/

             string selectedQuality= "136";
            switch (comboBoxQuality.SelectedItem.ToString())
            {
                case "1080p":
                    selectedQuality = "137";
                    // code block
                    break;
                case "720p":
                    selectedQuality = "136";
                    // code block
                    break;
                case "480p":
                    selectedQuality = "135";
                    // code block
                    break;
                case "360p":
                    selectedQuality = "134";
                    // code block
                    break;
                case "240p":
                    selectedQuality = "133";
                    // code block
                    break;
                case "144p":
                    selectedQuality = "160";
                    // code block
                    break;
                case "mp3":
                    selectedQuality = "140";
                    // code block
                    break;
                default:
                    // code block
                    break;
            }
            MessageBox.Show(selectedQuality);
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
                // Show the progress form before waiting for the process to exit
                progressf = new progress();
                progressf.Show();

                process.OutputDataReceived += Process_OutputDataReceived;
                process.ErrorDataReceived += Process_ErrorDataReceived;
                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                process.WaitForExit();

                int exitCode = process.ExitCode;
                if (exitCode == 0)
                {
                    MessageBox.Show("Download completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Download failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                // Check if the received data contains progress bar information
                if (e.Data.Contains("[download]") && e.Data.Contains("ETA"))
                {
                    progressf.UpdateProgress(e.Data);
                }
            }
        }

        private void Process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                // Error output from the process (standard error)
                // Display or process the error as desired
                MessageBox.Show(e.Data );
            }
        }
    }
}
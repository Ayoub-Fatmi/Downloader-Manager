using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Text.RegularExpressions;


namespace WinFormsApp1
{
    public partial class ytbDownloadProgress : Form
    {
        private Thread updateThread;
        private bool isUpdating = true;
        private string data;
        public ytbDownloadProgress()
        {
            InitializeComponent();
        }

        public void caller(string data)
        {
            this.Load += this.Progress_Load;
            this.data = data;
        }

        private void Progress_Load(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void progress_Load(object sender, EventArgs e)
        {
            updateThread = new Thread(UpdateLabelSafe);
            updateThread.Start();
        }

        static float ProcessNumber(string text)
        {
            string numberPattern = @"\d+(\.\d+)?";
            float floatValue = 0;
            Match match = Regex.Match(text, numberPattern);
            string extractedNumber = match.Value;
            float.TryParse(extractedNumber, out floatValue);
            return floatValue;
        }

        private void UpdateLabelSafe()
        {
            while (isUpdating)
            {
                if (label7.InvokeRequired)
                {
                    if (data != null)
                    {
                        string progressData = data.Replace("[download]", "").Trim();
                        string[] parts = progressData.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        float downloaded = (ProcessNumber(parts[0]) / 100) * ProcessNumber(parts[2]);

                        label6.Invoke((MethodInvoker)(() => label6.Text = parts[2]));
                        label7.Invoke((MethodInvoker)(() => label7.Text = parts[0] + " (" + Math.Round(downloaded, 2) + "MiB) "));
                        label8.Invoke((MethodInvoker)(() => label8.Text = parts[4]));
                        label9.Invoke((MethodInvoker)(() => label9.Text = parts[6]));
                        label5.Invoke((MethodInvoker)(() => label5.Text = "1-File size " + parts[2] + " 2-perc " + parts[0] + " 22-downloaded (" + Math.Round(downloaded, 2) + "MiB) 3-time left " + parts[6] + " 4-trandfer rate " + parts[4]));
                        progressBar1.Invoke((MethodInvoker)(() => progressBar1.Value = (int)ProcessNumber(parts[0])));
                    }
                }
                Thread.Sleep(500);
            }
        }


        private void btnStopUpdating_Click_1(object sender, EventArgs e)
        {
            isUpdating = false;
            if (updateThread != null && updateThread.IsAlive)
            {
                updateThread.Join();
            }

            this.Close();
        }
    }
}
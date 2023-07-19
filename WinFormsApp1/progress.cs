using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class progress : Form
    {
        public progress()
        {
            InitializeComponent();
        }
        public  void UpdateProgress(string eData)
        {
            // Extract the progress percentage and time left from the data
            // The actual format of the progress data might vary based on youtube-dl version
            // You may need to adjust this part accordingly.
            string progressData = eData.Replace("[download]", "").Trim();
            string[] parts = progressData.Split("ETA", StringSplitOptions.RemoveEmptyEntries);

            // Example of how the progress data might look: "42.7% of 20.00MiB at 1.20MiB/s ETA 00:05"
            string percentage = parts[0];
            string timeLeft = parts[1];
            // Assuming you have a progress bar control named "progressBar1"
            // You can update the progress bar value and display the time left
            // Here, we are just showing the progress information in a MessageBox.
            label1.Text = percentage + "%";
            //MessageBox.Show($"Progress: {percentage}% | Time Left: {timeLeft}");
        }
    }
}

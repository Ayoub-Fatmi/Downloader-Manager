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


namespace WinFormsApp1
{
    public partial class counterThread : Form
    {
        private Thread updateThread;
        private bool isUpdating = true;

        public counterThread()
        {
            Debug.WriteLine("10");
            InitializeComponent();
            // Start the update thread when the form loads
            updateThread = new Thread(UpdateLabelContinuously);
            updateThread.Start();
        }

        private void UpdateLabelContinuously()
        {
            Debug.WriteLine("2");

            int counter = 0;
            while (isUpdating)
            {
                // Update the label text in the separate thread
                string newText = "Counter: " + counter;

                // Use Invoke to update the label text on the main UI thread safely
                Debug.WriteLine("3");

                UpdateLabelSafe(newText);

                counter++;

                // Simulate a pause
                Thread.Sleep(1000); // Wait for 1 second before updating again
            }
        }

        private void UpdateLabelSafe(string text)
        {
            Debug.WriteLine("4");

            if (label1.InvokeRequired)
            {
                Debug.WriteLine("5");

                label1.Invoke((MethodInvoker)(() => label1.Text = text));
            }
            else
            {
                label1.Text = text;
            }
        }

        private void btnStopUpdating_Click(object sender, EventArgs e)
        {
            // Stop the update thread and close the form
            Debug.WriteLine("6");

            isUpdating = false;
            if (updateThread != null && updateThread.IsAlive)
            {
                Debug.WriteLine("7");

                updateThread.Join(); // Wait for the thread to finish before closing the form
            }

            this.Close();
        }
    }
}


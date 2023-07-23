namespace WinFormsApp1
{
    partial class ytbDownloader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            comboBoxQuality = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(230, 153);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Download";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(418, 23);
            textBox1.TabIndex = 1;
            // 
            // comboBoxQuality
            // 
            comboBoxQuality.DisplayMember = "1080p";
            comboBoxQuality.FormattingEnabled = true;
            comboBoxQuality.Items.AddRange(new object[] { "1080p", "720p", "480p", "360p", "240p", "144p", "mp3" });
            comboBoxQuality.Location = new Point(519, 115);
            comboBoxQuality.Name = "comboBoxQuality";
            comboBoxQuality.Size = new Size(121, 23);
            comboBoxQuality.TabIndex = 2;
            comboBoxQuality.Text = "720p";
            comboBoxQuality.ValueMember = "1080p";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 299);
            Controls.Add(comboBoxQuality);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private ComboBox comboBoxQuality;
    }
}
namespace WinFormsApp1
{
    partial class Form2
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
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(343, 229);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(99, 191);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(513, 23);
            textBox1.TabIndex = 1;
            // 
            // comboBoxQuality
            // 
            comboBoxQuality.DisplayMember = "1080p";
            comboBoxQuality.FormattingEnabled = true;
            comboBoxQuality.Items.AddRange(new object[] { "1080p", "720p", "480p", "360p", "240p", "144p", "mp3" });
            comboBoxQuality.Location = new Point(388, 109);
            comboBoxQuality.Name = "comboBoxQuality";
            comboBoxQuality.Size = new Size(121, 23);
            comboBoxQuality.TabIndex = 2;
            comboBoxQuality.Text = "720p";
            comboBoxQuality.ValueMember = "1080p";
            // 
            // button2
            // 
            button2.Location = new Point(553, 315);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
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
        private Button button2;
    }
}
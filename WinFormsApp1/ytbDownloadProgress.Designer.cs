namespace WinFormsApp1
{
    partial class ytbDownloadProgress
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
            label7 = new Label();
            btnStopUpdating = new Button();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(251, 101);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 7;
            label7.Text = "label7";
            // 
            // btnStopUpdating
            // 
            btnStopUpdating.Location = new Point(451, 116);
            btnStopUpdating.Name = "btnStopUpdating";
            btnStopUpdating.Size = new Size(75, 23);
            btnStopUpdating.TabIndex = 11;
            btnStopUpdating.Text = "Cancel";
            btnStopUpdating.UseVisualStyleBackColor = true;
            btnStopUpdating.Click += btnStopUpdating_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 58);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 12;
            label1.Text = "File Size:";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(124, 204);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(207, 23);
            progressBar1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 101);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 14;
            label2.Text = "Downloaded:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 139);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 15;
            label3.Text = "Transfer Rate:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 174);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 16;
            label4.Text = "Time left:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(251, 58);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 18;
            label6.Text = "label6";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(251, 139);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 19;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(251, 174);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 20;
            label9.Text = "label9";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 286);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 21;
            label5.Text = "label5";
            // 
            // progress
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 353);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(btnStopUpdating);
            Controls.Add(label7);
            Name = "progress";
            Text = "progress";
            Load += progress_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Button btnStopUpdating;
        private Label label1;
        private ProgressBar progressBar1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label5;
    }
}
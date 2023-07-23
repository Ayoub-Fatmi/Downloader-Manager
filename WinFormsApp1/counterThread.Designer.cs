namespace WinFormsApp1
{
    partial class counterThread
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
            btnStopUpdating = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnStopUpdating
            // 
            btnStopUpdating.Location = new Point(345, 257);
            btnStopUpdating.Name = "btnStopUpdating";
            btnStopUpdating.Size = new Size(75, 23);
            btnStopUpdating.TabIndex = 0;
            btnStopUpdating.Text = "button1";
            btnStopUpdating.UseVisualStyleBackColor = true;
            btnStopUpdating.Click += btnStopUpdating_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 180);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnStopUpdating);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStopUpdating;
        private Label label1;
    }
}
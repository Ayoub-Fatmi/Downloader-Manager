namespace WinFormsApp1
{
    partial class signUp
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
            sPasswordTB = new TextBox();
            sUsernameTB = new TextBox();
            label2 = new Label();
            label1 = new Label();
            signUpBut = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // sPasswordTB
            // 
            sPasswordTB.Location = new Point(197, 97);
            sPasswordTB.Name = "sPasswordTB";
            sPasswordTB.Size = new Size(100, 23);
            sPasswordTB.TabIndex = 9;
            // 
            // sUsernameTB
            // 
            sUsernameTB.Location = new Point(197, 51);
            sUsernameTB.Name = "sUsernameTB";
            sUsernameTB.Size = new Size(100, 23);
            sUsernameTB.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 100);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 7;
            label2.Text = "password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 51);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 6;
            label1.Text = "username";
            // 
            // signUpBut
            // 
            signUpBut.Location = new Point(129, 151);
            signUpBut.Name = "signUpBut";
            signUpBut.Size = new Size(75, 23);
            signUpBut.TabIndex = 10;
            signUpBut.Text = "SignUp";
            signUpBut.UseVisualStyleBackColor = true;
            signUpBut.Click += signUpBut_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 177);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 11;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // signUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 218);
            Controls.Add(label3);
            Controls.Add(signUpBut);
            Controls.Add(sPasswordTB);
            Controls.Add(sUsernameTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "signUp";
            Text = "signUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox sPasswordTB;
        private TextBox sUsernameTB;
        private Label label2;
        private Label label1;
        private Button signUpBut;
        private Label label3;
    }
}
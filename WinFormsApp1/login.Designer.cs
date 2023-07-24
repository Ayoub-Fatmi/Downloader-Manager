namespace WinFormsApp1
{
    partial class login
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
            label1 = new Label();
            label2 = new Label();
            usernameTB = new TextBox();
            passwordTB = new TextBox();
            loginBut = new Button();
            signUpBut = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 48);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 97);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "password";
            // 
            // usernameTB
            // 
            usernameTB.Location = new Point(200, 48);
            usernameTB.Name = "usernameTB";
            usernameTB.Size = new Size(100, 23);
            usernameTB.TabIndex = 2;
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(200, 94);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(100, 23);
            passwordTB.TabIndex = 3;
            // 
            // loginBut
            // 
            loginBut.Location = new Point(138, 142);
            loginBut.Name = "loginBut";
            loginBut.Size = new Size(75, 23);
            loginBut.TabIndex = 4;
            loginBut.Text = "login";
            loginBut.UseVisualStyleBackColor = true;
            loginBut.Click += loginBut_Click;
            // 
            // signUpBut
            // 
            signUpBut.Location = new Point(138, 188);
            signUpBut.Name = "signUpBut";
            signUpBut.Size = new Size(75, 23);
            signUpBut.TabIndex = 5;
            signUpBut.Text = "SignUp";
            signUpBut.UseVisualStyleBackColor = true;
            signUpBut.Click += signUpBut_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 225);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 7;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 271);
            Controls.Add(label4);
            Controls.Add(signUpBut);
            Controls.Add(loginBut);
            Controls.Add(passwordTB);
            Controls.Add(usernameTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "login";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernameTB;
        private TextBox passwordTB;
        private Button loginBut;
        private Button signUpBut;
        private Label label4;
    }
}
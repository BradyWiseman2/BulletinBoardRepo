namespace Bulletin_Board_Project
{
    partial class Login
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
            btnLogin = new Button();
            tBoxLoginUser = new TextBox();
            tBoxLoginPass = new TextBox();
            tBoxRegConfirm = new TextBox();
            tBoxRegPass = new TextBox();
            btnRegister = new Button();
            tBoxRegUser = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(212, 131);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(302, 23);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // tBoxLoginUser
            // 
            tBoxLoginUser.Location = new Point(212, 73);
            tBoxLoginUser.Name = "tBoxLoginUser";
            tBoxLoginUser.Size = new Size(302, 23);
            tBoxLoginUser.TabIndex = 2;
            // 
            // tBoxLoginPass
            // 
            tBoxLoginPass.Location = new Point(212, 102);
            tBoxLoginPass.Name = "tBoxLoginPass";
            tBoxLoginPass.PasswordChar = '*';
            tBoxLoginPass.Size = new Size(302, 23);
            tBoxLoginPass.TabIndex = 3;
            // 
            // tBoxRegConfirm
            // 
            tBoxRegConfirm.Location = new Point(212, 267);
            tBoxRegConfirm.Name = "tBoxRegConfirm";
            tBoxRegConfirm.PasswordChar = '*';
            tBoxRegConfirm.Size = new Size(302, 23);
            tBoxRegConfirm.TabIndex = 6;
            // 
            // tBoxRegPass
            // 
            tBoxRegPass.Location = new Point(212, 238);
            tBoxRegPass.Name = "tBoxRegPass";
            tBoxRegPass.PasswordChar = '*';
            tBoxRegPass.Size = new Size(302, 23);
            tBoxRegPass.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(212, 296);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(302, 23);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // tBoxRegUser
            // 
            tBoxRegUser.Location = new Point(212, 209);
            tBoxRegUser.Name = "tBoxRegUser";
            tBoxRegUser.Size = new Size(302, 23);
            tBoxRegUser.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 73);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 8;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 105);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 212);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 10;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(135, 241);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 11;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(108, 270);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 12;
            label5.Text = "Confirm Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 382);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tBoxRegUser);
            Controls.Add(tBoxRegConfirm);
            Controls.Add(tBoxRegPass);
            Controls.Add(btnRegister);
            Controls.Add(tBoxLoginPass);
            Controls.Add(tBoxLoginUser);
            Controls.Add(btnLogin);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox tBoxLoginUser;
        private TextBox tBoxLoginPass;
        private TextBox tBoxRegConfirm;
        private TextBox tBoxRegPass;
        private Button btnRegister;
        private TextBox tBoxRegUser;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
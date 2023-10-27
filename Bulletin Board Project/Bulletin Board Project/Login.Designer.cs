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
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(12, 210);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(302, 23);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // tBoxLoginUser
            // 
            tBoxLoginUser.Location = new Point(12, 152);
            tBoxLoginUser.Name = "tBoxLoginUser";
            tBoxLoginUser.Size = new Size(302, 23);
            tBoxLoginUser.TabIndex = 2;
            // 
            // tBoxLoginPass
            // 
            tBoxLoginPass.Location = new Point(12, 181);
            tBoxLoginPass.Name = "tBoxLoginPass";
            tBoxLoginPass.Size = new Size(302, 23);
            tBoxLoginPass.TabIndex = 3;
            // 
            // tBoxRegConfirm
            // 
            tBoxRegConfirm.Location = new Point(486, 210);
            tBoxRegConfirm.Name = "tBoxRegConfirm";
            tBoxRegConfirm.Size = new Size(302, 23);
            tBoxRegConfirm.TabIndex = 6;
            // 
            // tBoxRegPass
            // 
            tBoxRegPass.Location = new Point(486, 181);
            tBoxRegPass.Name = "tBoxRegPass";
            tBoxRegPass.Size = new Size(302, 23);
            tBoxRegPass.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(486, 239);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(302, 23);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // tBoxRegUser
            // 
            tBoxRegUser.Location = new Point(486, 152);
            tBoxRegUser.Name = "tBoxRegUser";
            tBoxRegUser.Size = new Size(302, 23);
            tBoxRegUser.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
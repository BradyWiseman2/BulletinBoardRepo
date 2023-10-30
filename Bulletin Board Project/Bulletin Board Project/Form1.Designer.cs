namespace Bulletin_Board_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lBoxTopics = new ListBox();
            btnPost = new Button();
            tBoxPost = new TextBox();
            btnTopic = new Button();
            lblUser = new Label();
            lBoxPosts = new ListBox();
            button1 = new Button();
            RefreshPostTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lBoxTopics
            // 
            lBoxTopics.FormattingEnabled = true;
            lBoxTopics.ItemHeight = 15;
            lBoxTopics.Location = new Point(12, 12);
            lBoxTopics.Name = "lBoxTopics";
            lBoxTopics.Size = new Size(261, 199);
            lBoxTopics.TabIndex = 0;
            lBoxTopics.SelectedIndexChanged += lBoxTopics_SelectedIndexChanged;
            // 
            // btnPost
            // 
            btnPost.Location = new Point(672, 216);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(116, 23);
            btnPost.TabIndex = 2;
            btnPost.Text = "Post Cringe";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // tBoxPost
            // 
            tBoxPost.Location = new Point(279, 216);
            tBoxPost.Name = "tBoxPost";
            tBoxPost.Size = new Size(389, 23);
            tBoxPost.TabIndex = 3;
            // 
            // btnTopic
            // 
            btnTopic.Location = new Point(12, 217);
            btnTopic.Name = "btnTopic";
            btnTopic.Size = new Size(261, 23);
            btnTopic.TabIndex = 5;
            btnTopic.Text = "New Topic";
            btnTopic.UseVisualStyleBackColor = true;
            btnTopic.Click += btnTopic_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(0, 385);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(166, 65);
            lblUser.TabIndex = 6;
            lblUser.Text = "label1";
            // 
            // lBoxPosts
            // 
            lBoxPosts.FormattingEnabled = true;
            lBoxPosts.HorizontalScrollbar = true;
            lBoxPosts.ItemHeight = 15;
            lBoxPosts.Location = new Point(279, 12);
            lBoxPosts.Name = "lBoxPosts";
            lBoxPosts.Size = new Size(509, 199);
            lBoxPosts.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 246);
            button1.Name = "button1";
            button1.Size = new Size(261, 23);
            button1.TabIndex = 7;
            button1.Text = "Refresh Topics";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RefreshPostTimer
            // 
            RefreshPostTimer.Interval = 1000;
            RefreshPostTimer.Tick += RefreshPostTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lblUser);
            Controls.Add(btnTopic);
            Controls.Add(tBoxPost);
            Controls.Add(btnPost);
            Controls.Add(lBoxPosts);
            Controls.Add(lBoxTopics);
            Name = "Form1";
            Text = "Gaming Board";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lBoxTopics;
        private Button btnPost;
        private TextBox tBoxPost;
        private Button btnTopic;
        private Label lblUser;
        private ListBox lBoxPosts;
        private Button button1;
        private System.Windows.Forms.Timer RefreshPostTimer;
    }
}
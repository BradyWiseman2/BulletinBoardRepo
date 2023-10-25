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
            lBoxTopics = new ListBox();
            lBoxPosts = new ListBox();
            btnPost = new Button();
            tBoxPost = new TextBox();
            tBoxTopic = new TextBox();
            btnTopic = new Button();
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
            // lBoxPosts
            // 
            lBoxPosts.FormattingEnabled = true;
            lBoxPosts.ItemHeight = 15;
            lBoxPosts.Location = new Point(279, 12);
            lBoxPosts.Name = "lBoxPosts";
            lBoxPosts.Size = new Size(509, 199);
            lBoxPosts.TabIndex = 1;
            // 
            // btnPost
            // 
            btnPost.Location = new Point(500, 250);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(106, 23);
            btnPost.TabIndex = 2;
            btnPost.Text = "Post Cringe";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // tBoxPost
            // 
            tBoxPost.Location = new Point(279, 250);
            tBoxPost.Name = "tBoxPost";
            tBoxPost.Size = new Size(215, 23);
            tBoxPost.TabIndex = 3;
            // 
            // tBoxTopic
            // 
            tBoxTopic.Location = new Point(12, 250);
            tBoxTopic.Name = "tBoxTopic";
            tBoxTopic.Size = new Size(261, 23);
            tBoxTopic.TabIndex = 4;
            // 
            // btnTopic
            // 
            btnTopic.Location = new Point(198, 279);
            btnTopic.Name = "btnTopic";
            btnTopic.Size = new Size(75, 23);
            btnTopic.TabIndex = 5;
            btnTopic.Text = "New Topic";
            btnTopic.UseVisualStyleBackColor = true;
            btnTopic.Click += btnTopic_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTopic);
            Controls.Add(tBoxTopic);
            Controls.Add(tBoxPost);
            Controls.Add(btnPost);
            Controls.Add(lBoxPosts);
            Controls.Add(lBoxTopics);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lBoxTopics;
        private ListBox lBoxPosts;
        private Button btnPost;
        private TextBox tBoxPost;
        private TextBox tBoxTopic;
        private Button btnTopic;
    }
}
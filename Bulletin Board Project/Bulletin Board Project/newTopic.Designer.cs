namespace Bulletin_Board_Project
{
    partial class newTopic
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
            tBoxTopicName = new TextBox();
            label2 = new Label();
            tBoxPostText = new TextBox();
            btnPostTopic = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Topic Name";
            // 
            // tBoxTopicName
            // 
            tBoxTopicName.Location = new Point(12, 27);
            tBoxTopicName.Name = "tBoxTopicName";
            tBoxTopicName.Size = new Size(503, 23);
            tBoxTopicName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Post Text";
            // 
            // tBoxPostText
            // 
            tBoxPostText.Location = new Point(12, 91);
            tBoxPostText.Multiline = true;
            tBoxPostText.Name = "tBoxPostText";
            tBoxPostText.Size = new Size(503, 198);
            tBoxPostText.TabIndex = 3;
            // 
            // btnPostTopic
            // 
            btnPostTopic.Location = new Point(12, 295);
            btnPostTopic.Name = "btnPostTopic";
            btnPostTopic.Size = new Size(503, 70);
            btnPostTopic.TabIndex = 4;
            btnPostTopic.Text = "Post Topic";
            btnPostTopic.UseVisualStyleBackColor = true;
            btnPostTopic.Click += btnPostTopic_Click;
            // 
            // newTopic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 366);
            Controls.Add(btnPostTopic);
            Controls.Add(tBoxPostText);
            Controls.Add(label2);
            Controls.Add(tBoxTopicName);
            Controls.Add(label1);
            Name = "newTopic";
            Text = "New Topic";
            FormClosed += newTopic_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tBoxTopicName;
        private Label label2;
        private TextBox tBoxPostText;
        private Button btnPostTopic;
    }
}
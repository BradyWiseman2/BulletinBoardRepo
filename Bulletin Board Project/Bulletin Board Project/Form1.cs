namespace Bulletin_Board_Project
{
    public partial class Form1 : Form
    {
        Board GAMING = new Board("GAMING");
        Post bruh = new Post("bruh", "bruh");
        Post bruh2 = new Post("bruh2", "bruh2");


        public Form1()
        {
            InitializeComponent();
            Board.BoardList.Add(GAMING);
            GAMING.topicList.Add(new Topic("topic1", bruh));
            GAMING.topicList.Add(new Topic("topic2", bruh2));
            GAMING.topicList.Add(new Topic("topic3", bruh));
            
            foreach( Topic topic in GAMING.topicList)
            {
                lBoxTopics.Items.Add(topic.TopicName);
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (lBoxTopics.SelectedItem != null)
            {
                Board.BoardList[0].topicList[lBoxTopics.SelectedIndex].posts.Add(new Post(
                   "GOD GAMER",
                   tBoxPost.Text));
            }
            else
            {

            }

        }

        private void btnTopic_Click(object sender, EventArgs e)
        {
            Board.BoardList[0].topicList.Add(
                new Topic
                (
                    tBoxTopic.Text,
                    new Post
                    (
                        "GAMER GOD",
                        tBoxPost.Text

                        )
                    ));
             
        }

        private void refreshlBoxes()
        {
            lBoxPosts.Items.Clear();
            lBoxTopics.Items.Clear();

        }

        private void lBoxTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            lBoxPosts.Items.Clear();
            foreach(Post post in GAMING.topicList[lBoxTopics.SelectedIndex].posts)
            {
                lBoxPosts.Items.Add(post.Text);
            }
        }
    }
}
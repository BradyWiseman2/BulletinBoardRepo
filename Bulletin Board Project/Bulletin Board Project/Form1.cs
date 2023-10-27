using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bulletin_Board_Project
{
    public partial class Form1 : Form
    {
        Board GAMING = new Board("GAMING");
        Post bruh = new Post("bruh", "bruh");
        Post bruh2 = new Post("bruh2", "bruh2");
        User LoggedInUser;

        public Form1(User user)
        {
            InitializeComponent();
            try
            {
                string text = File.ReadAllText("GAMING.json");
                GAMING = JsonConvert.DeserializeObject<Board>(text);
                dynamic o = JsonConvert.DeserializeObject<Board>(File.ReadAllText("GAMING.json"));
            }
            catch
            {
                GAMING = new Board("GAMING");
                GAMING.topicList.Add(new Topic("topic1", bruh));
                GAMING.topicList.Add(new Topic("topic2", bruh2));
                GAMING.topicList.Add(new Topic("topic3", bruh));
            }
            Board.BoardList.Add(GAMING);

            foreach (Topic topic in GAMING.topicList)
            {
                lBoxTopics.Items.Add(topic.TopicName);
            }
            LoggedInUser = user;
            lblUser.Text = LoggedInUser.UserName;

        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (lBoxTopics.SelectedItem != null)
            {
                GAMING.topicList[lBoxTopics.SelectedIndex].posts.Add(new Post(
                   LoggedInUser.UserName,
                   tBoxPost.Text));              
            }       
            string output = JsonConvert.SerializeObject(GAMING);
          
            File.WriteAllText(GAMING.BoardName + ".json", output);
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
            lBoxTopics.Items.Add(GAMING.topicList.Last().TopicName);


        }

        private void refreshlBoxes()
        {

            lBoxPosts.Items.Add(LoggedInUser.UserName + ": " + GAMING.topicList[lBoxTopics.SelectedIndex].posts.Last().Text
                     + GAMING.topicList[lBoxTopics.SelectedIndex].posts.Last().PostDate.ToString());

        }

        private void lBoxTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            lBoxPosts.Items.Clear();
            try
            {
                foreach (Post post in GAMING.topicList[lBoxTopics.SelectedIndex].posts)
                {
                    lBoxPosts.Items.Add(post.Text);
                }
            }
            catch
            {

            }


        }
    }
}
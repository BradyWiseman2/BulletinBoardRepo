using Newtonsoft.Json;
using System.Runtime.CompilerServices;
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
                string text = File.ReadAllText("T:\\Gamin\\GAMING.json");
                GAMING = JsonConvert.DeserializeObject<Board>(text);
                dynamic o = JsonConvert.DeserializeObject<Board>(File.ReadAllText("T:\\Gamin\\GAMING.json"));
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
            lblUser.Text = "Logged in as: " + LoggedInUser.UserName;

        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (lBoxTopics.SelectedItem != null && tBoxPost.Text != "")
            {
                GAMING.topicList[lBoxTopics.SelectedIndex].posts.Add(new Post(
                   LoggedInUser.UserName,
                   tBoxPost.Text));
                Save();
                RefreshPosts();
                tBoxPost.Text = "";

            }
            else
            {
                MessageBox.Show("Type something");
            }


        }

        private void btnTopic_Click(object sender, EventArgs e)
        {
            newTopic topicmaker = new newTopic(LoggedInUser, GAMING);
            topicmaker.Show();

            topicmaker.FormClosed += Topicmaker_FormClosed;

        }

        private void Topicmaker_FormClosed(object? sender, FormClosedEventArgs e)
        {

            lBoxTopics.Items.Clear();
            foreach (Topic topic in GAMING.topicList)
            {
                lBoxTopics.Items.Add(topic.TopicName);
            }
        }

        private void RefreshPosts()
        {
            lBoxPosts.Items.Clear();
            foreach (string post in GAMING.topicList[lBoxTopics.SelectedIndex].UpdatePosts())
            {
                lBoxPosts.Items.Add(post);
            }
        }
        private void Save()
        {
            string output = JsonConvert.SerializeObject(GAMING);
            File.WriteAllText("T:\\Gamin\\" + GAMING.BoardName + ".json", output);
        }



        private void lBoxTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            lBoxPosts.Items.Clear();
            try
            {
                foreach (string post in GAMING.topicList[lBoxTopics.SelectedIndex].UpdatePosts())
                {
                    lBoxPosts.Items.Add(post);
                }
            }
            catch
            {

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            lBoxTopics.Items.Clear();
            foreach (Topic topic in GAMING.topicList)
            {
                lBoxTopics.Items.Add(topic.TopicName);
            }
        }
    }
}
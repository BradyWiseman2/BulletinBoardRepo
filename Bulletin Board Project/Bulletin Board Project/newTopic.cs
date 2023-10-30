using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bulletin_Board_Project
{
    public partial class newTopic : Form
    {
        User LoggedInUser;
        Board ActiveBoard;

        public newTopic(User loggedin, Board activeBoard)
        {
            InitializeComponent();
            LoggedInUser = loggedin;
            ActiveBoard = activeBoard;
        }

        private void btnPostTopic_Click(object sender, EventArgs e)
        {
            if (tBoxPostText.Text != "" && tBoxTopicName.Text != "")
            {
                Topic newtopic = new Topic(tBoxTopicName.Text,
                new Post(LoggedInUser.UserName, tBoxPostText.Text));
                ActiveBoard.topicList.Add(newtopic);
                string output = JsonConvert.SerializeObject(ActiveBoard);
                File.WriteAllText(ActiveBoard.BoardName + ".json", output);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ya gotta type something in both boxes");
            }
        }

        private void newTopic_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulletin_Board_Project
{
     public class Topic
    {
        private string topicName;
        public List<Post> posts;
        public string TopicName { get { return topicName; } set { this.topicName = value; } }
        public string CreatedBy { get { return posts[0].Username; } }
        public DateTime LastPost { get { return posts.Last().PostDate; } }

        public int Posts { get { return posts.Count; } }

        public Topic(string tName, Post firstpost)
        {
            topicName = tName;
            posts = new List<Post>();
            posts.Add(firstpost);
        }

        public List<string> UpdatePosts()
        {
            List<string> strings = new List<string>();
            foreach (Post post in posts)
            {
                string final = "";
                final += post.PostDate.ToShortDateString();
                final += " ";
                final += post.Username;
                final += ": ";
                final += post.Text;
                strings.Add(final);

            }
            return strings;
        }
    }
}

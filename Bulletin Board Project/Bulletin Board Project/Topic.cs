using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulletin_Board_Project
{
    class Topic
    {
        private string topicName;
        private List<Post> posts;
        public string TopicName { get { return topicName; } }
        public string CreatedBy { get { return posts[0].Username; } }
        public DateTime LastPost { get { return posts.Last().PostDate; } }

        public int Posts { get { return posts.Count; } }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulletin_Board_Project
{
    class Board
    {
        public static List<Board> BoardList = new List<Board>();
        private string boardName;
        private List<Topic> topicList;

        public int Topics { get {  return topicList.Count; } }
        public int Messages
        {
            get
            {
                int count = 0;
                foreach (Topic topic in topicList)
                {
                    count += topic.Posts;
                }
                return count;
            }
        }    
                 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulletin_Board_Project
{
     public class Board
    {
        public static List<Board> BoardList = new List<Board>();
        private string boardName;
        public List<Topic> topicList;

        public int Topics { get {  return topicList.Count; } }
        public string BoardName { get { return boardName; } set { this.boardName = value; } }

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
        
        public Board(string bname)
        {                      
                boardName = bname;
                topicList = new List<Topic>();            
        }
      
        
                 
    }
}

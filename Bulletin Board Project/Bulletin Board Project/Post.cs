using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulletin_Board_Project
{
    public class Post
    {
        private DateTime postDate = DateTime.Now;
        private string username;
        private string text;
      
        public string Username { get { return username; } set { this.username = value; } }
        public DateTime PostDate { get { return postDate; } set { this.postDate = value; } }
        
        public string Text { get { return text; } set { this.text = value; } } 

        public Post(string _username, string _text)
        {
            username = _username;
            text = _text;
        }


    }
}

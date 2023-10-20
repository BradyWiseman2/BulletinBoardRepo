using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulletin_Board_Project
{
    class Post
    {
        private DateTime postDate = DateTime.Now;
        private string username;
        private string text;
      
        public string Username { get { return username; } }
        public DateTime PostDate { get { return postDate; } }

        public Post(string _username, string _text)
        {
            username = _username;
            text = _text;
        }


    }
}

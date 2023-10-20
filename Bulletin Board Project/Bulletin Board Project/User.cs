using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Bulletin_Board_Project
{
    enum PermissionLevel
    {
        User,
        Moderator,
        Admin
    }
    class User
    {
        private string _username;
        private string _password;
        private DateTime _accCreated = DateTime.Now;
        private PermissionLevel _permLevel;

        public string UserName { get { return _username; } }
        public string Password { get { return _password; } }
        public DateTime UserSince { get { return _accCreated;} }
        public PermissionLevel PermissionLevel { get { return _permLevel;} }

        public User(string username, string password, PermissionLevel permLevel)
        {
            _username = username;
            _password = UserHelper.Md5Hash(password);
            _permLevel = permLevel;
        }

       

    //    public Post MakePost(string boardname, string topicname, string bodytext)
    //    {
    //        Post bruh = new Post(UserName, bodytext);
            
    //        return bruh;
    //    }
   }
}   

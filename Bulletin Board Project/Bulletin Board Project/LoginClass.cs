using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Bulletin_Board_Project
{//stolen code poggers
    public static class UserHelper
    {
        public static string Md5Hash(string md5Hash)
        {
            string ret = "";

            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(md5Hash);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                ret = Convert.ToHexString(hashBytes);
            }
            return ret;
        }

        public static bool Login(string username, string password)
        {
            //See if a file exists
            if (File.Exists(username + ".json"))
            {
                //Deserialze form disk, to check password
                User u = JsonConvert.DeserializeObject<User>(File.ReadAllText(username + ".json"));
                string test = Md5Hash(password);
                string test2 = u.Password;
                if (test == test2)
                {
                    //login success
                    return true;
                }
            }
            else
                return false;

            return false;
        }

        public static bool Register(string username, string password)
        {
            bool result = false;
            //Come back and make sure no duplicate exists
            if (File.Exists(username + ".json"))
            {
                return false;
            }

            User u = new User(username, password, PermissionLevel.User);
            
             
            

            //Serialze the user to a file on disk
            string output = JsonConvert.SerializeObject(u);
            //Save that object to disk
            File.WriteAllText(username + ".json", output);
            result = true;

            return result;
        }
    }
}

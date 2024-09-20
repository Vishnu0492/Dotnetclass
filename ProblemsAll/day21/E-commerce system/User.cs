using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_system
{
    internal class User
    {
        public string username;
        public string password;
        public string email;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        { get { return password; } 
        set { password = value; }
        }
        public string Email
        { get { return email; }
            set { email = value; }
        }
        public User(string username,string password,string email)
        {
            this.username = username;
            this.password = password;
            this.email = email;

        }
        public void UpdateUser(string newusername, string newpassword, string newemail)
        {
            username = newusername;
           password = newpassword;
            email = newemail;

        }
        public override string ToString()
        {
            return $"Username:{username}, Email:{email}";
        }
       
        // Method to display user information
        public void DisplayUser()
        {
            Console.WriteLine($"Username: {Username}, Email: {Email}");
        }
    }
}

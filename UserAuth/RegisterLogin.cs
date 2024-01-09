using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAuth
{
    public class RegisterLogin
    {
        private List<UserAuthenticator> users;

        public RegisterLogin()
        {
            // Initialize the list of users in the constructor
            users = new List<UserAuthenticator>();
        }

        public bool Register(string user, string pass)
        {
            // Check if the username already exists
            if (users.Any(u => u.Username == user))
            {
                Console.WriteLine("Username already exists. Registration failed.");
                return false;
            }

            // Create a new user and add it to the list
            UserAuthenticator newUser = new UserAuthenticator() { Username = user, Password = pass };
            users.Add(newUser);

            Console.WriteLine("Registration successful!");
            return true;
        }

        public bool Login(string username, string password)
        {
            // Check if the username and password match any user in the list
            foreach (var user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    Console.WriteLine("Login Successful");
                    return true;
                }
            }

            Console.WriteLine("Login Failed");
            return false;
        }
    }
}
    


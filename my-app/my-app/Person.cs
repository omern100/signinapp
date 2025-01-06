using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_app
{
    public class Person
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }

        private static int _idCounter = 1;

        public List<Message> Messages { get; set; }

        public int ID { get; private set; }


        public Person(string username, string password, string email, string fullName)
        {
            Username = username;
            Password = password;
            Email = email;
            FullName = fullName;
            ID = _idCounter++;
            Messages = new List<Message>();

        }
    }

}

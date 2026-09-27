using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyManagement
{
    internal class User
    {
        private string name;
        private string gender;
        private string email;
        private string password;

        public User() { }

        public User(string name, string gender, string email, string password)
        {
            this.name = name;
            this.gender = gender;
            this.email = email;
            this.password = password;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}

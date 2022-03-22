using System;
using System.Collections.Generic;
using System.Text;

namespace Facebook.Models
{
    class User
    {
        string Name;
        string Surname;
        string Email;
        string DateOfBirth;
        bool IsSingle;
        public Post[] Posts;

        public User(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }
        public User()
        {

        }
        public User(string email)
        {
            Email = email;
        }

    }
}

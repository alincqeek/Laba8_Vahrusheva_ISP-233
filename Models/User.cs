
using Base;
using System;
using System.Xml.Linq;

namespace MyApp
{
    internal class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }

        public User(string name, string email, bool isActive)
        {
            Name = name;
            Email = email;
            IsActive = isActive;
        }

        public void Print()

        {

            Console.WriteLine($"Имя: {Name}  Email: {Email}  IsActive:{IsActive} ");




        }
    }
}
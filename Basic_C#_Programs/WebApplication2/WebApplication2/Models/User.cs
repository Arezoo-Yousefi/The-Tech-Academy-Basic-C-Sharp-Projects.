using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class User
    {
        public User(int id, string FName, string LName, int age) {
            Id = id;
            FirstName = FName;
            LastName = LName;
            Age = age;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public int Age { get; set; }
    }
}
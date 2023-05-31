﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class PersonClass
    {
       
        public string firstName { get; set; }
        public string lastName { get; set; }
        public void SayName()
        {//method takes no parameters and simply writes the person's full name to the console
            Console.WriteLine($"Name: {this.firstName} {lastName}");
        }
    }
}
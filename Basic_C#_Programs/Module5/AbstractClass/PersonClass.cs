using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class PersonClass   // class called Person with two properties
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public abstract void SayName();
        
    }
}

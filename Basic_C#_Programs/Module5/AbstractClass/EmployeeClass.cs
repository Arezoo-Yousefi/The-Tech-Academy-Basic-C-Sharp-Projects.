using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class EmployeeClass: PersonClass   // inherit from the Person class.
    {
        public int id { get; set; }
        public override void SayName()  //Implement the SayName() method
        {
            string name = this.firstName + " " + lastName;
            Console.WriteLine(name);
        }
    }
}

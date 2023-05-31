using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class EmployeeClass:PersonClass,IQuittableInterface  //inherit from personClass and IQuitableInterface
    {
        public EmployeeClass(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        
        public void Quit() //impliment quit method from Interface
        {
            string name = firstName + " " + lastName;
            Console.Write(name+" "+"are you sure to quit?");
        }
    }
}

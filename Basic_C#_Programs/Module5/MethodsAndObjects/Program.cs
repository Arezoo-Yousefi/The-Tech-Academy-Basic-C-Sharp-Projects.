using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //nstantiate and initialize an Employee object
            EmployeeClass employee = new EmployeeClass() {firstName= "Sample", lastName="Student"};
            employee.SayName();   //Call the superclass method SayName()
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeClass employee = new EmployeeClass(); //instantiate an Employee objec
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName();//call the abstract method
            Console.Read();
        }
    }
}

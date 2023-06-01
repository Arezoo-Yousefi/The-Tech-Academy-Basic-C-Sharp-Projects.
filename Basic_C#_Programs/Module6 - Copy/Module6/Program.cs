using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeClass employeeOne = new EmployeeClass() { id = 132 };//instantiate two objects of the Employee
            EmployeeClass employeeTwo = new EmployeeClass() { id = 132 };
            bool isTheSame = (employeeOne == employeeTwo); //using ==

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    public class EmployeeClass
    { 
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public static bool operator ==(EmployeeClass employeeOne, EmployeeClass employeeTwo)
        {
            bool b = employeeTwo.id == employeeOne.id; // overload the “==” operator so it checks if two Employee objects are equal 
            return b;
        }
        public static bool operator !=(EmployeeClass employeeOne, EmployeeClass employeeTwo)
        {
            return employeeTwo.id != employeeOne.id; //comparison operators must be overloaded in pairs
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeClass<string> employee1 = new EmployeeClass<string>(new string[5] { "Camputer", "Mobile Phone", "Back Pack", "Pencil", "Printer" });
            
            EmployeeClass<int> employee2 = new EmployeeClass<int>(new int[4] { 2,4,3,5});
            

            employee1.Print();
            employee2.Print();
            Console.Read();
        }
    }
}

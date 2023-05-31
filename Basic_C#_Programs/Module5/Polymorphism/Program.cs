using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            //create an object of type IQuittable and call the Quit() method on it
            IQuittableInterface quittable = new EmployeeClass("Arezoo","Yousefi");
            quittable.Quit();
            Console.Read();

        }
    }
}

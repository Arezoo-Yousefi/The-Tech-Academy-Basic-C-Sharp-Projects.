using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyClass obj = new MyClass();//instantiate the class.
            obj.Mathoperation(3, 2);//Call the method in the class passing in two numbers
            Console.Write("enter a number: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int randomPower = random.Next(0, 10);//return a random number as the power
            obj.Mathoperation(numberOne, randomPower);//Call the method in the class, specifying the parameters by name.

            Console.Read();


        }
    }
}

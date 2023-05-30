using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass objOne = new MyClass();
            MyClass.testOne = 12;
            Console.Write("enter a number: ");//Have the user enter a number
            int numberOne = Convert.ToInt32(Console.ReadLine());
            int numberTwo = 1;
            objOne.dividenBytwo(numberOne, out numberTwo);//Call the method on that number
            Console.WriteLine($"{numberOne} divided by 2 equals to {numberTwo}.");


            int resultOne = 0;
            double resultTwo = 0;
            int resultThree = 0;
            objOne.addition(3, 5,out resultOne);
            Console.WriteLine($"3 + 5 = {resultOne}");
            objOne.addition(3.57, 3.46, out resultTwo);
            Console.WriteLine($"3.57 + 3.46 = {resultTwo}");
            objOne.addition(5, 7, 114, out resultThree);
            Console.WriteLine($"5 + 7 + 114 = {resultThree}");
            MyClass.test();


            int z = ClassStatic.testIt(5, 8);//call a static class with out instance of the class.
            Console.WriteLine(z);
            Console.Read();
        }
    }
}

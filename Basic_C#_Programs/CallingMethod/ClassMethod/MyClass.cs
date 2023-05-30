using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    class MyClass
    {
        public void dividenBytwo(int num, out int divided)//create a void method that outputs an integer
        {
            divided = num / 2;// the method divide the data passed to it by 2
        }
        public void addition(int numOne, int numTwo, out int result)//Overload a method.
        {
            result = numOne + numTwo;
        }
        public void addition(int numOne, int numTwo, int numThree, out int result)//Overload a method.
        {
            result = numOne + numTwo+ numThree;
        }
        public void addition(double numOne, double numTwo,out double result)//Overload a method.
        {
            result = numOne + numTwo+ testOne;
            
        }
        static public int testOne = 5;
        public static void test()//test for static method
        {
            Console.WriteLine($"This is a test {testOne}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class MyClass
    {
        public void Mathoperation(int numOne, int power)// create a void method that takes two integers as parameters
        {
            int template = numOne;
            switch (power)//this method return a number to the power of number
            {
                case 0://if power is 0
                    power = 0;
                    numOne = 1;
                    break;
                case 1://if power is 1
                    break;
                default://if power is more than 1
                    for (int i = 0; i <= power - 2; i++)
                    {
                        numOne *= template;//math operation on the first integer 
                    }
                    break;
            }
            
            Console.WriteLine($"{template} to the power of {power} is {numOne}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            bool intNum = false;
            while (!intNum){//continue asking for the correct number
                try{//if there is any error in type of the number it will return a message
                    Console.Write("Please enter the side of Square: ");
                    int sideSize = Convert.ToInt32(Console.ReadLine());
                    Methods obj = new Methods();
                    int resultOne = obj.SquareArea(sideSize);

                    int resultTwo = obj.SquareParameter(sideSize);
                    Console.WriteLine($"The area of a square with the side size of {sideSize} is {resultOne},\nThe Parameter of this square is {resultTwo}.");
                    intNum = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.ReadLine();
        }
    }
}

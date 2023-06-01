using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberStruct number = new NumberStruct();// create an object of data type Number
            number.Amount = 12.45m;
            Console.WriteLine(number.Amount);//print the amount to the console
            Console.Read();
        }
    }
}

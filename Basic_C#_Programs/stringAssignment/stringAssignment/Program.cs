using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "HELLO WORLD!!";
            string b = "This is a message from";
            Console.Write("Enter your name please:");
            string c = Console.ReadLine().ToUpper();
            
            Console.WriteLine(a+" "+ b+" "+ c);//concatenate three string
            

            StringBuilder newParagraph = new StringBuilder();//allocate memory 
            newParagraph.Append("here is what we are trying to learn about string builder. ");// adding to the string
            Console.WriteLine(newParagraph);
            Console.WriteLine("add whatever you would like:");
            newParagraph.Append(Console.ReadLine());
            Console.WriteLine(newParagraph);
            Console.ReadLine();
        }
    }
}

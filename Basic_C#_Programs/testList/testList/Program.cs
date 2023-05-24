using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[4] { "Arezoo", "Ali", "Parmida", "Mantra" };//arrey of names
            Console.Write("enter a number: ");
            int index = Convert.ToInt32(Console.ReadLine());
            if (index >= 4)
            {
                Console.WriteLine($"The List length is less than {index}");//Add in a message that displays when the user selects an index that doesn’t exist.

            }
            else
            {
                Console.WriteLine(names[index]);
            }
            int[] numbers = new int[10] { 23, 51, 35, 86, 14, 90, 88, 42, 69, 75 };
            Array.Sort(numbers);
            Console.Write("enter a number between 0 to 9: ");
            Console.WriteLine($"The number in this index is: {numbers[Convert.ToInt32(Console.ReadLine())]}");

            //Create a list of strings. Ask the user to select an index of the list and then display the content at that index on the screen.
            List<string> LName = new List<string>();
            bool addList = true;
            while (addList)
            {
                Console.Write("enter a last name to add to the list: ");
                string fResult = (Console.ReadLine());
                if (fResult == "")
                {
                    addList = false;
                    Console.Write($"Enter an index between 0 to {LName.Count() - 1}:");
                    var myIndex = Console.ReadLine();
                    int result = Convert.ToInt32(myIndex);
                    Console.WriteLine($"Family name in this index is {LName[result]}");
                    Console.Read();
                }
                LName.Add(fResult);
            }
        }
    }
}

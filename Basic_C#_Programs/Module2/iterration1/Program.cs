using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterration1
{
    class Program
    {
        static void Main(string[] args)
        {
            //part 1
            string[] life = new string[5] { "Love", "Money", "Health", "Freedom", "Happiness" }; //A one-dimensional array of strings

            Console.Write("Write a text about life: ");
            string result = Console.ReadLine();//Ask the user to input some text.
            for (int i = 0; i < life.Length; i++)
            {
                life[i] += " " + result;//A loop that iterates through each string in the array and adds the user's text input to the end of each string.
            }
            foreach (string part in life)//second loop that prints off each string in the array one at a time
            {
                Console.WriteLine(part);

            }

            //Part2
            for (int i = 0; i >= 0; i++)//an infinite loop because condition is always true;
            {
                try
                {
                    string resultPart2 = (life[i] == "Love") ? "Yes" : "No";
                    Console.WriteLine(resultPart2);

                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {i}");//stop the infite loop
                    break;
                }

            }

            //part 3
            List<double> grades = new List<double>();
            string resultPart3;
            do
            {
                Console.Write("add your score to calculate the avrage: ");
                resultPart3 = Console.ReadLine();
                if (resultPart3 != "")
                {
                    try
                    {

                        double score = Convert.ToDouble(resultPart3);
                        grades.Add(score);
                    }
                    catch
                    {
                        Console.WriteLine($"{resultPart3} is not in format of number it should be in format of **.**");
                    }
                }
            } while (resultPart3 != "");
            double avg = 0;
            double total = 0;
            for (int i = 0; i < grades.Count; i++) //A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.

            {
                total += grades[i];
            }
            for (int i = 1; i <= grades.Count; i++) //“<=” operator.
            {
                Console.WriteLine(grades[i - 1]);
            }
            avg = total / grades.Count;
            Console.WriteLine($"the average is {(float)avg}");

            //part 4

            List<string> ClassNames = new List<string> { "Arezoo", "Ali", "Zoey", "Alice", "Eden", "Emet" };
            Console.WriteLine("enter a name to see if this is in our list");
            string typedName = Console.ReadLine();
            bool isFound = false;
            foreach (string name in ClassNames)
            {
                if (name == typedName)
                {
                    //displays the index of the list item that contains matching text on the screen.
                    Console.WriteLine($"{typedName} is in our list and the index is {ClassNames.IndexOf(name)}");
                    isFound = true;//Add code that stops the loop from executing once a match has been found
                    break;
                }
            }
            if (!isFound)//Add code to check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list.
            {
                Console.WriteLine("The Name is not in the list.");
            }

            //part 5

            //A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.
            List<string> myFavoriteFruits = new List<string> { "Apple", "Cherry", "Strawberry", "Pomegranate", "Melon", "Cherry" };
            Console.Write("Select a fruit to see if it is in our favorite list: ");
            string selectedFruit = Console.ReadLine();


            bool selectedIndex = false;

            for (int i = 0; i < myFavoriteFruits.Count; i++)
            {
                if (myFavoriteFruits[i] == selectedFruit)
                {
                    Console.WriteLine($"The index of {selectedFruit} is {i}");
                    selectedIndex = true;
                }
            }
            if (!selectedIndex)
            //Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list. 
            {
                Console.WriteLine($"there is no matching item in the list with the name {selectedFruit}");
            }


            //part 6
            List<char> letters = new List<char>() { 'a', 's', 'd', 'f', 'g', 'k', 's' };
            List<char> uniqueLetters = new List<char>();

            //Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            foreach (char letter in letters)
            {
                int count = 0;
                foreach (char lett in uniqueLetters)
                {
                    if (letter == lett)
                    {
                        count += 1;
                        break;
                    }
                }
                if (count >= 1)
                {
                    Console.WriteLine($"{letter} is not unique");
                }
                else
                {
                    Console.WriteLine($"{letter} is unique");
                    uniqueLetters.Add(letter);
                }
            }
                
            
            Console.ReadLine();
        }
    }
}

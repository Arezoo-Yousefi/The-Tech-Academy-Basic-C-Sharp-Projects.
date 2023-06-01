using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Please enter the current day: ");//Prompt the user to enter the current day of the week.

            bool rightDay = false;
            while (!rightDay) {
                try
                {
                    string currentDayString = Console.ReadLine();
                    currentDayString = char.ToUpper(currentDayString[0]) + currentDayString.Substring(1); 
                    WeekDayClass weekDay = new WeekDayClass();
                    weekDay.day = (WeekDayClass.weekDaysEnum)Enum.Parse(typeof(WeekDayClass.weekDaysEnum), currentDayString);
                    //Assign the value to a variable of that enum data type you just created.


                    int dayInt = Convert.ToInt32(weekDay.day)+1;
                    Console.WriteLine("Have a nice " + weekDay.day + " This is the "+ dayInt + "th day of the week");
                    rightDay = true;

                }
                catch {
                    Console.Write("Please enter actual day: ");
                }
            }
            Console.ReadLine();
        }
    }
}

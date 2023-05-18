using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your age?");
            //int yourAge = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Have you ever had a DUI?(yes or no answer)");
            //string yesOrNo = (Console.ReadLine()).ToLower();
            //bool haveDUI = (yesOrNo=="yes");
            //Console.WriteLine("How many speeding tickets do you have?");
            //int speedTicket = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("qualified?");
            //Console.WriteLine(yourAge > 14 && !haveDUI  && speedTicket <=3);//applicant must be over 14
            ////and must not have DUI and must not have more than 3 speed ticket
            //Console.Read();
            //if and else statement
            //Console.WriteLine("What is your Name?");
            /*string yourName = Console.ReadLine();
            char.ToUpper(yourName[0]);
            
            yourName = char.ToUpper(yourName[0])+ yourName.Substring(1);
            Console.WriteLine(yourName);
            if (yourName == "Arezoo" || yourName == "Ali" || yourName == "Parmida" || yourName == "Mantra")
            {
                Console.WriteLine("You are in the family");
            }
            else if(yourName != "Zohreh")
            {
                Console.WriteLine("You are not Arezoo's lovely sister");
            }
            else Console.WriteLine("You are Arezoo's sister");*/
            const double piNumber = 3.14;
            Console.WriteLine("enter the radius");
            string radiusStringType = Console.ReadLine();
            double radius = Convert.ToDouble(radiusStringType);
            //if (radius > 0)
            //{
            //    Console.WriteLine("The amount of Area is " + radius * radius * piNumber);
            //}
            //else if (radius < 0)
            //{
            //    Console.WriteLine("There is no real circle");
            //}
            //else Console.WriteLine("this is a dot!!");
            string result = radius > 0 ? "The amount of Area is " + radius * radius * piNumber : "There is no real circle";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

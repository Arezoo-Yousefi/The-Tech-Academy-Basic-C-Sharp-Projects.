using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AnException
{
    class Program
    {
        static void Main(string[] args)
        {
            try //Exceptions must be handled using “try/catch.”
            {
                GetAge();
                

            }
            catch (AgeException ex)//if the age is more than 100 or negative number 
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                return;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                return;
            }
            Console.ReadLine();
        }
        public static int GetAge()
        {
            bool validAnswer = false;
            int age = 0;
            while (!validAnswer)
            {
                Console.WriteLine("Enter your age:");//Ask the user for their age.
                validAnswer = int.TryParse(Console.ReadLine(), out age);//return a boolean
                if (validAnswer)
                {
                    Console.WriteLine($"your year of birth is {DateTime.Today.AddYears(-age).Year}");
                    //Display the year the user was born.
                }



                if (!validAnswer)
                {
                    Console.WriteLine("Enter a valid age");
                    break;
                }
                if (age <= 0 || age > 100) throw new AgeException("your age is more than 100 or under zero");
                Console.ReadLine();
            }
            return age;

        }
    }
}



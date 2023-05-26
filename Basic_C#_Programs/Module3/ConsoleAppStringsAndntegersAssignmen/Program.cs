using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStringsAndntegersAssignmen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> randomNum = new List<int>() {12,34,25,73,54,76};//list of integers
            Console.Write("Pick a number: ");//ask the user to select a number
            try { 
                int divideBy = Convert.ToInt32(Console.ReadLine());
                    foreach (int num in randomNum)
                    {
                        try//division by zero
                        {
                            int resultOne = num / divideBy;
                            Console.WriteLine(resultOne);
                        } catch (DivideByZeroException ex)
                        {
                            Console.WriteLine("It is not possible to divide by zero:" + ex.Message);
                            break;
                    }
                    finally
                    {
                        Console.WriteLine("finally after division by zero");
                        Console.ReadLine();
                    }
                    
                    }
            }
            //this part is for catching the error related to the format of input
            //catch(FormatException ex)
            //{
            //    Console.WriteLine("It should be a number!!!");
            //}
            catch(Exception ex)//each kind of exception
            {
                Console.WriteLine(ex.Message);
                //throw ex;
            }
            finally  //in either case  it will run;
            {
                Console.WriteLine("finally nothing happened");

                Console.Read();
            }

            Console.Read();
        }
    }
}

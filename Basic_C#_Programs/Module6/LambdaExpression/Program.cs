using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            List<EmployeeStruct> employees = new List<EmployeeStruct>()
            {  //create a list of at least 10 employees
                new EmployeeStruct(){id = 5, firstName="Ali", lastName="Miri"},
                new EmployeeStruct(){id = 7, firstName="Arezoo", lastName="Yousefi"},
                new EmployeeStruct(){id = 10, firstName="Parmida", lastName="Miri"},
                new EmployeeStruct(){id = 11, firstName="Mantra", lastName="Miri"},
                new EmployeeStruct(){id = 6, firstName="Ali", lastName="Rezayee"},
                new EmployeeStruct(){id = 17, firstName="Joe", lastName="wolfe"},
                new EmployeeStruct(){id = 18, firstName="Alex", lastName="Soofi"},
                new EmployeeStruct(){id = 9, firstName="Eden", lastName="Hamidi"},
                new EmployeeStruct(){id = 20, firstName="Ali", lastName="Hasani"},
                new EmployeeStruct(){id = 1, firstName="Joe", lastName="Ashgar"},
                new EmployeeStruct(){id = 22, firstName="Arezoo", lastName="Noodi"}
            };
            List<EmployeeStruct> employeesJoe = new List<EmployeeStruct>();
            foreach(EmployeeStruct emp in employees)
            { //Using a foreach loop, create a new list of all employees with the first name “Joe”.
                if (emp.firstName == "Joe")
                {
                    employeesJoe.Add(emp);
                }
            }
            //Perform the same action again, but this time with a lambda expression
            List<EmployeeStruct> employeeAlis = employees.Where(emp => emp.firstName == "Ali").ToList();
            int sum = employeeAlis.Count();
            Console.WriteLine(sum);

            List<EmployeeStruct> employeeIdgreaterthan5 = new List<EmployeeStruct>();

            //make a list of all employees with an Id number greater than 5.
            employeeIdgreaterthan5 = (employees.Where(emp => emp.id > 5)).ToList();
            int sum2 = employeeIdgreaterthan5.Count();
            Console.WriteLine($"The number of employees with id greater than 5 is {sum2}");
            Console.Read();
            


        }
    }
}

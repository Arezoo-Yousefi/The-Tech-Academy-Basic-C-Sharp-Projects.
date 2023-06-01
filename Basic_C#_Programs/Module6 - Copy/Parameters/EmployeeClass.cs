using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    public class EmployeeClass<T>
    {
        public EmployeeClass()
        {
            things = new List<T>();

        }
        public EmployeeClass(T[] objs)
        {
            things = new List<T>();
            foreach (T obj in objs)
            {
                things.Add(obj);
            }
        }
        public void Add(T obj)
        {
            things.Add(obj);
        }
       private List<T> things { get; set; }
        public void Print()
        {
            foreach (T thing in things)
            {
                Console.WriteLine(thing);

            }
        }
    }
}

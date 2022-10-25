using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Staff
{
    public class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm learning");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is {_age}");
        }
    }
}

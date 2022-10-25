using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Staff
{
    public class Person
    {
        protected int _age;

        public void SetAge(int age)
        {
            _age = age;
        }
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
    }
}

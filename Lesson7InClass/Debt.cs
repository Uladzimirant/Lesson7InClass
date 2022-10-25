using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Debt
    {
        private double _balance;
        private double _interestRate;

        public Debt(double balance, double interestRate)
        {
            _balance = balance;
            _interestRate = interestRate;
        }

        public void PrintBalance()
        {
            Console.WriteLine($"Balance = {_balance}");
        }

        public void WaitOneYear()
        {
            _balance *= _interestRate;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {

        }

        private double Balance = 0;

        public void Deposit(double dep)
        {
            Console.WriteLine("How much would you like to Deposit?");
            dep = double.Parse(Console.ReadLine());
            Console.WriteLine("THANK YOU FOR YOUR DEPOSIT!");
            Balance += dep;
        }

        public void GetBalance()
        {
            Console.WriteLine($"YOUR BALANCE IS: ${Balance}.");
        }


    }
}


﻿                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBankAccount = new BankAccount();
            double deposit = 0;
            string ans = "yes";
            while (ans == "yes")
            {
                myBankAccount.Deposit(deposit);
                myBankAccount.GetBalance();
                Console.WriteLine("Would you like to make another deposit, yes or no?");
                ans = Console.ReadLine();
            }
            Console.WriteLine("THANK YOU FOR YOUR BUSINESS!");
        }

    }
}

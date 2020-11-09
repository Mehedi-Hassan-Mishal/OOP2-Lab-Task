using System;
using System.Collections.Generic;
using System.Text;

namespace labTask3_3_
{
    class Account
    {
        private String accName;
        private String acid;
        private int balance = 0;


        public void Deposit(int amount)
        {
            balance = balance + amount;
            Console.WriteLine("Balance:" + balance);
            Console.WriteLine("Deposit amount: " + amount);
        }
        public void Withdraw(int amount)
        {
            balance = balance - amount;
            Console.WriteLine("Balance:" + balance);
            Console.WriteLine("Withdraw amount: " + amount);
        }

    }
}

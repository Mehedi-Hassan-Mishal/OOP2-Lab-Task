﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task6_1_
{
    class Account
    {
        private string accName;
        private string acid;
        private int balance;

        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }

        public string Acid
        {
            get { return acid; }
            set { acid = value; }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public Account()
        {
            accName = "Mishal";
            acid = "19-40030-1";
            balance = 10000;
        }
        public Account(string accName, string acid, int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }
        public void Deposit(int amount)
        {
            balance += amount;
        }
        public void Withdraw(int amount)
        {
            balance -= amount;
        }
    }
}

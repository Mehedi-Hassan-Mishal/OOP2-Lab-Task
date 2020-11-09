using System;

namespace labTask3_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ob = new Account();
            ob.Deposit(10000);
            ob.Withdraw(5000);

            Course ob2 = new Course();
            ob2.set("OOP2", "5643", 3);
            ob2.ShowCourseInfo();

            Console.ReadLine();
        }
    }
}

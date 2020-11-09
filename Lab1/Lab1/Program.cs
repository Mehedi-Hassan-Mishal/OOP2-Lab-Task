using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=20, b=10, c,d,e,f,i,j;
            int num1 = 60;
            int num2 = 40;

            Console.WriteLine("Hello.\nMishal");
            c = a + b;
            Console.WriteLine("The sum is="+ c);
            d = a / b;
            Console.WriteLine("The dividing answer=" + d);

            e = -5 + 8 * 6;
            f = (55 + 9) % 9;
            i = 20 + -3 * 5 / 8;
            j = 5 + 15 / 3 * 2 - 8 % 3;

            Console.WriteLine("The result of 4(a)=" + e);
            Console.WriteLine("The result of 4(b)=" + f);
            Console.WriteLine("The result of 4(c)=" + i);
            Console.WriteLine("The result of 4(d)=" + j);

            int ans1 = num1 + num2;
            int ans2 = num1 * num2;
            int ans3 = num1 - num2;
            int ans4 = num1 / num2;
            int ans5 = num1 % num2;

            Console.WriteLine("Adding answer=" + ans1);
            Console.WriteLine("Multiplying answer=" + ans2);
            Console.WriteLine("Subtracting answer=" + ans3);
            Console.WriteLine("Dividing answer=" + ans4);
            Console.WriteLine("Remainder answer=" + ans5);

            double x = ((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5));
            Console.WriteLine("Answer of specified expression=" + x);

            double Width = 5.5;
            double Height = 8.5;
            double Area = 5.5 * 8.5;
            double Perimeter = 2 * (5.5 + 8.5);

            Console.WriteLine("Area is=" + Area);
            Console.WriteLine("Perimeter is=" + Perimeter);
        }
    }
}

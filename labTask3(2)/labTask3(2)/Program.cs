using System;

namespace labTask3_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle obj = new Triangle();
            Console.WriteLine("Enter the x: ");
            obj.X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y: ");
            obj.Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the z: ");
            obj.Z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("x is : " + obj.X);
            Console.WriteLine("y is : " + obj.Y);
            Console.WriteLine("z is : " + obj.Z);
            obj.TestTriangle();
        }
    }
}

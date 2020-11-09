using System;
using System.Collections.Generic;
using System.Text;

namespace labTask3_2_
{
    class Triangle
    {
        private int x;
        private int y;
        private int z;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Z
        {
            get { return z; }
            set { z = value; }
        }

        public void TestTriangle()
        {
            if (x == y && x == z)
            {
                Console.WriteLine("This triangle is equilateral");
            }
            else if (x == y || x == z || y == z)
            {
                Console.WriteLine("This triangle is isosceles");
            }
            else
            {
                Console.WriteLine("This triangle is scalene");
            }
        }
    }
}
using System;

namespace labTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student();
            obj.Name = "Mishal";
            obj.Id = "19-40030-1";
            obj.Department = "CSE";
            obj.Cgpa = 3.94F;

            Console.WriteLine("Name : " + obj.Name);
            Console.WriteLine("Id: " + obj.Id);

            Console.WriteLine("Department : " + obj.Department);
            Console.WriteLine("Cgpa :" + obj.Cgpa);
        }
    }
}

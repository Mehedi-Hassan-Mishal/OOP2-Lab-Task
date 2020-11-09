using System;
using System.Collections.Generic;
using System.Text;

namespace Task6_1_
{
    class Student
    {
        private string name;
        private string id;
        private string department;
        private float cgpa;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }

        public Student()
        {
            name = "Mishal Mehedi Hassan";
            id = "19-40030-1";
            department = "CSE";
            cgpa = 3.94F;

        }
        public Student(string name, string id, string department, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;
        }
        public void showInfo()
        {
            Console.WriteLine("Student Name:" + name);
            Console.WriteLine("Student Id " + id);
            Console.WriteLine("Student Department: " + department);
            Console.WriteLine("Student Cgpa:" + cgpa);

        }
    }
}

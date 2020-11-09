using System;
using System.Collections.Generic;
using System.Text;

namespace labTask3
{
    class Student
    {
private String name;
       private String id;
       private String department;
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


    }
}


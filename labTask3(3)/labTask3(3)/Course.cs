using System;
using System.Collections.Generic;
using System.Text;

namespace labTask3_3_
{
    class Course
    {

        private String courseName;
        private String courseCode;
        private int courseCredit;
        public void set(String CourseName, String CourseCode, int CourseCredit)
        {
            courseCredit = CourseCredit;
            courseCode = CourseCode;
            courseName = CourseName;
        }
        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Name:"+courseName);
            Console.WriteLine("Course Code:" + courseCode);
            Console.WriteLine("Course Credit:" + courseCredit);
        }
        
    }
}

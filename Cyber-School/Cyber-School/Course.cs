using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CyberSchool;

namespace Cyber_School
{
    public class Course : Validation
    {
        public string CourseName { get; private set; }
        public int Point { get; private set; }
        public Faculty Faculty { get; private set; }
        public double Hours { get; private set; }


        public Course()
        {

        }
        public void Register()
        {
            System.Console.WriteLine("\nNew Course registration ");
            CourseName = StringCheck("Enter Course Name");
            Point = IntCheck("Enter How many points does the course give");
            Faculty = EnumCheck<Faculty>("Enter Course-\n1.ComputerScience\n2.SoftwareEngineering\n3.Cyber\n4.Mathematics\n5.engineering");
            Hours = DoubleCheck("Enter Course Hours");
        }

        public void PrintCourse()
        {
            Console.WriteLine($"CourseName:{CourseName}\nPoint:{Point}\nFaculty:{Faculty}\nHours:{Hours}\n------\n\n");
        }
    }
}
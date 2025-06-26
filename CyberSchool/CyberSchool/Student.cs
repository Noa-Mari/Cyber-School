using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CyberSchool
{
    public enum CourseType
    {
        profession, 
        bachelor,
        master
    }

    public enum Faculty
    {
        ComputerScience,
        SoftwareEngineering,
        Cyber,
        Mathematics,
        engineering
    }

    public class Student
    {
        public string StudentFirstName { get; private set; }
        public string StudentLastName { get; private set; }
        public int ID { get; private set; }
        public DateTime Birthday { get; private set; }

        public CourseType CourseType { get; private set; }

        public Faculty Faculty { get; private set; }

        public Student(string studentFirstName, string studentLastName, int id, DateTime birthday,
        CourseType courseType, Faculty faculty)
        {
            StudentFirstName = studentFirstName;
            StudentLastName = studentLastName;
            ID = id;
            Birthday = birthday;
            CourseType = courseType;
            Faculty = faculty;
        }

        public void PrintStudent()
        {
            System.Console.WriteLine($"studant: {StudentFirstName} {StudentLastName} \nId: {ID}\nBirthday: {Birthday}\nCourseType: {CourseType}\nFaculty: {Faculty}");
        }



    }
}
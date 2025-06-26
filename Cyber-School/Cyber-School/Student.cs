using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Cyber_School;

namespace CyberSchool
{
    public enum CourseType
    {
        profession = 1,
        bachelor = 2,
        master = 3
    }

    public enum Faculty
    {
        ComputerScience = 1,
        SoftwareEngineering = 2,
        Cyber = 3,
        Mathematics = 4,
        engineering = 5
    }

    public class Student : Validation
    {
        public string StudentFirstName { get; private set; }
        public string StudentLastName { get; private set; }
        public int ID { get; private set; }
        public DateTime Birthday { get; private set; }

        public string MaritalStatus { get; private set; }

        public CourseType CourseType { get; private set; }

        public Faculty Faculty { get; private set; }

        public Student(string studentFirstName, string studentLastName, int id, DateTime birthday, string maritalStatus,
        CourseType courseType, Faculty faculty)
        {
            StudentFirstName = studentFirstName;
            StudentLastName = studentLastName;
            ID = id;
            Birthday = birthday;
            MaritalStatus = maritalStatus;
            CourseType = courseType;
            Faculty = faculty;
        }
        public Student()
        {

        }

        public void PrintStudent()
        {
            System.Console.WriteLine($"Student: {StudentFirstName} {StudentLastName} \nId: {ID}\nBirthday: {Birthday}\nCourseType: {CourseType}\nFaculty: {Faculty}");
        }

        public void Register()
        {
            System.Console.WriteLine("New student registration ");
            StudentFirstName = StringCheck("Enter Student First Name");
            StudentLastName = StringCheck("Enter Student Last Name");
            ID = IntIDCheck("Enter Student ID");
<<<<<<< HEAD
            Birthday = DateTimeCheck("Enter Your Birthday(dd/mm/yyyy)");
=======
            Birthday = BirthdayCheck("Enter Your Birthday(dd/mm/yyyy)");
>>>>>>> stageThree
            MaritalStatus = StringCheck("Enter Marital Status");
            CourseType = EnumCheck<CourseType>("Enter Course-\n1.profession\n2.bachelor\n3.master");
            Faculty = EnumCheck<Faculty>("Enter Course-\n1.ComputerScience\n2.SoftwareEngineering\n3.Cyber\n4.Mathematics\n5.engineering");
        }

    }

}
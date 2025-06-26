using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

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

    public class Student
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
            System.Console.WriteLine($"Student: {StudentFirstName} {StudentLastName} \nId: {ID}\nBirthday: {Birthday.Date}\nCourseType: {CourseType}\nFaculty: {Faculty}");
        }

        public void Register()
        {
            System.Console.WriteLine("New student registration ");
            StudentFirstName = StringCheck("Enter Student First Name");
            StudentLastName = StringCheck("Enter Student Last Name");
            ID = IntIDCheck("Enter Student ID");
            Birthday = DateTimeCheck("Enter Your Birthday(dd/mm/yyyy)");
            MaritalStatus = StringCheck("Enter Marital Status");
            CourseType = EnumCheck<CourseType>("Enter Course-\n1.profession\n2.bachelor\n3.master");
            Faculty = EnumCheck<Faculty>("Enter Course-\n1.ComputerScience\n2.SoftwareEngineering\n3.Cyber\n4.Mathematics\n5.engineering");
        }

        private string StringCheck(string msg)
        {
            while (true)
            {
                Console.WriteLine($"{msg}:");
                string input;

                try
                {
                    input = Console.ReadLine();

                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("WARNING-!:you cant enter empty string!");
                        continue;
                    }
                    else if (input.Any(char.IsDigit))
                    {
                        Console.WriteLine("WARNING-!:Name cant have numbers in it !");
                        continue;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error-!:");
                    Console.WriteLine(ex.Message);
                    continue;
                }
                return input;
            }
        }

        private int IntIDCheck(string msg)
        {
            while (true)
            {
                Console.WriteLine($"{msg}:");
                int input;

                try
                {
                    input = int.Parse(Console.ReadLine());
                    if (input.ToString().Length != 9)
                    {
                        Console.WriteLine("WARNING-!:ID Must Be Length Of 9!");
                        continue;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("WARNING-!:ID need to be is a numbers format\n-ex:123456789-");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error-!:");
                    Console.WriteLine(ex.Message);
                    continue;
                }
                return input;
            }
        }
        private DateTime DateTimeCheck(string msg)
        {
            while (true)
            {
                Console.WriteLine($"{msg}:");
                DateTime input;

                try
                {
                    input = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);
                    if (!checkAge(input))
                    {
                        Console.WriteLine("--You Need To Be Over 16 To Register!---");
                        continue;
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error-!:Invalid date");
                    continue;
                }
                return input;
            }
        }

        private bool checkAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;

            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age))
            {
                age--;
            }
            return age >= 16;
        }
        private T EnumCheck<T>(string msg) where T : Enum
        {
            while (true)
            {
                Console.WriteLine($"{msg}:");
                int input;
                try
                {
                    input = int.Parse(Console.ReadLine());

                    if (!Enum.IsDefined(typeof(T), input))
                    {
                        Console.WriteLine("WARNING-!:Option Not In Range!");
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("WARNING-!:need to be in a numbers format\n-ex:1-");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error");
                    Console.WriteLine(ex.Message);
                    continue;
                }
                return (T)Enum.ToObject(typeof(T), input);
            }
        }


    }
}
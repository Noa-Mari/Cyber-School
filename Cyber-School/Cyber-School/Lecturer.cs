using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cyber_School
{
    public class Lecturer : Validation
    {
        public string LecturerFirstName { get; private set; }
        public string LecturerLastName { get; private set; }
        public int ID { get; private set; }
        public DateTime Birthday { get; private set; }
        //public List<Course> AuthorizedCourses { get; private set; } = new();
        public List<String> AuthorizedCourses { get; private set; } = new();
        public bool IsSuspended { get; private set; } = false;
        public string IsSuspendedReason { get; private set; }

        public DateTime IsSuspendedDate { get; private set; }




        public void Register()
        {
            System.Console.WriteLine("New Lecturer registration");
            LecturerFirstName = StringCheck("Enter Lecturer First Name");
            LecturerLastName = StringCheck("Enter Lecturer Last Name");
            ID = IntIDCheck("Enter Lecturer ID");
            Birthday = BirthdayCheck("Enter Lecturer Birthday(dd/mm/yyyy)");
            Suspended();
            authorizedCourses();

        }

        private void Suspended()
        {
            Console.WriteLine("is the lecturer currently suspended? (y/n):");
            string input = Console.ReadLine().ToLower();

            if (input.Equals("y"))
            {
                IsSuspended = true;
                IsSuspendedDate = DateCheck("Enter Suspension End Date (dd/MM/yyyy)");
                Console.WriteLine("Enter The Reason:");
                IsSuspendedReason = StringCheck(Console.ReadLine());
            }
        }
        private void authorizedCourses()
        {
            //Possible add-on:If I had more time:get a list of courser
            Console.WriteLine("Enter Which Courser The Lecturer Is Authorized To Teah\n(type 'q' to finish):");
            while (true)
            {
                string input = StringCheck("-");
                if (input.ToLower() == "q")
                    break;
                else
                    AuthorizedCourses.Add(input);

            }

        }

    }
}
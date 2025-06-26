using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cyber_School;


namespace Cyber_School
{
    public class College
    {
        //public List<Student> Students { get; } = new List<Student>();
        public List<Lecturer> Lecturers { get; } = new List<Lecturer>();
        public List<Course> Courses { get; } = new List<Course>();
        public List<Classroom> Classrooms { get; } = new List<Classroom>();
    }
}
using Cyber_School;
using CyberSchool;

Student student_Noa =
new Student("noa", "mari", 123456789, new DateTime(2006, 10, 13),"Single", CourseType.master, Faculty.Cyber);

//Student student = new Student();
//student.Register();

//student_Noa.PrintStudent();

//Course course = new Course();
//course.Register();

//course.PrintCourse();

Classroom classroom = new Classroom();
classroom.Register();
classroom.classroomPrint();
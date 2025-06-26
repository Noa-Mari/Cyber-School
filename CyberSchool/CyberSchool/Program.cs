using CyberSchool;

Student student_Noa =
new Student("noa", "mari", 12345, new DateTime(2006, 10, 13),"Single", CourseType.master, Faculty.Cyber);

Student student = new Student();
student.Register(); 

student.PrintStudent();
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace ModuleReview
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Student firstStudent = new Student() { Name = "Michael", ID = 24 };
            Student secondStudent = new Student() { Name = "Megan", ID = 42 };
            Student thirdStudent = new Student() { Name = "Jimmy", ID = 12 };
            Student fourthStudent = new Student() { Name = "Jason", ID = 19 };

            students.Add(firstStudent);
            students.Add(secondStudent);
            students.Add(thirdStudent);
            students.Add(fourthStudent);

            firstStudent.AddGrade(86.1);
            firstStudent.AddGrade(95.3, 87.4);

            secondStudent.AddGrade(99.0);
            secondStudent.AddGrade(96.2, 89.9);

            thirdStudent.AddGrade(77.5);
            thirdStudent.AddGrade(79.2, 80.5);

            fourthStudent.AddGrade(98.7);
            fourthStudent.AddGrade(96.2, 90.1);

            foreach (Student student in students)
            {

                Console.WriteLine($"ID: {student.ID}, Name: {student.Name}");


                Console.Write("Grades: ");
                foreach (var grade in student.Grades)
                {
                    Console.Write($"{grade} ");
                }
                Console.WriteLine();


                double averageGrade = student.Grades.Average();
                Console.WriteLine($"Average Grade: {averageGrade:F2}");
                Console.WriteLine();
            }

            Course course = new Course() { CourseName = "Computer Science", CourseCode = "CS101" };

            course.AddEnrolledStudent(firstStudent);
            course.AddEnrolledStudent(secondStudent);

            foreach (var student in course.EnrolledStudents)
            {
                Console.WriteLine($"\nCourse Name: {course.CourseName}");
                Console.WriteLine($"Course Code: {course.CourseCode}");
                Console.WriteLine("Enrolled Students:");
                Console.WriteLine($"Student Name: {student.Name}, ID: {student.ID}");
            }



        }
    }
}
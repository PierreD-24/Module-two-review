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
            
            Student firstStudent = new Student() {Name = "Michael",ID = 24};
            Student secondStudent = new Student() {Name = "Megan", ID = 42};
            Student thirdStudent = new Student() {Name = "Jimmy", ID = 12};
            Student fourthStudent = new Student() {Name = "Jason", ID = 19};

           students.Add(firstStudent);
           students.Add(secondStudent);
           students.Add(thirdStudent);
           students.Add(fourthStudent);

        }
    }
}
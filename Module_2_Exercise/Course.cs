public class Course
{
    public string? CourseName{ get; set; }
    public string? CourseCode{ get; set; }

    public List<Student> EnrolledStudents;
    public Course()
    {
        EnrolledStudents = new List<Student>();
    }

    public void AddEnrolledStudent(Student student)
    {
        bool isAlreadyEnrolled = EnrolledStudents.Exists(s => s.ID == student.ID);

        if (!isAlreadyEnrolled)
        {
            EnrolledStudents.Add(student);
        }

        else
        {
            Console.WriteLine("Student is already enrolled");
        }
    }
}


using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

public class Student
{
    public string? Name { get; set; }
    public int ID { get; set; }
    public List<double> Grades = new List<double>();

    public void AddGrade(double grade)
    {
        Grades.Add(grade);
    }

    public void AddGrade(params double[] grades)
    {
        Grades.AddRange(grades);
    }

    public double CalculateAverageGrade()
    {
        double averageGrade = Grades.Sum() / Grades.Count;
        return averageGrade;
    }
}
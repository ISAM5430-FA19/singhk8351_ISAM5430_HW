using System;

namespace C
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Student student = new Student(1898574,"Kirti","Singh");
            student.Gpa = 3.8;
            student.Classification = "International";
            student.Major = "MIS";
            Console.WriteLine($"Name :{student.FirstName} {student.LastName}");
            Console.WriteLine($"Overall GPA :{student.Gpa}");
        }
    }
}

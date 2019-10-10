using System;
namespace C
{
    public class Student
    {
        public Student(int studentNumber, string firstName, string lastName)
        {
            StudentNumber = studentNumber;
            FirstName = firstName;
            LastName = lastName;
        }

        public Student(double gpa, string major)
        {
            Gpa = gpa;
            Major = major;
        }

        public int StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Gpa { get; set; }
        public string Classification { get; set; }
        public string Major { get; set; }
    }
}

using System;
namespace C
{
    public class Student
    {
        private int _studentNumber;
        private string _firstName;
        private string _lastName;
        private double _gpa;
        private string _classification;
        private string _major;

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

        public int StudentNumber { get
            {
                return _studentNumber;
            }
            set {
                _studentNumber = value;
            }
        }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public double Gpa
        {
            get
            {
                return _gpa;
            }
            set
            {
                _gpa = value;
            }
        }
        public string Classification
        {
            get
            {
                return _classification;
            }
            set
            {
                _classification = value;
            }
        }
        public string Major
        {
            get
            {
                return _major;
            }
            set
            {
                _major = value;
            }
        }
    }
}

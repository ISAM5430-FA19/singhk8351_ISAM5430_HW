using System;

namespace B3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // B3
            char grade;
            string result = string.Empty;
            Console.WriteLine("Enter the GPA");
            decimal gpa = decimal.Parse(Console.ReadLine());
            if (gpa < 0 || gpa > 4)
                Console.WriteLine("Invalid GPA");
            else
            {
                int gpaValue = (int)(3 * gpa + 0.5m);
                if (gpaValue == 12 || gpaValue == 11)
                    grade = 'A';
                else if (gpaValue < 11 && gpaValue >= 8)
                    grade = 'B';
                else if (gpaValue < 8 && gpaValue >= 5)
                    grade = 'C';
                else if (gpaValue == 4 && gpaValue == 3)
                    grade = 'D';
                else grade = 'F';
                if (gpaValue == 5 || gpaValue == 8 || gpaValue == 11)
                    result = grade.ToString() + '-';
                else if (gpaValue == 4 || gpaValue == 7 || gpaValue == 10)
                    result = grade.ToString() + '+';
                Console.WriteLine("Grade : " + result);
            }
        }
    }
}

using System;

namespace B6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a  sequence of numbers");
            int count = 0;
            int minValue = int.MaxValue;
            string result = string.Empty; 
            while (true)
            {
                bool counter = false;
                int num = int.Parse(Console.ReadLine());
                if (num <= 0)
                {
                    result += Convert.ToString(num);
                    break;
                }
                if (minValue > num)
                {
                    minValue = num;
                    result += Convert.ToString(num )+ ", ";
                }
                else if (num < (minValue * minValue))
                {
                    result += Convert.ToString(num) + ", ";
                }
                else
                {
                    count++;
                    minValue = int.MaxValue;
                    counter = true;
                    result += Convert.ToString(num);
                }
                if (counter)
                    result += " | "; 
            }
            Console.WriteLine(result);
        }
    }
}

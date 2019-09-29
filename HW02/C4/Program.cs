using System;

namespace C4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number count :");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbers : ");
            int counter = 0;
            float sum = 0;
            while (counter < count)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                counter++;
            }
            float average = sum / count;
            Console.WriteLine("Sum is : {0} ", sum);
            Console.WriteLine("Average is {0}",average);
        }
    }
}

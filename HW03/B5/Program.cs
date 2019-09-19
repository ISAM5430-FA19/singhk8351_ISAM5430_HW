using System;

namespace B5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the item :");
            int item = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the sequence of numbers :");
            int num = int.MinValue;
            int closestNum = 0;
            int minDiff = int.MaxValue;
            while (num != item)
            {
                num = int.Parse(Console.ReadLine());
                if ((item - num) < minDiff)
                {
                    minDiff = item - num;
                    closestNum = num;
                }
            }
            Console.WriteLine($"The closest number to {item} is {closestNum}");
        }
    }
}

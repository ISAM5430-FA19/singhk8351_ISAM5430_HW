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
            while (true)
            {
                num = int.Parse(Console.ReadLine());
                int diff = item > num ? item - num : num - item;
                if (diff < minDiff)
                {
                    minDiff = diff;
                    closestNum = num;
                }
                if (num == item)
                    break;
                Console.WriteLine($"The closest number to {item} is {closestNum}");
            }
           // Console.WriteLine($"The closest number to {item} is {closestNum}");
        }
    }
}

using System;

namespace B7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer:");
            int num = int.Parse(Console.ReadLine());
            while(num > 1)
            {
                int digit = num % 10;
                Console.WriteLine(digit);
                num = num / 10;
            }
        }
    }
}

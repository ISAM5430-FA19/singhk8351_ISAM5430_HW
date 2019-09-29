using System;

namespace B2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers ");
            int sum = 0;
            int preNum = int.MinValue;
            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                if (preNum == num)
                    break;
                preNum = num;
                sum += num;
            }
            Console.WriteLine("The sum of the numbers entered is {0}", sum);
        }
    }
}

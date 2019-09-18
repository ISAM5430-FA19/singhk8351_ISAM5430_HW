using System;

namespace B8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 positive integers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int carryOver = 0;
            int count = 1;
            int sum = 0;
            int num = 0;
            int revNum = 0;
            while (a > 0 || b > 0)
            {
                int digitA = a % 10;
                int digitB = b % 10;
                if (carryOver != 0)
                    sum = digitA + digitB + carryOver;
                else
                    sum = digitA + digitB;
                if (sum / 10 != 0)
                {
                    carryOver = sum / 10;
                }
                else
                    carryOver = 0;
                sum = (sum % 10) * count;
                a = a / 10;
                b = b / 10;
                count *= 10;
                num += sum;
            }           
            while (num > 0)
            {
                count = count / 10;
                revNum += (num % 10) * count;
                num = num / 10;
            }
            Console.Write(revNum);
        }
    }
}

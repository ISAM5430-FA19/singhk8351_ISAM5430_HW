using System;

namespace B9
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer");
            int num = int.Parse(Console.ReadLine());
            int binaryNum = 0;
            int count = 1;
            while(num > 0)
            {
                binaryNum += (num % 2)*count;
                num = num / 2;
                count = count * 10;
            }
            Console.WriteLine(binaryNum);
        }
    }
}

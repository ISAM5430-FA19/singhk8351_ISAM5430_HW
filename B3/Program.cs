using System;

namespace B3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers in increasing order :");
            int preNum = int.MinValue;
            while(true)
            {
                int num = int.Parse(Console.ReadLine());
                if (preNum > num)
                    break;
                preNum = num;
            }
            Console.WriteLine("The largest number is {0} ",preNum);
        }
    }
}

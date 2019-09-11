using System;

namespace D
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the count of numbers");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbers: ");
            int i = 0;
            int numberOfZeros = 0;
            int even = 0;
            int order = 0;
            int firstSum = 0;
            int secondSum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            int clump = 0;
            int preNum = int.MaxValue;
            int postNum = int.MinValue;
            string str = string.Empty;
            while (i < count)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > 0) // positive numbers
                {
                    str += Convert.ToString(num) + ',';
                }
                if (num == 0) // number of zeros
                    numberOfZeros++;
                if (num % 2 == 0) // number of even integers
                    even++;
                if (num > max)// increasing order
                    order++;
                if (num < min) // smallest number
                    min = num;
                if (num > max) // largest number
                    max = num;
                if (count % 2 == 0)
                {
                    if (i < count / 2) // comparison of sum of first half and second half numbers
                        firstSum += num;
                    else
                        secondSum += num;
                }
                else
                {
                    if (i < count / 2) // comparison of sum of first half and second half numbers
                        firstSum += num;
                    else if (i > count / 2)
                        secondSum += num;
                }
                if (i > 0) // count the number of clumps
                {
                    if (num == preNum && num != postNum)
                    {
                        clump++;
                        postNum = num;
                    }
                    else
                        preNum = num;
                }
                else
                    preNum = num;
                i++;
            }

            Console.WriteLine("The positive numbers are :" + str.Remove(str.LastIndexOf(',')));
            Console.WriteLine("The number of clumps in the numbers entered is {0}", clump); // 8
            Console.WriteLine("The number of zeros is {0} ", numberOfZeros); // 2
            Console.WriteLine("The number of even integers is {0} ", even); //3
            if (order == count) //4
                Console.WriteLine("The numbers are entered in increasing order");
            else
                Console.WriteLine("The numbers are not entered in increasing order");
            // N, P, C
            Console.WriteLine($"The largest number is {max} and the smallest number is {min}"); //5 & 6
            if (firstSum == secondSum) // 7
                Console.WriteLine("Sum of first half and second half numbers is same");
            else
                Console.WriteLine("Sum of first half and second half numbers is different");
            // print out the maximun value with thousand commas and no decimal places(0).
        }
    }
}

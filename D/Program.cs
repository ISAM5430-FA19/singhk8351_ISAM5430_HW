﻿    using System;

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
            int maxClumpLen = 0;
            int clumpLen = 0;
            int preNum = int.MaxValue;
            int clumpNum = int.MinValue;
            int avg = 0;
            int centerMax = int.MinValue;
            int centerMin = int.MaxValue;
            int maxCount = 0;
            int minCount = 0;
            int twosCount = 0;
            int onesCount = 0;
            int foursCount = 0;
            string str = string.Empty;
            while (i < count)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum > 0) // positive numbers
                {
                    str += Convert.ToString(currentNum) + ',';
                }
                if (currentNum == 0) // number of zeros
                    numberOfZeros++;
                if (currentNum % 2 == 0) // number of even integers
                    even++;
                if (currentNum > max)// increasing order
                    order++;
                if (currentNum < min) // smallest number
                    min = currentNum;
                if (currentNum > max) // largest number
                    max = currentNum;
                if (count % 2 == 0)
                {
                    if (i < count / 2) // comparison of sum of first half and second half numbers
                        firstSum += currentNum;
                    else
                        secondSum += currentNum;
                }
                else
                {
                    if (i < count / 2) // comparison of sum of first half and second half numbers
                        firstSum += currentNum;
                    else if (i > count / 2)
                        secondSum += currentNum;
                }

                if (i > 0) // count the number of clumps & length of the largest clump
                {
                    if (currentNum == preNum)
                    {
                        if (currentNum != clumpNum)
                        {
                            clump++;
                            clumpNum = currentNum;
                        }
                        clumpLen++;
                    }
                    else
                    {
                        preNum = currentNum;
                        clumpNum = int.MaxValue;
                        clumpLen = 1;
                        if (currentNum == 2)
                            twosCount++;
                    }
                }
                else
                {
                    preNum = currentNum;
                    clumpLen++;
                }
                if (clumpLen > maxClumpLen)
                    maxClumpLen = clumpLen;

                //centered average
                if (currentNum == centerMax)
                    maxCount++;
                if (currentNum == centerMin)
                    minCount++;
                avg += currentNum;
                if (currentNum < centerMin)
                {
                    centerMin = currentNum;
                    minCount = 1;
                }
                if(currentNum > centerMax)
                {
                    centerMax = currentNum;
                    maxCount = 1;
                }
                // 1's > 4's
                if (currentNum == 1)
                    onesCount++;
                else if (currentNum == 4)
                    foursCount++;
                i++;
            }
            avg = (avg - max * maxCount - min * minCount)/count; // 10
            if (twosCount != 0) // 11
                Console.WriteLine("Two is alone");
            else
                Console.WriteLine("All twos are together");
            if (onesCount > foursCount)
                Console.WriteLine("Yes, the number of 1's is more than the number of 4's");
            else
                Console.WriteLine("No, the number of 1's is not more than the number of 4's");
            Console.WriteLine("The positive numbers are :" + str.Remove(str.LastIndexOf(',')));
            Console.WriteLine("The number of clumps in the numbers entered is {0}", clump); // 8
            Console.WriteLine("The longest  clump length  is {0}", maxClumpLen); // 9
            Console.WriteLine("The centered average is : {0}", avg);
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

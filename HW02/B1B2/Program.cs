using System;

namespace B1B2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //B1 & B2
                int middle;
                //print enter the first number
                Console.WriteLine("Enter the first number");
                //input the first number
                int first = int.Parse(Console.ReadLine());
                //print enter the second number
                Console.WriteLine("Enter the second number");
                //input the second number
                int second = int.Parse(Console.ReadLine());
                //print enter the third number
                Console.WriteLine("Enter the third number");
                //input the third number
                int third = int.Parse(Console.ReadLine());
                // if first number > second number
                if (first > second)
                    // print first number
                    Console.WriteLine(first);
                // else if second number > first number
                else if (second > first)
                    // print second number
                    Console.WriteLine(second);
                // else
                else
                    // print both numbers are same
                    Console.WriteLine("both numbers are same");

                // find the middle number
            if ((first < second && first > third) || (first > second && first < third))
            {
                middle = first;
            }
            else if ((second < first && second > third) || (second > first && second < third))
                middle = second;
            else
                middle = third;
            Console.WriteLine("The middle number is {0} ", middle);
            }
        }
    }








using System;

namespace B3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // B3
            char grade;
            Console.WriteLine("Enter the GPA");
            decimal gpa = decimal.Parse(Console.ReadLine());
            if (gpa < 0 || gpa > 4)
                Console.WriteLine("Invalid GPA");
            else
            {
                int gpaValue = (int)(3 * gpa + 0.5m);
                if (gpaValue == 12 || gpaValue == 11)
                    grade = 'A';
                else if (gpaValue < 11 && gpaValue >= 8)
                    grade = 'B';
                else if (gpaValue < 8 && gpaValue >= 5)
                    grade = 'C';
                else if (gpaValue == 4 && gpaValue == 3)
                    grade = 'D';
                else grade = 'F';
                if (gpaValue == 5 || gpaValue == 8 || gpaValue == 11)
                    grade = (char)(grade + '-');
                else if(gpaValue == 4 || gpaValue == 7 || gpaValue == 10)
                    grade = (char)(grade + '+');
                Console.WriteLine("Grade : " + grade);
            }
        }
    }
}





using System;

namespace C
{
    class MainClass
    {
        // C1 , C2, C3
        public static void Main(string[] args)
        {
            //1.1
            int count = 20;
            while (count > 0)
            {
                Console.Write(count);
                Console.Write(' ');
                count--;
            }
            Console.WriteLine();
            //1.2
            int counter = 2;
            while(counter <= 10)
            {
                Console.Write(counter);
                Console.Write(' ');
                counter += 2;
            }
            Console.WriteLine();
            //1.3
            int posCounter = 10;
            while(posCounter < 100)
            {
                Console.Write(posCounter);
                Console.Write(' ');
                posCounter += 10;
            }
            Console.WriteLine();
            // 1.4
            int loopCounter = 1;
            while(loopCounter < 20)
            {
                if(loopCounter % 3 != 0)
                {
                    Console.Write(loopCounter);
                    Console.Write(' ');
                }
                loopCounter += 2;
            }
            Console.WriteLine();
            // 1.5
            int sqrCounter = 4;
            while(sqrCounter < 10)
            {
                Console.Write(sqrCounter * sqrCounter);
                Console.Write(' ');
                sqrCounter++;
            }
            Console.WriteLine();
            // 1.6
            int num1 = 1;
            while (num1 <= 100)
            {

                if ((num1 % 3 != 0 && num1 % 5 != 0) || (num1 % 3 == 0 && num1 % 5 == 0))
                {
                    Console.Write(num1);
                    Console.Write(' ');
                }
                num1++;
            }
            Console.WriteLine();
            // 1.7
            char alphabet = 'a';
            while(alphabet <= 'z')
            {
                Console.Write(alphabet);
                alphabet++;
            }
            Console.WriteLine();
            // 2.8
            int preCounter = 1;
            while(preCounter <= 100)
            {
                Console.Write(preCounter);
                Console.Write(' ');
                preCounter = preCounter * 2;
            }
            Console.WriteLine();
            // 2.9
            // how to print 0 in below :
            int intCounter = 100;
            while(intCounter >= 0)
            {
                Console.Write(intCounter);
                Console.Write(' ');
                if (intCounter == 0)
                    break;
                intCounter = intCounter /2;
            }
            Console.WriteLine();
            // 2.10
            decimal decCounter = 100;
            while (decCounter > 1)
            {
                Console.Write(decCounter);
                Console.Write(' ');
                decCounter = decCounter / 2;
            }
            Console.WriteLine();
            // 3.11
            int factCounter = 1;
            int fact = 1;
            int countFact = 1;
            while (true)
            { 
                while (factCounter >= 1)
                {
                    fact *= factCounter;
                    factCounter--;
                 }
                if (fact >= 1000)
                    break;
                Console.Write(fact);
                Console.Write(' ');
                fact = 1;
                factCounter=++countFact;
            }
            Console.WriteLine();
            // 3.12
            int fib = 0;
            int fibNum1 = 0;
            int fibNum2 = 1;
            int fibNum3 = 0;
            Console.Write("{0} {1} ",fibNum1,fibNum2);
            while(fib < 23)
            {
                fibNum3 = fibNum1 + fibNum2;
                Console.Write(fibNum3);
                Console.Write(' ');
                fibNum1 = fibNum2;
                fibNum2 = fibNum3;
                fib++;
            }
        }
    }
}




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

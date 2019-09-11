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


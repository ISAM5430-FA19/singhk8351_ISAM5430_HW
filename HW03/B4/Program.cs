﻿using System;

namespace B4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the 3 sides number");
            while (true)
            {
                int side1 = int.Parse(Console.ReadLine());
                int side2 = int.Parse(Console.ReadLine());
                int side3 = int.Parse(Console.ReadLine());
                if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                    break;
                if (side1 + side2 > side3 && side2 + side3 > side1 && side3 + side1 > side2)
                    Console.WriteLine($"The triangle with sides {side1} {side2} {side3} is a valid triangle");
                else
                    Console.WriteLine($"The triangle with sides {side1} {side2} {side3} is not a valid triangle");
            }
        }
    }
}

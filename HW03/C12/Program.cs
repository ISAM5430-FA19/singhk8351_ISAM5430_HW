﻿using System;

namespace C12
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            int primeNum = 1;
            int count = 0;
            while(primeNum < num)
            {
                count = 0;
                int div = primeNum;
                while (div >= 1)
                {
                    if (primeNum % div == 0)
                    {
                        count++;
                    }
                    div--;
                }
                if(count == 2)
                Console.WriteLine(primeNum);
                primeNum++;
            }           
        }
    }
}

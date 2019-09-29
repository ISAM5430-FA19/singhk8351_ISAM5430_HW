using System;

namespace C13
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int principal = 1000;
            int rate = 10;
            int interest = 5;
            int year = 10;
            decimal interestRate;
            while (interest <= rate) // c
            {
                int time = 1;
                int amount = principal;
                interestRate = interest * 0.01m;
                while (time <= year) // a
                {
                    amount += (int)(amount * interestRate);
                    Console.WriteLine($"Amount at the end of year {time} is {amount}");
                    time++;
                }
                interest++;
            }
        }
    }
}

using System;

namespace C16
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a non negative number");
            int num = int.Parse(Console.ReadLine());
            for(int row = 1; row <= num; row++)
            {
                int c = 0;
                for(int col = 1; col <= num; col++)
                {
                    if (col > num - row)
                    {
                        Console.Write(row - c);
                        c++;
                    }
                    else
                        Console.Write("0");
                }
                Console.WriteLine("\n");
            }
        }
    }
}

using System;

namespace C10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            int n = int.Parse(Console.ReadLine());
            int row = 0;
            while(row < n)
            {
                int col = 0;
                while(col < n)
                {
                    Console.Write('X');
                    col++;
                }
                Console.WriteLine();
                row++;
            }
        }
    }
}

using System;

namespace C11
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int n = 10;
            int row = 1;
            while(row < n)
            {
                int col = 1;
                while (col < n)
                {
                    Console.Write(row*col);
                    Console.Write('\t');
                    col++;
                }
                Console.WriteLine();
                row++;
            }
        }
    }
}

using System;

namespace C14
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // pattern a
            int a = 10;
            int row = 0;
            while(row < a)
            {
                int col = 0;
                while (col <= row)
                {                   
                    Console.Write('*');
                    col++;
                }
                Console.WriteLine('\n');
                row++;
            }
            Console.WriteLine('\n');
            // pattern b
            int rowb = a;
            while (rowb > 0)
            {
                int colb = 0;
                while (colb < rowb)
                {
                    Console.Write('*');
                    colb++;
                }
                Console.WriteLine('\n');
                rowb--;
            }
            Console.WriteLine('\n');
            // pattern c
            int rowc = 0;
            while (rowc < a)
            {
                int colc = a-rowc;
                int blankSpc = 0;
                while (colc > 0)
                {                   
                    while (blankSpc < rowc)
                    {
                        Console.Write(' ');
                        blankSpc++;
                    }
                    Console.Write('*');
                    colc--;
                }
                Console.WriteLine('\n');
                rowc++;
            }
            Console.WriteLine('\n');
            // pattern d
            int rowd = a;
            while (rowd > 0)
            {
                int cold = 0;
                int blankSpc = 1;
                while (cold <= (a - rowd))
                {
                    while (blankSpc < rowd)
                    {
                        Console.Write(' ');
                        blankSpc++;
                    }
                    Console.Write('*');
                    cold++;
                }
                Console.WriteLine('\n');
                rowd--;
            }
        }
    }
}

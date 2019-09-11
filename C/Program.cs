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
            while(intCounter > 0)
            {
                Console.Write(intCounter);
                Console.Write(' ');
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
            //int factCounter = 1;
            //int fact = 1;
            //while(fact < 1000)
            //{
            //  fact = factCounter;

            //}
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

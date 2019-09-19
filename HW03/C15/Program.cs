using System;

namespace C15
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a non negative number");
            int num = int.Parse(Console.ReadLine());
            int count = 1;
            int sum = 0;
            while(count <= num)
            {
                int group = 1;
                while (group <= count)
                {
                    Console.Write(group);
                    Console.Write(',');
                    group++;
                }
                sum += count;
                Console.WriteLine('\n');
                count++;
            }
            Console.WriteLine("Sum is {0}",sum);
        }
    }
}

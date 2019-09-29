using System;

namespace B_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("All the combinations of 2 numbers :");
            int product = 0;
            for(int i =1; i <= 5; i++)
            {
                for(int j=i+1; j <= 5; j++)
                {
                    //for (int z = j + 1; z <= 5; z++)
                    //{
                        Console.Write(';');
                        Console.Write(i);
                        Console.Write(',');
                        Console.Write(j);
                        //Console.Write(',');
                        //Console.Write(z);
                        product += i * j ;
                    //}
                }
            }
            Console.WriteLine();
            Console.WriteLine("Product is : {0}", product);
        }
    }
}

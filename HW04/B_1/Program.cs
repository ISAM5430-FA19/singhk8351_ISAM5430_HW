using System;

namespace B_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("All the permutations with 3 numbers are :");
            int product = 0;
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= 5; j++)
                {
                    if(i !=j)
                    {
                        for (int z = 1; z <= 5; z++)
                        {
                            if (j != z  && i != z)
                            {
                                Console.Write(';');
                                Console.Write(i);
                                Console.Write(',');
                                Console.Write(j);
                                Console.Write(',');
                                Console.Write(z);
                                product += i * j * z;
                            }
                        }
                    }   
                }  
            }
            Console.WriteLine();
            Console.WriteLine("Product is : {0}", product);
        }
    }
}

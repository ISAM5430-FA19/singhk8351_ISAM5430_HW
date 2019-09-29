using System;

namespace B2_4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'H'; i++)
            {
                bool vowelA = i  == 'A' || i == 'E' ;
                for (char j = 'A'; j <= 'H'; j++)
                {
                    bool vowelB = j == 'A' || j == 'E';
                    // 5 a
                    //int vowels2 = (vowelA ? 1 : 0) + (vowelB ? 1 : 0);
                    //if (vowels2 == 1 || vowels2 == 2)
                    //Console.Write($"{i}{j}");

                    for (char z = 'A'; z <= 'H'; z++)
                    {
                        bool vowelC = z == 'A' || z == 'E';
                        int vowels1 = (vowelA ? 1 : 0) + (vowelB ? 1 : 0) + (vowelC ? 1 : 0);
                        //int consonants = (!vowelA ? 1 : 0) + (!vowelB ? 1 : 0) + (!vowelC ? 1 : 0);
                        // if ((vowelA && !vowelB) || (vowelA && !vowelC) || (vowelB && !vowelC) || (vowelC && !vowelB) || (vowelC && !vowelA) || (vowelC && !vowelB))
                        //if (vowels1 == 1 || vowels1 == 2) // 4c
                        //if (vowelB) // 4b
                        //if(vowels1 >= 1) // 4a
                        //if(vowelB && i !=z && z != j && j != i) //4d
                        //if(!vowelA && vowelC) // 5b
                            Console.Write($"{i}{j}{z} ");
                    }
                }
            }
        }
    }
}

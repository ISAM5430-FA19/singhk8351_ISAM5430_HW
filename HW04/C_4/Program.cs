using System;

namespace C_4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int letterCount = 0;
            int consonantCount = 0;
            int vowelCount = 0;
            char preLetter = 'A';
            int order = 0;
            int wordCount = 0;
            int secondHalfCount = 0;
            bool preVowel = false;
            int altCount = 0;
            int transitionCount = 0;
            bool ascending = false;
            int altOrder = 0;
            char altPreLetter = 'A';
            int count = 0;
            while(true)
            {
                var keyInfo = Console.ReadKey();
                char letter = char.ToUpperInvariant(keyInfo.KeyChar);
                if (!char.IsLetter(letter)) break;               
                bool vowel = letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'Y';
                if (vowel)
                {
                    vowelCount++; // 7                   
                }
                else
                    consonantCount++; //7
               
                                 
                if (letter >= 'A' && letter <= 'G')
                    wordCount++;
                if (letter >= 'N' && letter <= 'Z')
                    secondHalfCount++;
                if(altOrder == 0)
                {
                    altPreLetter = letter;
                    altOrder = 1;
                    count = 1;
                }
                else if (altOrder == 1)
                {
                    if (preLetter < letter)
                        ascending = true;
                    else
                        ascending = false;
                    altOrder = 2;
                    altPreLetter = letter;
                    count = 2;
                }
                else 
                {
                    if (ascending)
                    {
                        if (altPreLetter > letter)
                        {
                            count++;
                            ascending = false;
                        }
                    }
                    else
                    {
                        if(altPreLetter < letter)
                        {
                            count++;
                            ascending = true;
                        }
                    }
                    altPreLetter = letter;
                }
                if (letterCount == 0)
                {
                    preVowel = letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'Y';
                    preLetter = letter;
                    altCount++;
                    order++;
                    transitionCount++;
                }               
                else
                {
                    if (letter > preLetter)
                        order++;
                    if (!preVowel && vowel || preVowel && !vowel)
                    {
                        altCount++;
                        preVowel = vowel;
                    }
                    if (letter == preLetter || letter == preLetter + 1 || letter == preLetter - 1)
                        transitionCount++;
                    preLetter = letter;
                }
                letterCount++; // 6
            }           
            if (order == letterCount) // 9a
                Console.WriteLine("Letters are in increasing order");
            else
                Console.WriteLine("Letters are not in increasing order");
            if (letterCount == wordCount) // 9b
                Console.WriteLine("word can be played on musical intruments");
            else
                Console.WriteLine("word cannot be played on musical intruments");
            if (letterCount == secondHalfCount) // 9c
                Console.WriteLine("letters are in second half of the alphabet");
            else
                Console.WriteLine("letters are not in second half of the alphabet");
            if (altCount == letterCount) // 9d
                Console.WriteLine("word only alternate between vowel and consonant");
            else
                Console.WriteLine("word does not alternate between vowel and consonant");
            if(transitionCount == letterCount) // 9e
                Console.WriteLine("letters in the word have smooth transition");
            else
                Console.WriteLine("letters in the word do have smooth transition");
            if (count == letterCount) // 9f
                Console.WriteLine("All the letters in the word have alternating order");
            else
                Console.WriteLine("All the letters in the word do not have alternating order");
            Console.WriteLine("Number of letters entered is {0}",letterCount); //6
            Console.WriteLine("Number of vowels entered is {0}", vowelCount); //7
            Console.WriteLine("Number of consonants entered is {0}", consonantCount); //7
        }
    }
}

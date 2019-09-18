using System;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the score : ");
            int score = 0;
            int bestScore = 0;
            int sum = 0;
            int scoreCount = 0;
            string initialScore;
            while (score >= 0 && score <= 100)
            {
                if (score > bestScore)
                    bestScore = score;
                sum += score;
                initialScore = Console.ReadLine();
                if (string.IsNullOrEmpty(initialScore))
                    break;
                    score = int.Parse(initialScore);
                    scoreCount++;
            }
            if (scoreCount > 1)
            {
                Console.WriteLine("The best score is {0}", bestScore);
                Console.WriteLine("The average score is {0}", sum / (scoreCount - 1));
            }
            else if (scoreCount == 1)
                Console.WriteLine("Invalid score entered");
            else
                Console.WriteLine("No score entered");
        }
    }
}


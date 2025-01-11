using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "Yes";

        while (playAgain == "Yes")
        {
            int count = 0;

            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            Console.WriteLine(magicNumber);


            int guess = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                count = count +1;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.Write("Do you want to play again? ");
//                    playAgain = Console.ReadLine();
                }
//                Console.Write("Do you want to play again? ");
            }
//        Console.Write("Do you want to play again? ");
        }
    }
}
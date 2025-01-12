using System;

class Program
{
    static void Main(string[] args)
    {
        {
            DisplayMessage();

            string userName = UserName();
            int userNumber = UserNumber();

            int squaredNumber = SquareRootOfNumber(userNumber);

            DisplayResults(userName, squaredNumber);

        }
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string UserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int UserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareRootOfNumber(int number)
        {
            int squareRoot = number * number;
            return squareRoot;
        }

        static void DisplayResults(string name, int squared)
        {
            Console.WriteLine($"{name}, the square root of your number is {squared}.");
        }




    }
}
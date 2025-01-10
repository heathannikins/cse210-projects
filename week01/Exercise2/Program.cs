using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();

        double grade = double.Parse(gradePercentage);

        string letter = "";

        if  (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = ("B");
        }

        else if (grade >= 70)
        {
            letter = ("C");
        }

        else if (grade >= 60)
        {
            letter = ("F");
        }

        double x = 10;
        double remainder = (grade % x);
        string plusMinus = "";

        if (remainder >= 7 && letter != "A" && letter != "F")
        {
            plusMinus = ("+");
        }
        else if (remainder < 3 && letter != "F")
        {
            plusMinus = ("-");
        }
        else
        {
            plusMinus = ("");
        }

        Console.WriteLine($"Your grade is {letter}{plusMinus}");

        if (grade >= 70)
            {
                Console.WriteLine("You passed the class!");
            }
        else
            {
                Console.WriteLine("Try for a 70% or better next time.");
            }
    }
}
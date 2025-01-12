using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> listOfNumbers = new List<int>();

        int number = -1;
        float total = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        while (number != 0)
        {
            Console.Write("Enter number ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                listOfNumbers.Add(number);
            }
        }
        foreach (int numb in listOfNumbers)
        {
            total += numb;
        }
        Console.WriteLine($"The sum is {total}");
        float average = total / (listOfNumbers.Count);
        Console.WriteLine($"The average is {average}");
        int largest = listOfNumbers.Max();
        Console.WriteLine($"The largest number is {largest}");
        int smallest = listOfNumbers.Min();
        Console.WriteLine($"The smallest number is {smallest}");
    }
}
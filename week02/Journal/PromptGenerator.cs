// This is the prompt Generator for the Journal Program
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
public class PromptGenerator
{
    
    public static List<string> _prompt = new List<string>
    {
        "What was your favorite part of the day?",
        "What was your least favorite part of the day?",
        "Who made you very happy today?",
        "What did you do in your spare time today?",
        "Who is one person you spoke to today?",
    };

    //    foreach (string sentence in _prompt)
    //    {
    //        Console.WriteLine($"{sentence}");
    //    }
    //}
    //public static int RandomNumberPicker()
    //I found how to do a random number using a range by googling it and getting an answer from Copilot
    public static string GetRandomPrompt()
    {
        Random random = new Random();
        int min = 0;
        int max = 4;
        int randomNumber = random.Next(min, max);
        //return randomNumber;
        //Console.WriteLine($"{randomNumber}");

        string promptEntry = _prompt[randomNumber];
        Console.WriteLine($"{promptEntry}");
        return promptEntry;

    }
}


using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
       public static string _date;
       public static string _promptText;
       public static string _entryText;

   //public Entry(string _date, string _promptText, string _entryText)
   //{}
   public Entry(string _prompt, string _userInput)
    {
        _date = DateTime.Now.ToString("MM/dd/yyyy");
        _promptText = _prompt;
        //Console.Write($"{_date} ");
        _entryText = _userInput;
    }
   public void Display()
   {
       //Copilot on Google showed me how to get the date, and how to only do the date and not the time
       //DateOnly _date = DateOnly.FromDateTime(DateTime.Now);
       //string _promptText = PromptGenerator.GetRandomPrompt();
       Console.WriteLine($"{_date} {_promptText}");
       Console.WriteLine($"{_entryText}");
       Console.WriteLine(" ");
       //string _entryText = Console.ReadLine();
       //string _newEntry = ($"{_date} {_promptText} {_entryText}");
       //Console.WriteLine(_newEntry);
       //Journal.AddEntry(_newEntry);
   }
}


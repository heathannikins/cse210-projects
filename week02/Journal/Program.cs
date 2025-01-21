using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        int selectionNumber = 0;
        Journal journal = new Journal();
        Console.WriteLine("Welcome to your Journal!");
        while (selectionNumber != 5)
        {
            Console.WriteLine("Please select one of the following menu choices:");
            Console.WriteLine("1. Write a Journal Entry");
            Console.WriteLine("2. Display your Journal Entries");
            Console.WriteLine("3. Save Journal File");
            Console.WriteLine("4. Load Journal File");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string selection = Console.ReadLine();
            selectionNumber = int.Parse(selection);

        //if (selectionNumber != 5)
       // {
            if (selectionNumber == 1)
            {
                journal.AddEntry();
                //PromptGenerator.GetRandomPrompt();
                //Console.WriteLine("Selection 1");
                //Entry.Display();
                //Entry.NewEntry();
                //Console.ReadLine();//Journal _newEntry = new Journal();
                //Journal.AddEntry(Entry._date, Entry._promptText, Entry._entryText);
            }

            else if (selectionNumber == 2)
            {
                journal.DisplayAll();
            }

            else if (selectionNumber == 3)
            {
                Console.Write("What do you want to name the file? ");
                string _fileNameSave = Console.ReadLine();
                journal.SaveToAFile(_fileNameSave);
            }
            
            else if (selectionNumber == 4)
            {
                Console.Write("What file do you want to load? ");
                string _fileNameLoad = Console.ReadLine();
                journal.LoadFromAFile(_fileNameLoad);
            }

        }
        
        return;
        
    }
}

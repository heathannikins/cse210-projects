using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public readonly List<Entry> _entries = new List<Entry>();
    //List<int> listOfNumbers = new List<int>();
    //public static string _newEntry;
    //        public static string _fileName;

    public void AddEntry()
    {
        string _prompt = PromptGenerator.GetRandomPrompt();
        //_newEntry = Entry(Entry.NewEntry());
        //_newEntry = ($"{Entry._date} {Entry._promptText} {Entry._entryText}");
        //Console.WriteLine($"{_prompt} ");
        Console.WriteLine("Add your entry to the prompt: ");
        string _userInput = Console.ReadLine();
        _entries.Add(new Entry(_prompt, _userInput));
        //_entries.Add(new Entry(Entry.NewEntry));
        //Journal.AddEntry(_newEntry);
        //foreach (Entry _entry in _entries)
        Console.WriteLine("Your entry was received!");
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            Entry.Display();
        }
    }

    public void SaveToAFile(string _fileNameSave)
    {
        //Console.Write("What do you want to name the file? ");
        //string _fileNameSave = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_fileNameSave))
        {
    // You can add text to the file with the WriteLine method
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine($"{Entry._date}|{Entry._promptText}|{Entry._entryText}");
            }
        }
        Console.WriteLine($"Journal saved to {_fileNameSave}");
        }

    }

    public void LoadFromAFile(string fileName)
    {
        //Console.Write("What file do you want to load? ");
        //string _fileNameLoad = Console.ReadLine();

        foreach (var _line in File.ReadAllLines(fileName))
        {
           var _parts = _line.Split('|');
            if (_parts.Length == 3)
            {
                _entries.Add(new Entry(_parts[1], _parts[2]));
            }
        }

    }
}



using System;
using System.IO;


public class Journal
{

    string fileName = "myJournal.txt";

    public List<string> todaysEntries = new List<string>();
    
    public void Display()
    {
        foreach (String entry in todaysEntries)
        {
            Console.WriteLine(entry);
        }
    }

    public void saveJournal()
    {
        foreach (String entry in todaysEntries)
        {
            System.IO.File.WriteAllLines("myJournal.txt", todaysEntries);
        }
    }

    public void loadJournal()
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

}
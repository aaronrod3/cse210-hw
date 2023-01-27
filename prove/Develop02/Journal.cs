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
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(todaysEntries);
        }
    }

    public void loadJournal()
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }
    }

}
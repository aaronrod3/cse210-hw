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

}
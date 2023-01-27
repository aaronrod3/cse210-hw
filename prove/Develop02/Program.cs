using System;


class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        Prompts myPrompt = new Prompts();

        int num;
        string displayInput;

        string formEntry()
        {
            string entryPrompt = myPrompt.randomPrompt();
            Console.WriteLine(entryPrompt);
            string userEntry = Console.ReadLine();
            string date = DateTime.Today.ToString("dd-MM-yyyy");

            string entry = ($"Date: {date} - {entryPrompt} \n{userEntry}");
            return entry;
        }



        do 
        {
        Console.WriteLine("Please select one of the following options:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        displayInput = Console.ReadLine();


        
        if(!Int32.TryParse(displayInput, out num)) continue;

        if (displayInput == "1")
        {   
            string entry = formEntry();
            myJournal.todaysEntries.Add(entry);
        }
        else if (displayInput == "2")
        {
            myJournal.Display();
        }
        else if (displayInput == "3") 
        {
            myJournal.saveJournal();
        }
        else if (displayInput == "4")
        {
            myJournal.loadJournal();
        }

        }while (true);

        
    }
}
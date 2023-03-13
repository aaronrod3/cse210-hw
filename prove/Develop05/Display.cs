using System;



public class Display
{

    
    
    public string Menu()
    {
        Console.WriteLine("Menu Options");
        Console.WriteLine(" 1. Create a goal");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Record Event");
        Console.WriteLine(" 6. Quit");
        Console.Write("Select a choice from the menu: ");
        string menuInput = Console.ReadLine();
        return menuInput;
    }

    public string createMenu()
    {
        Console.WriteLine("Menu Options");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string menuInput = Console.ReadLine();
        return menuInput;
    }


}
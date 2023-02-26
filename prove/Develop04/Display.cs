using System;



public class Display
{
    public string Menu()
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            string menuInput = Console.ReadLine();

            return menuInput;
        }

        


}
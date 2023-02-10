using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Scripture myScripture = new Scripture();
        Prompt myPrompt = new Prompt();
        Display myDisplay = new Display();

            //get scripture
        string scriptRef = myScripture.getScriptureRef();
        string scriptText = myScripture.getScriptureText();
            //make scripture words into list
        myScripture._words = scriptText.Split(' ').ToList();    
            // get prompt
        string prompt = myPrompt.prompt();
    
        //clear screen and display scripture
        myDisplay.display(scriptRef, myScripture._words);
        //prompt to enter or quit
        

        do
        {
            //prompt to enter or quit
            Console.WriteLine(prompt);
            var userInput = Console.ReadKey();

            if (userInput.Key == ConsoleKey.Enter)
            {
            // hide words 
            myScripture.randomWord();
            myScripture.randomWord();
            myScripture.randomWord();
            //re display
            myDisplay.display(scriptRef, myScripture._words);
            }
            else 
            {
                break;
            }
            
        } while (true);
    }
}
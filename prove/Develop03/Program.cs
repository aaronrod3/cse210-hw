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
        //string scriptRef = myScripture.getScriptureRef();
        string scriptText = myScripture.getScriptureText();
            //make scripture words into list
        myScripture._words = scriptText.Split(' ').ToList();
            //display Ref and Scripture
        // myDisplay.display(scriptRef, myScripture._words);

            //get the prompt
        // string prompt = myPrompt.prompt();
        myScripture.randomWord();
    }
}
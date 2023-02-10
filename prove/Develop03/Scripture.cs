using System;

class Scripture 
{
    public List<string> _words = new List<string>();

    static Random rnd = new Random();

    public bool isHidden(string element)
    {
        string newWord = "_____";
        if (newWord == element)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    
    public void randomWord()
    {
        //get random index from words
        var index = rnd.Next(_words.Count);
        //newword
        string newWord = "_____";
        //replace with '_____', put into list
        if (index != -1)
            _words[index] = newWord;
    }


    public string getScriptureRef()
    {
        Console.Write("Scripture Ref:");
        string scriptureRef = Console.ReadLine();

        return scriptureRef;
    }

    public string getScriptureText()
    {
        Console.Write("Scripture Text:");
        string scriptureText = Console.ReadLine();

        return scriptureText;
    }

}
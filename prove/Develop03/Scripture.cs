using System;

class Scripture 
{
    public List<string> _words = new List<string>();

    static Random rnd = new Random();

    
    public void randomWord()
    {
        //get random index from words
        var index = rnd.Next(_words.Count);
        //newword
        string newWord = "_____";
        //replace with '_____', put into list
        if (index != -1)
            _words[index] = newWord;

        //print new word list
        string newScriptText = string.Join(" ", _words);
        Console.WriteLine(newScriptText);
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
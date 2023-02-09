using System;

class Scripture 
{

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
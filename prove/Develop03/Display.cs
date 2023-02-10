using System;

class Display
{

    public void scriptureList(List<string> text)
    {
        foreach (var word in text)
        {
            //25 words
            Console.Write($"{word} ");
        }
    }

    public void display(string reference, List<string> text)
    {
        Console.Clear();
        Console.WriteLine($"{reference}");
        scriptureList(text);
    }

}
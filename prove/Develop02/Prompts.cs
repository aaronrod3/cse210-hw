using System;


public class Prompts
{

    static Random rnd = new Random();
    public List<string> _prompts = new List<string>() {"Where did you go today?","What made you happy today?","What made you sad today?","Did you learn anything new today?","Did you learn any lessons today?","Did you meet anyone new today?"};

    public string randomPrompt()
    {
        var index = rnd.Next(_prompts.Count);
        var randomItem = _prompts[index];
        return randomItem;
    }
}
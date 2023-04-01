using System;

public class Short: Event
{
    private string _type;
    
    public Short(string title, string date, string type): base(title, date)
    {
        _type = type;
    }

    public void shortMessage(string title, string date)
    {
        Console.WriteLine($"Event Type: {_type}");
        Console.WriteLine($"{title}");
        Console.WriteLine($"Date: {date}");
    }
}
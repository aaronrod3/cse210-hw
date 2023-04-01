using System;

public class Standard: Event
{
    private string _description;
    private string _time;
    private string _address;
    public Standard(string title, string description, string date, string time, string address) : base(title, date)
    {
        _description = description;
        _time = time;
        _address = address;
    }

    public void standardMessage(string title, string date)
    {
        Console.WriteLine($"{title}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"{date}");
        Console.WriteLine($"{_time}");
        Console.WriteLine($"{_address}");
    }
}
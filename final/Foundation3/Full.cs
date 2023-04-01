using System;

public class Full: Event
{
    private string _description;
    private string _time;
    private string _type;
    private string _address;
    

    public Full(string title, string description, string date, string time, string type, string address) : base(title, date)
    {
        _description = description;
        _time = time;
        _type = type;
        _address = address;
    }

    public void fullMessage(string title, string date)
    {
        Console.WriteLine($"{title}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"{date}");
        Console.WriteLine($"{_time}");
        Console.WriteLine($"{_address}");
    }

    public void returnLecture(string name, string capacity)
    {
        Console.WriteLine($"The Speaker is {name} and the capacity is {capacity}.");
    }

    public void returnReception(string email)
    {
        Console.WriteLine($"Please RSVP to this email address: {email}");
    }

    public void returnWeather(string weather)
    {
        Console.WriteLine($"The weather will be {weather}.");
    }
}
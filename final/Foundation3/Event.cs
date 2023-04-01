using System;

public class Event
{
    private string _title;
	private string _date;

    public Event(string title, string date)
    {
        _title = title;
        _date = date;
    }

    public string getTitle()
    {
        return _title;
    }

    public string getDate()
    {
        return _date;
    }
}
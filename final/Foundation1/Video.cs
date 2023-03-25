using System;

public class Video
{
    public string title;
    public string author;
    public string length;

    public List<string> comments = new List<string>();

    public void showVideo()
    {
        Console.WriteLine($"{title}, {author}, {length}");
        foreach(string comment in comments)
        {
            Console.WriteLine(comment);
        }
    }
}
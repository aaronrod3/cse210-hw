using System;



public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>() {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private string _duration;
    static Random rnd = new Random();


    public string randomPrompt()
    {
        var index = rnd.Next(_prompts.Count);
        var randomItem = _prompts[index];
        return randomItem;
    }

    public string listingOpener()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Listing Activity");
        Console.WriteLine("his activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = Console.ReadLine();
        return _duration;
    }


    public void listingSession(int duration, string prompt)
    {
        DateTime currentTime = DateTime.Now;
    
            Console.WriteLine("List as many responses you can to the following prompt:");
            Console.WriteLine($"--- {prompt} ---");

            Console.Write("You may begin in: 3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.WriteLine();

            while (DateTime.Now - currentTime < TimeSpan.FromSeconds(duration))
            {
                Console.Write("> ");
                Console.ReadLine();
            }

            Thread.Sleep(500);
            Console.WriteLine("Well done!!");
            Console.WriteLine();
            Console.WriteLine($"You have completed another {duration} seconds of the Listing Activity.");

        
        
        
        
    }
}
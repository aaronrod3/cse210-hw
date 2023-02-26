using System;



public class ReflectingActivity
{
    Activity activity2 = new Activity();

    private string _duration;
    static Random rnd = new Random();

    private List<string> _prompts = new List<string>() {
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.", 
        "Think of a time when you helped someone in need.", 
        "Think of a time when you did something truly selfless."
    };

    private List<string> _reflections = new List<string>() {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public string randomPrompt()
    {
        var index = rnd.Next(_prompts.Count);
        var randomItem = _prompts[index];
        return randomItem;
    }

    public string randomReflection()
    {
        var index = rnd.Next(_reflections.Count);
        var randomItem = _reflections[index];
        return randomItem;
    }

    public string reflectingOpener()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Reflecting Activity");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = Console.ReadLine();
        return _duration;
    }

    public void reflectingSession(int duration, string prompt)
    {
        DateTime currentTime = DateTime.Now;
        
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.Write($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        var userInput = Console.ReadKey();
        if (userInput.Key == ConsoleKey.Enter)
        {
            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");

            Console.Write("You may begin in: 3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Clear();

            while (DateTime.Now - currentTime < TimeSpan.FromSeconds(duration))
            {
                var reflection = randomReflection();
                Console.Write($"> {reflection}");
                activity2.spinner();
            }
        }
        
        
        Thread.Sleep(500);
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {duration} seconds of the Reflecting Activity.");
        
    }


}
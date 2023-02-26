using System;



public class BreathingActivity
{
    private string _duration;
    

    public string breathingOpener()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Breathing Activity");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly.\nClear you mind and focus on your breathing.\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = Console.ReadLine();
        return _duration;
    }

    public void breathingSession(int duration)
    {
        DateTime currentTime = DateTime.Now;
        

        Thread.Sleep(1000);

        while (DateTime.Now - currentTime < TimeSpan.FromSeconds(duration))
        {
            Console.Write("Breathe in... 5");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine();
            Console.Write("Breathe out... 5");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine();
        }
        
        Thread.Sleep(500);
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {duration} seconds of the Breathing Activity.");
        
    }

}
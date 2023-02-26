using System;

class Program
{
    static void Main(string[] args)
    {

        Display display1 = new Display();
        Activity activity1 = new Activity();

        do
        {
            string displayInput = display1.Menu();
            int duration;

        
            if (displayInput == "1")
            {
                BreathingActivity breathing1 = new BreathingActivity();
                duration = int.Parse(breathing1.breathingOpener());
                Console.Clear();
                Console.WriteLine("Get Ready...");
                activity1.spinner();
                breathing1.breathingSession(duration);
                activity1.spinner();
            }
            else if (displayInput == "2")
            {   
                ReflectingActivity reflecting1 = new ReflectingActivity();
                duration = int.Parse(reflecting1.reflectingOpener());
                Console.Clear();
                Console.WriteLine("Get Ready...");
                activity1.spinner();
                string reflectingPrompt = reflecting1.randomPrompt();
                reflecting1.reflectingSession(duration, reflectingPrompt);
                activity1.spinner();
            } 
            else if (displayInput == "3") 
            {
                ListingActivity listing1 = new ListingActivity();
                duration = int.Parse(listing1.listingOpener());
                Console.Clear();
                Console.WriteLine("Get Ready...");
                activity1.spinner();
                string listingPrompt = listing1.randomPrompt();
                listing1.listingSession(duration, listingPrompt);
                activity1.spinner();
            }
            else if (displayInput == "4")
            {
                break;
            }
        }while (true);


    }
}
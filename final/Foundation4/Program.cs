using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<Activity> activities = new List<Activity>();

        Console.Write("What is the date: ");
        string date = Console.ReadLine();
        Console.Write("What is the elapsed time of acitivty: ");
        float time = float.Parse(Console.ReadLine());
        Console.Write("What is the distance (in km): ");
        float distance = float.Parse(Console.ReadLine());
        Console.Write("How many laps: ");
        float laps = float.Parse(Console.ReadLine());
        
        activities.Add(new Running(date, time, distance));
        activities.Add(new StationBikes(date, time, distance));
        activities.Add(new Swimming(date,time,distance,laps));

        void GetSummary()
        {
            foreach(Activity activity in activities)
            {
                float calcDist = activity.CalculateDistance();
                float calcSpeed = activity.CalculateSpeed(time);
                float calcPace = activity.CalculatePace(time);
                string name = activity.GetActivityName();
                Console.WriteLine("Activity Summary:");
                Console.WriteLine($"{date} {name} ({time} min)- Distance {calcDist} km, Speed {calcSpeed} kph, Pace: {calcPace} min per km");
            }
        }

        Console.Clear();
        GetSummary();

    }
}
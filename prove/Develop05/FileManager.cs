using System;
using System.IO;

public class FileManager
{
    public int points;
    private string filename = "goalList.txt";
    public List<string> goalList = new List<string>();
    public List<Goal> loadedGoals = new List<Goal>();

    public void listGoal()
    {
        foreach (String goal in goalList)
        {
            Console.WriteLine(goal);
        }
    }
    public void saveGoal(int points)
    {
        using (StreamWriter w = new StreamWriter(filename))
        {
            w.WriteLine(points);
            foreach (String goal in goalList)
            {
                    w.WriteLine(goal);
            }
        }
        
    }

    public void loadGoal()
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            goalList.Add(line);
        }
    }

    public void grabGoals()
    {
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] col = line.Split(",");
            if (col.Length == 3)
            {
                string name = col[0];
                int points = int.Parse(col[2]);
                Console.WriteLine(points);
            }
            if (col.Length == 4)
            {
                string name = col[0];
                int points = int.Parse(col[2]);
                Console.WriteLine(points);
            }
            else if (col.Length == 6)
            {
                string name = col[0];
                int points = int.Parse(col[2]);
                int desiredAmount = int.Parse(col[3]);
                int bonus = int.Parse(col[4]);
                Console.WriteLine(points);
            }
        }
    }



}
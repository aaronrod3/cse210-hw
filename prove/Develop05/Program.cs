using System;

class Program
{
    static void Main(string[] args)
    {
        
        Display display1 = new Display();
        FileManager fm1 = new FileManager();
        Goal g1 = new Goal();

        do
        {
            string displayInput = display1.Menu();
            int totalPoints = fm1.points;

        
            if (displayInput == "1")
            {
                string displayInput1 = display1.createMenu();
                if (displayInput1 == "1")
                {
                    Console.Write("What is the name of your goal?");
                    string name = Console.ReadLine();

                    Console.Write("What is a short description of it?");
                    string description = Console.ReadLine();

                    Console.Write("What is the amount of points asscociated with this goal?");
                    string points = Console.ReadLine();

                    bool complete = false;

                    SimpleGoal simple1 = new SimpleGoal(name, description, points, complete);
                    string goal = simple1.GetDisplayString();
                    fm1.goalList.Add(goal);
                }
                else if (displayInput1 == "2")
                {   
                    Console.Write("What is the name of your goal?");
                    string name = Console.ReadLine();

                    Console.Write("What is a short description of it?");
                    string description = Console.ReadLine();

                    Console.Write("What is the amount of points asscociated with this goal?");
                    string points = Console.ReadLine();

                    EternalGoal eternal1 = new EternalGoal(name, description, points);
                    string goal = eternal1.GetDisplayString();
                    fm1.goalList.Add(goal);
                } 
                else if (displayInput1 == "3") 
                {
                    Console.Write("What is the name of your goal?");
                    string name = Console.ReadLine();

                    Console.Write("What is a short description of it?");
                    string description = Console.ReadLine();

                    Console.Write("What is the amount of points asscociated with this goal?");
                    string points = Console.ReadLine();

                    Console.Write("How mant times does this goal need to be accomplished for a bonus?");
                    string desiredAmount = Console.ReadLine();

                    Console.Write("What is the bonus for accomplishing it that many times?");
                    string bonus = Console.ReadLine();

                    ChecklistGoal checklist1 = new ChecklistGoal(name,description, points, desiredAmount, bonus);
                    string goal = checklist1.GetDisplayString();
                    fm1.goalList.Add(goal);
                }
            }
            else if (displayInput == "2")
            {   
                fm1.listGoal();
            } 
            else if (displayInput == "3") 
            {
                fm1.saveGoal(totalPoints);
            }
            else if (displayInput == "4") 
            {
                fm1.loadGoal();
            }
            else if (displayInput == "5") 
            {
                Console.WriteLine("The goals were: ");
                fm1.grabGoals();
                Console.Write("Which goal did you accomplish? ");
                string display2 = Console.ReadLine();
                
            }
            else if (displayInput == "6")
            {
                break;
            }
        }while (true);


    }
}
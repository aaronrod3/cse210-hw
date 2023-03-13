using System;

public class EternalGoal : Goal
{

    private string _goalname;
    private string _goaldescription;
    private int _points;

    public EternalGoal(string goalname, string goaldescription, string points)
    {
        _goalname = goalname;
        _goaldescription = goaldescription;
        _points = int.Parse(points);
    }

    public string GetDisplayString()
    {   
        string goalString = ($"EternalGoal:{_goalname},{_goaldescription},{_points}");
        return goalString;
    }
}
using System;

public class SimpleGoal : Goal
{

    bool _complete;
    private string _goalname;
    private string _goaldescription;
    private int _points = 0;

    public SimpleGoal(string goalname, string goaldescription, string points, bool complete)
    {
        _goalname = goalname;
        _goaldescription = goaldescription;
        _points = int.Parse(points);
        _complete = complete;
    }

    public string GetDisplayString()
    {   
        string goalString = ($"SimpleGoal:{_goalname},{_goaldescription},{_points},{_complete}");
        return goalString;
    }

    // public RecordEvent()
    // {

    // }
    
}
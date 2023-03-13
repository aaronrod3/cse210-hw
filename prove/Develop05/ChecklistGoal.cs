using System;

public class ChecklistGoal : Goal
{

    private string _goalname;
    private string _goaldescription;
    private int _points;
    private int _desiredAmount;
    private int _amountCompleted;
    private int _bonusAmount;

    public ChecklistGoal(string goalname, string goaldescription, string points, string desiredAmount, string bonus)
    {
        _goalname = goalname;
        _goaldescription = goaldescription;
        _points = int.Parse(points);
        _desiredAmount = int.Parse(desiredAmount);
        _bonusAmount = int.Parse(bonus);
    }

    public string GetDisplayString()
    {   
        string goalString = ($"ChecklistGoal:{_goalname},{_goaldescription},{_points},{_bonusAmount},{_desiredAmount},{_amountCompleted}");
        return goalString;
    }
}
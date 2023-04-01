using System;

public class Running: Activity
{
    private float _distance;

    public Running(string date, float time, float distance) : base(date, time)
    {
        _distance = distance;
    }

    public override string GetActivityName()
    {
        string name = "Running";
        return name;
    }

    public override float CalculateDistance()
    {
        return _distance;
    }

    public override float CalculateSpeed(float time)
    {
        float speed = (_distance / time) * 60;
        return speed;
    }

    public override float CalculatePace(float time)
    {
        float pace = time / _distance;
        return pace;
    }
}
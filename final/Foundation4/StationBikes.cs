using System;

public class StationBikes : Activity
{
    private float _distance;

    public StationBikes(string date, float time, float distance) : base(date, time)
    {
        _distance = distance;
    }

    public override string GetActivityName()
    {
        string name = "Stationary Bike";
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
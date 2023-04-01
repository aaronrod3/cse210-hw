using System;

public class Swimming : Activity
{
    private float _distance;
    private float _laps;

    public Swimming(string date, float time, float distance, float laps) : base(date, time)
    {
        _laps = laps;
        _distance = distance;
    }

    public override string GetActivityName()
    {
        string name = "Swimming";
        return name;
    }

    public override float CalculateDistance()
    {
        float distance = _laps * 50 / 1000;
        return distance;
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
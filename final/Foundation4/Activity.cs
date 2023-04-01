using System;

public abstract class Activity
{
    private string _date;
    private float _time;

    public Activity(string date, float time)
    {
        _date = date;
        _time = time;
    }

    public abstract string GetActivityName();

    public abstract float CalculateDistance();
    public abstract float CalculateSpeed(float time);
    public abstract float CalculatePace(float time);
}
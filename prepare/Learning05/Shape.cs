using System;



public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    //getter for color
    public string GetColor()
    {
        return _color;
    }

    // setter for color
    public void SetColor(string color)
    {
        _color = color;
    }

    // abstract function that can be filled in by sub-classes
    public abstract double GetArea();
}
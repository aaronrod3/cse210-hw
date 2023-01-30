using System;


class Fraction 
{
    private int _bottomNumber;
    private int _topNumber;

    public void setFraction(int topNumber, int bottomNumber)
    {
        _bottomNumber = bottomNumber;
        _topNumber = topNumber;    }
        
    public string getFractionString()
    {
        string input = $"{_topNumber}/{_bottomNumber}";
        return input;
    }

    public double getDecimalValue()
    {
        return (double)_topNumber / (double)_bottomNumber;
    }
    public Fraction()
    {
        _bottomNumber = 1;
        _topNumber = 1;
    }

    public Fraction(int top)
    {
        _bottomNumber = 1;
        _topNumber = top;
    }

    public Fraction(int top, int bottom)
    {
        _bottomNumber = bottom;
        _topNumber = top;
    }




}
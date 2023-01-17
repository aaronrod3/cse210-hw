using System;


class Job
{
    public string _jobTitle;
    public string _parentCompany;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_parentCompany}) {_startYear}-{_endYear}");
    }

}
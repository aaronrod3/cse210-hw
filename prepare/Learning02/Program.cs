using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._parentCompany = "Microsoft";
        job1._startYear = 2010;
        job1._endYear = 2020;

        Resume myResume = new Resume();
        myResume._name = "Aaron Rodriguez";

        myResume._jobs.Add(job1);
        myResume.Display();

    }
}
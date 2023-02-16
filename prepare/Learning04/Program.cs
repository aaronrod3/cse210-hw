using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Aaron Rodriguez", "Math");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment math1 = new MathAssignment("Aaron Rodriguez","Math", "7.3", "8-19");
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment writing1 = new WritingAssignment("A R", "History", "World History");
        Console.WriteLine(writing1.GetWritingInformation());
    }
}
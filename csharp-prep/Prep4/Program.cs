using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int>();

        int userNumber = -1;

        do 
        {
            Console.Write("Enter a number to add to list, enter 0 if done: ");
            userNumber = int.Parse(Console.ReadLine());
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }while (userNumber != 0);


        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        

        float average = ((float)sum) / numbers.Count;


        int max = 0;

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }



        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Highest number: {max}");

    }
}
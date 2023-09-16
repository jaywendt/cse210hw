using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? Numbers only please: ");
        string percent = Console.ReadLine();

        int grade = int.Parse(percent);

        string letter ="";

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}.");

        if (grade >= 70)
        {
            Console.Write("Congratulations!  You've passed!");
        }
        else
        {
            Console.Write("Sorry, try again next time!");
        }

    }
}
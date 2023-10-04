using System;

class Program
{
    static void Main(string[] args)
    {
        Assignments assign1 = new Assignments("Samuel Bennet", "Multiplication");
        Console.WriteLine(assign1.GetSummary());

        MathAssignment math1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment write1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(write1.GetSummary());
        Console.WriteLine(write1.GetWritingInformation());
    }
}
using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture() : base("Lecture Event")
    {
    }

    public void Start()
    {
        int adChoice = 0;
        do
        {
        Console.WriteLine("You have chosen to create an ad for a Lecture Event.  Please enter what type of Advertisement you wish to create: ");
        Thread.Sleep(1000);
        Console.WriteLine("1. Standard (Title, Description, Date, Time, and Address)");
        Thread.Sleep(1000);
        Console.WriteLine("2. Full Details (Event Name, Type, Description, Date, Time, and Address.  Also includes speaker name and audience capacity)");
        Thread.Sleep(1000);
        Console.WriteLine("3. Short Description (Event type, Event Name, and Date)");
        Thread.Sleep(1000);
        Console.WriteLine("4. Quit Ad Creator");
        adChoice = int.Parse(Console.ReadLine());

        if (adChoice == 1)
        {
            Console.WriteLine();
            CreateStandard();
            Console.WriteLine();
            PrintStandardResult();
            Console.WriteLine();
            End();
        }
        else if (adChoice == 2)
        {
            Console.WriteLine();
            Console.WriteLine("Please enter the following additional information: ");
            Console.WriteLine("What is the name of the speaker? ");
            _speaker = Console.ReadLine();
            Console.WriteLine("What is the maximum audience capacity? ");
            _capacity = int.Parse(Console.ReadLine());
            CreateFull();
            Console.WriteLine();
            Console.WriteLine("Excellent.  After your input, your advertisement will look like this: ");
            Console.WriteLine();
            Console.WriteLine("You have been invited to a Lecture Event to listen to");
            Console.WriteLine($"{_speaker} @");
            PrintStandardResult();
            Console.WriteLine($"Please be aware that there is a maximum seating of {_capacity}.  First come, first served.");
            Console.WriteLine();
            End();
        }
        else if (adChoice == 3)
        {
            Console.WriteLine();
            CreateShort();
            Console.WriteLine();
            PrintShortResult();
            Console.WriteLine();
            End();
        }

        }
        while (adChoice != 4);
    }
}
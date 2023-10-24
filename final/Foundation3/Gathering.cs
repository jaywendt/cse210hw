using System;

public class Gathering : Event
{
    private string _weather;

    public Gathering() : base("Outdoor Gathering Event")
    {
    }

    public void Start()
    {
        int adChoice = 0;
        do
        {
        Console.WriteLine("You have chosen to create an ad for an Outdoor Gathering Event.  Please enter what type of Advertisement you wish to create: ");
        Thread.Sleep(1000);
        Console.WriteLine("1. Standard (Title, Description, Date, Time, and Address)");
        Thread.Sleep(1000);
        Console.WriteLine("2. Full Details (Event Name, Type, Description, Date, Time, and Address.  Also includes option for weather forecast)");
        Thread.Sleep(1000);
        Console.WriteLine("3. Short Description (Event type, Event Name, and Date)");
        Thread.Sleep(1000);
        Console.WriteLine("4. Quit Ad Creator");
        adChoice = int.Parse(Console.ReadLine());

        if (adChoice == 1)
        {
            CreateStandard();
            PrintStandardResult();
            End();
        }
        else if (adChoice == 2)
        {
            Console.WriteLine();
            Console.WriteLine("Please enter the following additional information: ");
            Console.WriteLine("What is the weather forecasted to be like on the day of the gathering?  (Sunny, Hot, Cloudy, Windy, etc.) ");
            _weather = Console.ReadLine();
            CreateFull();
            Console.WriteLine();
            Console.WriteLine("Excellent.  After your input, your advertisement will look like this: ");
            Console.WriteLine();
            Console.WriteLine($"You have been invited to: ");
            PrintStandardResult();
            Console.WriteLine($"Please be aware that the weather is forecasted to be {_weather}, so please dress appropriately.");
            End();
            Console.WriteLine();
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
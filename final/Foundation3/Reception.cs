using System;

public class Reception : Event
{
    private string _email;
    private string _couple;

    public Reception() : base("Reception Event")
    {
    }
    
    public void Start()
    {
        int adChoice = 0;
        do
        {
        Console.WriteLine("You have chosen to create an ad for a Reception Event.  Please enter what type of Advertisement you wish to create: ");
        Thread.Sleep(1000);
        Console.WriteLine("1. Standard (Title, Description, Date, Time, and Address)");
        Thread.Sleep(1000);
        Console.WriteLine("2. Full Details (Event Name, Type, Description, Date, Time, and Address.  Also includes email for RSVP option)");
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
            Console.WriteLine("What is the last name of the couple being married? ");
            _couple = Console.ReadLine();
            Console.WriteLine("What is the e-mail for the RSVP? ");
            _email = Console.ReadLine();
            CreateFull();
            Console.WriteLine();
            Console.WriteLine("Excellent.  After your input, your advertisement will look like this: ");
            Console.WriteLine();
            Console.WriteLine($"You have been invited to the Reception of the {_couple}");
            PrintStandardResult();
            Console.WriteLine($"Please R.S.V.P. @ {_email}");
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
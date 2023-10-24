using System;

public class Event
{
    private string _title;
    private string _eventType;
    private string _description;
    private string _date;
    private string _time;
    private string _address;

    public Event(string title)
    {
        _title = title;
    }

    public void CreateStandard()
    {
        Console.WriteLine();
        Console.WriteLine("Please enter the following information:");
        Thread.Sleep(1000);
        Console.WriteLine("Title of the event: ");
        _title = Console.ReadLine();
        Console.WriteLine("A short description of the event: ");
        _description = Console.ReadLine();
        Console.WriteLine("The date this event will take place (mm//dd/yyyy format please): ");
        _date = Console.ReadLine();
        Console.WriteLine("The time this event shall start (##:## format please): ");
        _time = Console.ReadLine();
        TimeOnly time;
        var isValidTime = TimeOnly.TryParse(_time, out time);
        if (isValidTime)
        {
            Console.WriteLine(time);
        }
        else
        {
            Console.WriteLine($"{_time} is not a valid entry.");
        }
        Console.WriteLine("The address of the event: ");
        _address = Console.ReadLine();

    }

    public void CreateFull()
    {
        Console.WriteLine();
        Console.WriteLine("Please enter the following information:");
        Thread.Sleep(1000);
        Console.WriteLine("What type of event is this: A Lecture, a Reception, or an Outdoor Gathering? ");
        _eventType = Console.ReadLine();
        Console.WriteLine("Title of the event: ");
        _title = Console.ReadLine();
        Console.WriteLine("A short description of the event: ");
        _description = Console.ReadLine();
        Console.WriteLine("The date this event will take place (mm/dd/yyyy): ");
        _date = Console.ReadLine();
        DateTime dt;
        var isValidDate = DateTime.TryParse(_date, out dt);
        if (isValidDate)
        {
            Console.WriteLine(dt);
        }
        else
        {
            Console.WriteLine($"{_date} is not a valid date.");
        }
        Console.WriteLine("The time this event shall start (##:## format please): ");
        _time = Console.ReadLine();
        TimeOnly time;
        var isValidTime = TimeOnly.TryParse(_time, out time);
        if (isValidTime)
        {
            Console.WriteLine(time);
        }
        else
        {
            Console.WriteLine($"{_time} is not a valid entry.");
        }
        Console.WriteLine("The address of the event: ");
        _address = Console.ReadLine();
    }

    public void CreateShort()
    {
        Console.WriteLine();
        Console.WriteLine("Please enter the following information:");
        Thread.Sleep(1000);
        Console.WriteLine("What type of event is this: A Lecture, a Reception, or an Outdoor Gathering? ");
        _eventType = Console.ReadLine();
        Console.WriteLine("Title of the event: ");
        _title = Console.ReadLine();
        Console.WriteLine("The date this event will take place (mm/dd/yyyy): ");
        _date = Console.ReadLine();
        DateTime dt;
        var isValidDate = DateTime.TryParse(_date, out dt);
        if (isValidDate)
        {
            Console.WriteLine(dt);
        }
        else
        {
            Console.WriteLine($"{_date} is not a valid date.");
        }
    }

    public void PrintStandardResult()
    {
        Console.WriteLine();
        Console.WriteLine("Excellent.  After your input, your advertisement will appear like this: ");
        Console.WriteLine();
        Console.WriteLine($"{_title}:");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"{_date}, @ {_time}");
        Console.WriteLine($"Happening at: {_address}");
        Console.WriteLine();
    }

    public void PrintShortResult()
    {
        Console.WriteLine();
        Console.WriteLine($"{_eventType}, {_title}, {_date}");
        Console.WriteLine();
    }

    public void End()
    {
        Console.WriteLine();
        Console.WriteLine("You have finished with the Advertisement Creator.  Goodbye!");
        Console.WriteLine();
    }
}
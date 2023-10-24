using System;

public class Event
{
    private string _title;
    private string _description;
    private int _date;
    private int _time;
    private string _address;

    public Event(string title)
    {
        _title = title;
    }

    public void CreateStandard()
    {
        Console.WriteLine();
        Console.WriteLine("Please enter the following information:");
        Thread.Sleep(3000);
        Console.WriteLine("Title of the event: ");
        _title = Console.ReadLine();
        Console.WriteLine("A short description of the event: ");
        _description = Console.ReadLine();
        Console.WriteLine("The date this event will take place: ");
        _date = int.Parse(Console.ReadLine());
        Console.WriteLine("The time this event shall start: ");
        _time = int.Parse(Console.ReadLine());
        Console.WriteLine("The address of the event: ");
        _address = Console.ReadLine();

    }

    public void CreateFull()
    {
        Console.WriteLine();
        Console.WriteLine("Please enter the following information:");
        Thread.Sleep(3000);
        Console.WriteLine("What type of event is this: A Lecture, a Reception, or an Outdoor Gathering? ");
        string type = Console.ReadLine();
        Console.WriteLine("Title of the event: ");
        _title = Console.ReadLine();
        Console.WriteLine("A short description of the event: ");
        _description = Console.ReadLine();
        Console.WriteLine("The date this event will take place: ");
        _date = int.Parse(Console.ReadLine());
        Console.WriteLine("The time this event shall start: ");
        _time = int.Parse(Console.ReadLine());
        Console.WriteLine("The address of the event: ");
        _address = Console.ReadLine();
    }

    public void CreateShort()
    {
        Console.WriteLine();
        Console.WriteLine("Please enter the following information:");
        Thread.Sleep(3000);
        Console.WriteLine("What type of event is this: A Lecture, a Reception, or an Outdoor Gathering? ");
        string type = Console.ReadLine();
        Console.WriteLine("Title of the event: ");
        _title = Console.ReadLine();
        Console.WriteLine("The date this event will take place: ");
        _date = int.Parse(Console.ReadLine());
    }
}
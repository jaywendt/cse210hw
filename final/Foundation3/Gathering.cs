using System;

public class Gathering : Event
{
    private string _weather;

    public Gathering(string weather) : base("Outdoor Gathering Event")
    {
        _weather = weather;
    }
}
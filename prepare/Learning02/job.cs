using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _start;
    public int _end;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle}, {_company}, {_start}-{_end}");
    }
}
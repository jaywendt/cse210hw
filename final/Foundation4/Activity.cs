using System;

public abstract class Activity
{
    protected string _date;
    protected int _length; /* in minutes */
    protected string _name;
    protected int _distance;

    public Activity(string name, int distance, int length)
    {
        _length = length;
        _name = name;
        _distance = distance;
    }

    
    public void ActivityName()
    {
        Console.WriteLine(_name);
    }
    public int GetLength()
    {
        return _length;
    }

    public string GetDate()
    {
        return _date;
    }

    public virtual void DisplayDateLength()
    {
        Console.WriteLine($"{_date}: {_length}");
    }

    public abstract int GetDistance();
    public abstract int GetSpeed();
    public abstract int GetPace();
    public abstract void GetSummary();
}
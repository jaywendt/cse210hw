using System;

public class Bicycles : Activity
{
    private int _speed; /*in miles per hour*/

    public Bicycles(int speed, int length, int distance) : base("Bicycles", distance, length)
    {
        _speed = speed;
    }

    public override int GetDistance()
    {
        return _distance;
    }

    public override int GetPace()
    {
        return _length / _distance;
    }

    public override int GetSpeed()
    {
        return (_distance / _length) * 60;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{_date} {_name} ({_length}): Distance: " + GetDistance() + ", Speed: " + GetSpeed() + ", Pace: " + GetPace() + " minutes per mile");
    }
}
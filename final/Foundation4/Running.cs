using System;

public class Running : Activity
{
    public Running(int distance, int length) : base( "Running", distance, length)
    {
        _distance = distance;
    }

    public override int GetDistance()
    {
        return _distance;
    }

    public override int GetSpeed()
    {
        return (_distance / _length) * 60;
    }

    public override int GetPace()
    {
        return _length / _distance ;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{_date} {_name} ({_length}): Distance: " + GetDistance() + ", Speed: " + GetSpeed() + ", Pace: " + GetPace() + " minutes per mile");
    }
}
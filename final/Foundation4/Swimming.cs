using System;

public class Swimming : Activity
{
    private int _laps; /* * 50 */

    public Swimming(int laps, int length, int distance) : base("Swimming", distance, length)
    {
        _laps = laps;
    }

    public override int GetDistance()
    {
        return _distance * 50 / 1000;
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
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> act = new List<Activity>();
        act.Add(new Running(50, 15));
        act.Add(new Bicycles(15, 60, 25));
        act.Add(new Swimming(10, 50, 20));

        foreach (Activity a in act)
        {
            a.GetSummary();
        }
    }
}
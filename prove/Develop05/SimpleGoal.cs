using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base("Simple Goal")
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, int points, bool complete) : base("Simple Goal")
    {
        _isComplete = complete;
    }

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public void Completed()
    {
        _isComplete = true;
    }

    public void NotComplete()
    {
        _isComplete = false;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}
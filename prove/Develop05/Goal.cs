using System;

public class Goal 
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent()
    {

    }

    public virtual bool IsComplete()
    {
        
    }

    public virtual string GetDetailsString()
    {

    }

    public virtual string GetStringRepresentation()
    {

    }
}
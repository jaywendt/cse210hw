using System;
using System.Formats.Asn1;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
    }

    public void Start()
    {

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your current score is: {_score}.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Current Goals: ");
        foreach (string a in Goals)
        {
            Console.WriteLine(a);
        }
    }

    public void ListGoalDetails()
    {

    }

    public void CreateGoal()
    {
        Console.WriteLine("You wish to create a new goal!");
        Console.WriteLine("Please enter what number goal you wish to set:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        int answer = int.Parse(Console.ReadLine());

        if (answer == 1)
        {
            SimpleGoal sg = new SimpleGoal(name, description, points);
            Console.WriteLine(sg);
            _goals.Add(sg);
            
        }
        else if (answer == 2)
        {
            EternalGoal eg = new EternalGoal(name, description, points);
            Console.WriteLine(eg);
            _goals.Add(eg);
        }
        else
        {
            ChecklistGoal cg = new ChecklistGoal(name, description, points, target, bonus);
            Console.WriteLine(cg);
            _goals.Add(cg);
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("You wish to record a new event!  Please enter which goal you wish to record for: ");
        string response = Console.ReadLine();
    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {
        
    }
}
using System;

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
        Console.WriteLine("Please enter what you want your new goal name to be:");
        string goalName = Console.ReadLine();
        _goals.Add(goalName);
        Console.WriteLine("Now enter a description of your goal: ");
        string goalDesc = Console.ReadLine();
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
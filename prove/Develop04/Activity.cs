using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public void DisplayStartingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Welcome to your {_name} activity!  The activity will be starting soon.");
        Thread.Sleep(5000);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Great job!  Thanks for working hard on this activity!");
        Console.WriteLine();
    }

    public void ShowSpinner()
    {
        List<string> spinner = new List<string>();
        spinner.Add("+");
        spinner.Add("x");
        spinner.Add("+");
        spinner.Add("x");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
        
    }

    public void Countdown()
    {
        Console.WriteLine("The activity will start in 3.");
        Thread.Sleep(1000);
        Console.WriteLine("2.");
        Thread.Sleep(1000);
        Console.WriteLine("1.");
        Thread.Sleep(1000);
        Console.WriteLine("Begin!");
    }

    public Activity(string name)
    {
        _name = name;
    }
}
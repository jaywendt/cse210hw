using System;

public class ListingActivity : Activity
{
    private string _prompt;

    public void Run()
    {
        int _duration = 0;
        
        do
        {
            DisplayStartingMessage();
            Console.WriteLine("Welcome to your Listing activity!  This activity is here to help you look back on the good things in your life by having you list as many of these things from a certain category.  Please enter how long you wish for this activity to last: ");
            _duration = int.Parse(Console.ReadLine());
            Console.WriteLine("An excellent choice!  Now, here's how the program goes:  a prompt will be displayed that will ask you a question.  For you to answer this question, you must list as many answers to the prompt as you can.");
            ShowSpinner();
            Console.WriteLine("Are you ready?");
            ShowSpinner();
            Countdown();
            Console.WriteLine();
            GetRandomPrompt();
            Console.ReadLine();
        }
        while (_duration != 0);
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        return _prompt;
    }

    public ListingActivity() : base("Listing Activity")
    {
        Random random = new Random();
        List<string> prompt = new List<string>() {
            "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"
        };
        int index = random.Next(prompt.Count);
        _prompt = prompt[index];
    }
}
using System;

public class ReflectingActivity : Activity
{
    private int _count;

    private string _prompts;
    private string _questions;

    public void Run()
    {
        int _duration = 0;

        do
        {
            DisplayStartingMessage();
            Console.WriteLine("Welcome to your Reflection activity!  The purpose of this activity is to help you think back to times in your life when you have shown strength and resilience.  This will help you see how strong you truly are and how to tap into that strength today.  Please enter the amount of time you wish to spend on this activity: ");
            _duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Excellent choice.  Now, the way this activity works is like this:  The program will display a prompt for you to think about, and then after a few more seconds, it will then ask a question for you to respond to about that prompt.");
            ShowSpinner();
            Console.WriteLine("Are you ready?");
            ShowSpinner();
            Console.WriteLine();
            Countdown();
            Console.WriteLine();
            DisplayPrompt();
            ShowSpinner();
            DisplayQuestions();
        }
        while (_duration != 0);
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        return _prompts;
    }

    public string GetRandomQuestion()
    {
        return _questions;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }

    public ReflectingActivity() : base("Reflecting Activity")
    {
        Random random = new Random();
        List<string> prompts = new List<string>() {
            "Think of a time when you had to make a difficult choice.", "Think of a time when you were there for someone else.", "Think of a time when you felt like you made a real change in your life.", "Think of a time when you did something truly selfless.", "Think of a time when you chose to do the right thing even though it was difficult.", "Think of a time when you felt like you were the only person in the room making good choices.", "Think of a time when you stood up for someone else."
        };
        int index = random.Next(prompts.Count);
        _prompts = prompts[index];

        Random random1 = new Random();
        List<string> questions = new List<string>() {
            "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"
        };
        int index1 = random1.Next(questions.Count);
        _questions = questions[index];
    }
}
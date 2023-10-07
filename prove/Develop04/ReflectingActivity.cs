using System;

public class ReflectingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public void Run()
    {
        DisplayStartingMessage();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        return ;
    }

    public string GetRandomQuestion()
    {
        return ;
    }

    public void DisplayPrompt()
    {
        
    }

    public void DisplayQuestions()
    {

    }

    public ReflectingActivity() : base("Reflecting Activity")
    {
        Random random = new Random();
        List<string> prompts = new List<string>() {
            ""
        };
    }
}
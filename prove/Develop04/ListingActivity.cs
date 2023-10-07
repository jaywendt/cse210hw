using System;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public void Run()
    {
        DisplayStartingMessage();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {

    }

    public List<string> GetListFromUser()
    {

    }

    public ListingActivity() : base("Listing Activity")
    {
    }
}
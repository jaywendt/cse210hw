using System;
using System.Reflection.Metadata;

public class BreathingActivity : Activity
{
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("The purpose of this activity is to help you center yourself through focusing your breathing and helping you to relax.  As you go through this exercise, remember to keep an eye on the timer and follow along.  Please enter how long you wish for this exercise to last: ");
        Countdown();
        DisplayEndingMessage();
    }

    public BreathingActivity() : base("BreathingActivity Activity")
    {
    }
}
using System;
using System.Reflection.Metadata;

public class BreathingActivity : Activity
{
    public void Run()
    {
        int _duration = 0;
        
        do
        {
            DateTime begin = DateTime.Now;
            DateTime end = begin.AddSeconds(_duration);

            DisplayStartingMessage();
            Console.WriteLine("The purpose of this activity is to help you center yourself through focusing your breathing and helping you to relax.  As you go through this exercise, remember to keep an eye on the timer and follow along.  Please enter how long you wish for this exercise to last: ");
            _duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Excellent choice!  Now, prepare yourself.  Follow the instructions on the screen by breathing in and then breathing out according to the timer.");
            ShowSpinner();
            Console.WriteLine("Are you ready?");
            ShowSpinner();
            Countdown();

            while (DateTime.Now > end)
            {
                Console.WriteLine("Slowly, breathe in...");
                Thread.Sleep(5000);
                Console.WriteLine("And now breathe out...");
            }
            
        }
        while (_duration != 0);
        DisplayEndingMessage();
    }

    public BreathingActivity() : base("BreathingActivity Activity")
    {
    }
}
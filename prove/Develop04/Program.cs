using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "0";

        do
        {
            Console.WriteLine("Welcome to your mindfulness activity menu.  Thank you for coming!");
            Console.WriteLine();
            Console.WriteLine("Please select an activity from the following choices: ");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("Exit");
            Console.WriteLine("Your choice?");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breath1 = new BreathingActivity();
                breath1.Run();
            }

            else if (choice == "2")
            {
                ReflectingActivity ref1 = new ReflectingActivity();
                ref1.Run();
            }

            else if (choice == "3")
            {
                ListingActivity list1 = new ListingActivity();
                list1.Run();
            }

        }
        while (choice != "4");
        Console.WriteLine("Thank you for taking a minute to be mindful with us!  Goodbye!");
    }
}
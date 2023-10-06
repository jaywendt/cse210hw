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

            }

            else if (choice == "2")
            {

            }

            else if (choice == "3")
            {
                
            }

        }
        while (choice != "4");
        Console.WriteLine("Thank you for taking a minute with us!  Goodbye!");
    }
}
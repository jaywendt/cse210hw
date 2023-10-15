using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "0";

        do
        {
            List<Goal> goals = new List<Goal>();

            Console.WriteLine("Welcome to your goal management program!");
            Console.WriteLine();
            Console.WriteLine($"You currently have {points} points.");
            Console.WriteLine();
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. Start New Goal");
            Console.WriteLine("2. List Current Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Please select a menu option: ");
            Console.WriteLine();
            choice = Console.ReadLine();

            if (choice == "1")
            {
                
            }
            else if (choice == "2")
            {

            }
            else if (choice =="3")
            {

            }
            else if (choice == "4")
            {

            }
            else if (choice == "5")
            {

            }
        }
        while (choice != "6");
        Console.WriteLine("Thank you!  Come back soon!");
    }
}
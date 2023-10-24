using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "0";

        do
        {
            Console.WriteLine("Welcome to the Event Advertisement Creator!  Please select what type of event you wish to create from the following: ");
            Console.WriteLine();
            Console.WriteLine("1. Lecture");
            Thread.Sleep(1000);
            Console.WriteLine("2. Reception");
            Thread.Sleep(1000);
            Console.WriteLine("3. Outdoor Gathering");
            Thread.Sleep(1000);
            Console.WriteLine("4. Close program");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Lecture lec = new Lecture();
                lec.Start();
            }
            else if (choice == "2")
            {
                Reception rec = new Reception();
                rec.Start();
            }
            else if (choice == "3")
            {
                Gathering gat = new Gathering();
                gat.Start();
            }
        }
        while (choice != "4");
        Console.WriteLine("Thank you for using our Ad Creator.  Goodbye!");
        Thread.Sleep(5000);
        Console.Clear();
    }
}
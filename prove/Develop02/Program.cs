using System;
using System.Net;
using System.IO;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        DateTime currentDate = DateTime.Now;

        var GenPrompt = new Random();
        var promptList = new List<string>{"What was the most memorable part of your day?", "What did someone say today that really stuck with you?", "Write about the hardest part of your day today.", "How do you think you could have done today better? Why?", "Who did you talk to today and what did you talk about?", "What was something interesting that you've seen today?"};
        int index = random.Next(promptList.Count);

        int response = -1;

        while (response != 5)
        {
            Console.WriteLine("Welcome to your journal!  Please input one of the following option numbers: ");
            Console.WriteLine("1. Write New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal to File");
            Console.WriteLine("4. Load Journal from File");
            Console.WriteLine("5. Quit");
            response = Console.Read();

            if (response == 1)
            {
                Entry newEntry = new Entry();
                newEntry._date = currentDate.ToShortDateString();
                Console.WriteLine("Go ahead and put in a new entry for your journal! Press enter when done.");
                Console.WriteLine(promptList[index]);
                newEntry._entryText = Console.ReadLine();
                
                Journal journalEntry = new Journal();
                journalEntry.AddEntry();
            }

            else if (response == 2)
            {

            }

            else if (response == 3)
            {

            }

            else if (response == 4)
            {

            }

            else
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
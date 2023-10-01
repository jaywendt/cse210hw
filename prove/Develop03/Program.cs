using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your scripture memorizer!");
        Console.WriteLine("Memorize this scripture!");

        Reference newRef = new Reference("Third Nephi", 5, 13);
        newRef.Display();
        newRef.GetDisplayText();
        
        Scripture newScrip = new Scripture(newRef, "Behold, I am a disciple of Jesus Christ, the Son of God.  I have been called of him to declare his word among his people, that they might have everlasting life.");
        newScrip._words.Add(newRef);

        Console.WriteLine("Press enter to continue, or type 'quit' to end the program.");
        string ender = Console.ReadLine();

        if (ender == "quit")
        {
            Console.Clear();
        }
        else
        {
            Console.WriteLine();
        }
    }
}
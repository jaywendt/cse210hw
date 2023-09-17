using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random ranGen = new Random();
        int magNum = ranGen.Next(1, 100);

        int guess = -1;

        while (guess != magNum)
            {
                Console.Write("Guess my magic number! ");
                guess = int.Parse(Console.ReadLine());

                if (guess > magNum)
                {
                    Console.WriteLine("Lower!");
                }
                else if (guess < magNum)
                {
                    Console.WriteLine("Higher!");
                }
                else
                {
                    Console.Write("You guessed it!");
                }
            }
    }
}
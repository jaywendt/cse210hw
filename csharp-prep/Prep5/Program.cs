using System;

class Program
{
    static void Main(string[] args)
    {
        welcome();

        string userName = inputName();
        int userNum = inputNum();

        int squareNum = Square(userNum);

        result(userName, squareNum);
    }

    static void welcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string inputName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int inputNum()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    
    static int Square(int number)
    {
        int squared = number * number;
        return squared;
    }

    static void result(string name, int squared)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}.");
    }
}
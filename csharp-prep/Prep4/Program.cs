using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int inputNum = -1;
        while (inputNum != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            string answer = Console.ReadLine();
            inputNum = int.Parse(answer);

            if (inputNum != 0)
            {
                numbers.Add(inputNum);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}.");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}.");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is {max}.");
    }
}
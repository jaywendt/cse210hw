using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction(1);
        Console.WriteLine(f1.GetFractionString());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetDecimalValue());
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.DisplayFraction());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.DisplayFraction());
        Console.WriteLine(fraction2.GetDecimalValue());
        
        Fraction fraction3 = new Fraction(3,4);
        Console.WriteLine (fraction3.DisplayFraction());
        Console.WriteLine(fraction3.GetDecimalValue());
        
        Fraction fraction4 = new Fraction(1,3);
        Console.WriteLine(fraction4.DisplayFraction());
        Console.WriteLine(fraction4.GetDecimalValue());
        
    }
}
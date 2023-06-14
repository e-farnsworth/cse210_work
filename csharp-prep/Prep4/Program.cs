using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int numberInput = 1;

        do
        {
            Console.Write("Enter Number: ");
            string userInput = Console.ReadLine();
            numberInput = int.Parse(userInput);
            if (numberInput != 0)
            {
                numbers.Add(numberInput);
            }
        } while (numberInput !=0);

        int total = 0;
        int largest = 0;

        foreach (int number in numbers)
        {
            total += number;

            if (number > largest)
            {
                largest = number;
            }
        }

        float average = ((float)total) / (numbers.Count);

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        
    }
}
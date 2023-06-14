using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letterGrade;
        string pre;

        if (grade >= 90)
        {
            letterGrade = "A";
            pre = "an";
        }
        else if (grade < 90 && grade >= 80)
        {
            letterGrade = "B";
            pre = "a";
        }
        else if (grade < 80 && grade >= 70)
        {
            letterGrade = "C";
            pre = "a";
        }
        else if (grade < 70 && grade >= 60)
        {
            letterGrade = "D";
            pre = "a";
        }
        else
        {
            letterGrade = "F";
            pre = "an";
        }

        Console.WriteLine($"You have {pre} {letterGrade}");

        if (grade >= 70)
        {
            Console.WriteLine("Congradulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("You did not pass. Try harder and good luck next time.");
        }
    }
}
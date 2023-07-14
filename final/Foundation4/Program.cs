using System;

class Program
{
    static void Main(string[] args)
    {
        RunningActivity test1 = new RunningActivity("2 Maytember 2012", 45, 5.2);
        test1.GetSummary();

        BikingActivity test2 = new BikingActivity("5 May 2022", 30, 5);
        test2.GetSummary();

        SwimmingActivity tests3 = new SwimmingActivity("6 March 1999", 75, 57);
        tests3.GetSummary();
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        int userInt = 0;
        do 
        {

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listening Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choic from the menu: ");
            string userInput = Console.ReadLine();
            userInt = int.Parse(userInput);

            if (userInt == 1)
            {
                BreathActivity _activityBreath = new BreathActivity("Activity", "Description");
                _activityBreath.RunBreathActivity();
            }
            else if (userInt == 2)
            {
                ReflectActivity _activityReflect = new ReflectActivity("Activity", "Description");
                _activityReflect.RunReflectActivity();
            }
            else if (userInt == 3)
            {
                ListActivity _activityList = new ListActivity("Activity", "Description");
                _activityList.RunListActivity();
            }
            else if (userInt == 4)
            {
                Console.WriteLine("Thank You for taking time to take care of yourself.");
            }
            else
            {
                Console.WriteLine("Sorry. That is not a valid input.");
            }

        } while (userInt != 4);
        // switch (userInt)
        // {
        //     case 1:
        //         BreathActivity _activityBreath = new BreathActivity("Activity", "Description");
        //         _activityBreath.RunBreathActivity();
        //     case 2:
        //         ReflectActivity _activityReflect = new ReflectActivity("Activity", "Description");
        //         _activityReflect.RunReflectActivity();
        //     case 3:
        //         break;
        //     case 4:
        //         break;
        // }

        // ctr + / comments out sections of highlighted text
    }
}
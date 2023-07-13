using System;

class Program
{
    static void Main(string[] args)
    {
        Adress adress1 = new Adress("3106 N Neverland Dr", "Denvoura", "CO");
        OutdoorEvent event1 = new OutdoorEvent("Pete's Birthday Party", "Come celebrate our friend's birthday!", "December 27, 2024", "4 pm", adress1, "Sunny");

        event1.StandardDetails();
        event1.FullDetails();
        event1.ShortDescription();

        Adress adress2 = new Adress("4527 Havenwood Rd. Grand Ballroom", "Rex Falls", "ID");
        ReceptionEvent event2 = new ReceptionEvent("Kevin and Karen's Wedding Reception", "Join us to celebrate this happy occation.", "July 6, 2025", "7 pm", adress2, "reservation@amgoing.com");

        event2.StandardDetails();
        event2.FullDetails();
        event2.ShortDescription();

        Adress adress3 = new Adress("6020 S 2nd E Suite 105", "Boisden", "UT");
        LectureEvent event3 = new LectureEvent("The art of Chaos", "Join Mr.Parker in learning how to balance your double life.", "Maytember 16, 2023","9 am" , adress3, "Mr. Peter Parker", 310);

        event3.StandardDetails();
        event3.FullDetails();
        event3.ShortDescription();

        
    }
}
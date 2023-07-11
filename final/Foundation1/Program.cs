using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        // Youtube Foundation Project 1
        Video vid1 = new Video("The Blade is Back", "Tiziano Bellu", 146);
        vid1.AddComment("RDJ5280","This is an incredible peice");
        vid1.AddComment("RandomCitizen52","Found this through an animatic. Stunning work!");
        vid1.AddComment("DND4life","Good work keep going!");
        vid1.AddComment("flamio1247","Rest in peace Technoblade. May your memories never die");

        Video vid2 = new Video("[HTTYD] Better than One","Chris Edward", 247);
        vid2.AddComment("a1yx","My childhood revolved around HTTYD.");
        vid2.AddComment("RDJ5280","This series will always hold a special place in my heart.");
        vid2.AddComment("Kate","The scenes they chose where amazing");

        Video vid3 = new Video("Newsboys - Magnetic","Newsboys", 193);
        vid3.AddComment("FlourPower","Music from the heart. Nice going.");
        vid3.AddComment("brooksfamily4712","Can't get this song out of my head! So great!");
        vid3.AddComment("a1yx","Seeing the live performance was awesome!");
        vid3.AddComment("RandomCitizen52","LOVE THIS SONG!! Going over the lyrics over and over!");
        vid3.AddComment("dave12","You guys did well in your last event");

        Video vid4 = new Video("Sea Shanty Collecition", "Cami-Cat", 1219);
        vid4.AddComment("Kate","This is an awesome song collection!!");
        vid4.AddComment("flamio1247","Just going to put this on repeat for the next several hours");
        vid4.AddComment("SinbadIsaGreatMovie","Makes me feel like a real pirate");
        vid4.AddComment("MonkeyDLuffy","This is why Pirates always have a musician");
        vid4.AddComment("RDJ5280","Two of my favorite songs in the same place! Yes please!");
        vid4.AddComment("dave12","Who doesn't like sea shanties?!");
        vid4.AddComment("DND4life","Had a whole campaign written out byt the time I finished listening the fourth time");

        _videos.Add(vid1);
        _videos.Add(vid2);
        _videos.Add(vid3);
        _videos.Add(vid4);

        foreach (Video _video in _videos)
        {
            Console.WriteLine(_video.GetVideoInformation());
            Console.WriteLine("Comments:");
            _video.DisplayComments();
            Console.WriteLine("");
        }
        
    }
}
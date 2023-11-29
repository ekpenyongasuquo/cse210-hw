using System;

class Program
{
    static void Main(string[] args)
    {
        Video[] _videos = new Video[4];

        _videos[0] = new Video("EasyTutorials", "HOW TO INSTALL AVAST ANTIVIRUS EASY", 150);
        _videos[0].AddComment("AdamPCMASTER", "wow it really works!");
        _videos[0].AddComment("SamGamer", "what a good tutorial man");
        _videos[0].AddComment("Candace212", "not working");

        _videos[1] = new Video("FORTNITECLIPS2010", "BEST CLIPS OF THE MONTH FORTNITE", 980);
        _videos[1].AddComment("Fortnite_n00b", "nice headshot at 2:40!");
        _videos[1].AddComment("alwaysGaming", "this guy doesn't know how to play!!!!");
        _videos[1].AddComment("notaPro", "bruh");
        
        _videos[2] = new Video("hacktic", "How to create a PS1 style horror game in Unity | Tutorial", 750);
        _videos[2].AddComment("NoLoot Studios", "Something about these retro-styled graphics that speaks to me");
        _videos[2].AddComment("Duke", "I do love the video, I wouldn't mind more indepth as well as beginner friendly tutorials similar to this one!");
        _videos[2].AddComment("doom_owo", "finally someone explained the thing i wanted to learn in the best and simple way, thank you so much.");

        _videos[3] = new Video("SΛBISHII", "Making an OPEN WORLD for my INDIE GAME - Resttore Devlog #1", 480);
        _videos[3].AddComment("Eren Kaya", "Great work. Can I know how much time it took to create this scene in total?");
        _videos[3].AddComment("Gili Gili chu", "Sir which pc you used unity or unreal engine 5?????????");
        _videos[3].AddComment("nDaveydawn", "i like this result");

        for(int i = 0; i < _videos.Length ; i++)
        {
            Console.WriteLine();
            _videos[i].DisplayVideoInfo();
            _videos[i].DisplayVideoComments();
        }
    }
}
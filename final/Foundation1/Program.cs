using System;

class Program
{
    static void Main(string[] args)
    {

        Video video1 = new Video();
        
        
        video1.title = "My Cars";
        video1.author = "John Smith";
        video1.length = "50 seconds";
        video1.comments.Add("JT: What size garage do you have?");
        video1.comments.Add("Nancy: I have a 82 camaro as well!");
        video1.comments.Add("Matt: Do you prefer manual or automatic shifting");

        video1.showVideo();

        Video video2 = new Video();
        

        video2.title = "Toy Planes";
        video2.author = "Matt Jones";
        video2.length = "20 minutes";
        video2.comments.Add("Mark: That's a lot of toy planes!");
        video2.comments.Add("Will: Which one is your favorite?");
        video2.comments.Add("Ashley: Can you make another video about each one?");

        video2.showVideo();

        Video video3 = new Video();
        

        video3.title = "RC cars";
        video3.author = "Joshua Peck";
        video3.length = "10 minutes";
        video3.comments.Add("Fred: I have the same car!");
        video3.comments.Add("George: Time for an upgrade,");
        video3.comments.Add("Matt: How many more do you own?");

        video3.showVideo();
    }
}
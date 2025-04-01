using System;

class Program
{
    static void Main()
    {
        Video video1 = new Video("Think Celestial", "President Russel M, Nelson", 1156);
        Video video2 = new Video("Drawing the Power of Jesus Christ into our lives", "President Russel M. Nelson", 891);
        Video video3 = new Video("His Grace is Sufficient", "Brad Wilcox", 1861);

        video1.AddComment(new Comment("cyndipodell1498", "i am not a member of the lds church but i love to listen to pres. nelson. he gives me peace. i pray for his recovery!"));
        video1.AddComment(new Comment("michaelvitta5577", "This really hits home, I am so blessed to have found the restored gospel 2 years ago."));
        video1.AddComment(new Comment("LyssiaKlupenger", "This is the first general conference I have ever watched and I feel like his message is so relevant to my life right now. Thank you so much 🙏"));
        
        video2.AddComment(new Comment("Carlos-up9fy", "I want to change my life hearing you preach might help me I don't want to be a sinner no more"));
        video2.AddComment(new Comment("Seek-God-First", "Our focus must be riveted on the Savior and when we do, our doubts and fears flee."));
        video2.AddComment(new Comment("monikaronai", "The gospel of Jesus Christ is full of His power which is available for every ernestly seeking man and woman... Thank you so much. That's what all of us must understand and remember."));

        video3.AddComment(new Comment("dinocollins720", "ONE OF THE GREATEST TALKS OF ALL TIME!!!"));
        video3.AddComment(new Comment("Alecthom2", "I'm not LDS, nor am I even religious. However, this video is exactly what I needed at this moment in my life. Thank you."));
        video3.AddComment(new Comment("Thatonedude1979", "Wow really good stuff here. I’m not Mormon I was sent this by a good friend who is. The way he articulates grace is awesome"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            video.Display();
        }

    }
}


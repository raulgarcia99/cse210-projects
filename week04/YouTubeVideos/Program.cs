using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Video n1 = new Video
        (
            "Top 5 places you should visit in France",
            "Mary Johnson",
            600,
            
           new List<Comment>
            {
                new Comment ("John Pratt", "I've been in 3 from those 5 places."),
                new Comment ("Luna Blight", "That's awesome!"),
                new Comment ("Pauline Chanelle", "I live in France, I agree with the video.")
            }
        );

        Video n2 = new Video
        (
            "How to make lemonade in 3 minutes",
            "Lucas Serrano",
            180,
            
           new List<Comment>
            {
                new Comment ("Sonia Marino", "Really useful, thank you!"),
                new Comment ("Lucas Serrano", "You're welcome."),
                new Comment ("Lucas Serrano", "I have more videos about quick recipes in my channel.")
            }
        );

        Video n3 = new Video
        (
            "My life is beautiful",
            "Charlotte Morrison",
            160,
            
           new List<Comment>
            {
                new Comment ("Mark Luthor", "My favorite song, I love it"),
                new Comment ("Leona Nickel", "I am your fan #1 Charlotte!"),
                new Comment ("Urias Izaval", "I hope one day she sings her song in Spanish")
            }
        );

        List<Video> videos = new List<Video>{n1, n2, n3};

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplayText());
        }
    }
}
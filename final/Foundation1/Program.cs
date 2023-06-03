using System;

class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine ("Hello Foundation1 World!");
        Console.WriteLine ("");
        Video video1 = new Video ("David Archuleta: GLORIOUS", "Meet the Mormons", 178);
        video1.AddComment ("@hannahlanejo", "Im not religious but this song is beatiful. My heart is full");
        video1.AddComment ("@DandeePradana", "As a muslim, I found this song touch the deepest of my heart... :)");
        video1.AddComment ("@richardbrown8714", "I absolutely love the message that we are all apart of the symphony and we each play a part...it's glorious! ");
        

        Video video2 = new Video ("Good to Be Alive", "Strive to Be", 210);
        video2.AddComment ("@antsinmynance9240", "I felt the spirit so strongly in this video, it's good to be alive");
        video2.AddComment ("@katyreynolds7507", "This makes me feel like my savior is by me");
        video2.AddComment ("@lanettelambert2994", "I can't listen to this enough!! this is now my theme song :D");

        Video video3 = new Video ("Stand All Amazed - BYU Vocal Point", "Strive to Be", 315);
        video3.AddComment ("@carlammonpretista9789", "Thank you for singing this inspiring hymn..it touches my heart and increases my love for the Savior.");
        video3.AddComment ("@firewolf5227", "I love this song it makes me remember what he did for us");
        video3.AddComment ("@amordavid9353", "Great voice, praise God.");


        
        List <Video> videos = new List <Video> ();
        videos.Add (video1);
        videos.Add (video2);
        videos.Add (video3);

        
        foreach (var video in videos)
        {
            Console.WriteLine ($"Title: {video._title}");
            Console.WriteLine ($"Author: {video._author}");
            Console.WriteLine ($"Length: {video._second} seconds");
            Console.WriteLine ($"Number of Comments: {video.NumOfComments()}");

            Console.WriteLine ("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine ($"Comment by {comment._name} : {comment._text}");
            }

            Console.WriteLine ();
        }
        Console.ReadLine ();
    }
}
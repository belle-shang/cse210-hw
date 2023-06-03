using System;

class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine ("Hello Foundation3 World!");
        Console.WriteLine ("");

        Address address1 = new Address ("557 Escondido Mall", "Stanford", "California", "USA");
        Address address2 = new Address ("256 Aikuo East Road", "Daan Dustrict", "Taipei", "Taiwan");
        Address address3 = new Address ("1 Mihama", "Mihama Ward", "Chiba", "Japan");

        LectureEvent lecture = new LectureEvent ("Lecture", "Silicon Valley Talks", "In this fascinating story of an innovator and a big idea, Tinnell crafts a poignant and critical history of today's Internet of Things.", "June 7, 2023", "12am-1pm", address1, "John Tinnell", "125");
        ReceptionEvent reception = new ReceptionEvent ("Reception", "Emily & Andy Wedding Reception", "A warm welcome for all who would love to join our celebration! Please shoot us your address for an invite!", "December 8, 2023", "3pm-5pm", address2, "RSVP@gmail.com");
        OutdoorEvent outdoor = new OutdoorEvent ("Outdoor", "Summer Sonic Festival", "With talented artists bringing unique arrangements together from across the world, attending the Summer Sonic annual music festival should be on every music lover's list.", "August 19-20, 2023", "10am", address3, "Beautiful weather with good amount of exercise to attend the music festival. Pay attention to the sun and be aware of dehydration.");
   
        Console.WriteLine ("Lecture Event ");
        Console.WriteLine ("");
        Console.WriteLine (lecture.StandardDetails ());
        Console.WriteLine ("");
        Console.WriteLine (lecture.FullDetails ());
        Console.WriteLine ("");
        Console.WriteLine (lecture.ShortDescription ());
        Console.WriteLine ("");

        Console.WriteLine ("Reception Event ");
        Console.WriteLine ("");
        Console.WriteLine (reception.StandardDetails ());
        Console.WriteLine ("");
        Console.WriteLine (reception.FullDetails ());
        Console.WriteLine ("");
        Console.WriteLine (reception.ShortDescription ());
        Console.WriteLine ("");

        Console.WriteLine ("Outdoor Event ");
        Console.WriteLine ("");
        Console.WriteLine (outdoor.StandardDetails ());
        Console.WriteLine ("");
        Console.WriteLine (outdoor.FullDetails ());
        Console.WriteLine ("");
        Console.WriteLine (outdoor.ShortDescription ());
    }
}
using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "Grand Prairie", "TX", "USA");
        Address address2 = new Address("616 Soto Grande St", "Irving", "TX", "USA");
        Address address3 = new Address("322 jose Smith st", "Provo", "UT", "USA");

        Lecture lecture = new Lecture("Tech Innovations", "AI solutions", "05/30/2025", "10:00 AM", address1, "Dr. Garcia", 100);
        Reception reception = new Reception("Mexican Party", "Mi casa es tu casa", "06/10/2025", "6:00 PM", address2, "JGO@event.com");
        Outdoor outdoor = new Outdoor("EFY", "Music and fun under the sun", "07/20/2025", "2:00 PM", address3, "Sunny, 75°F");

        Event[] events = { lecture, reception, outdoor };

        foreach (Event ev in events)
        {
            Console.WriteLine("\n--- Standard Details ---");
            Console.WriteLine(ev.GetStandardDetails());

            Console.WriteLine("\n--- Full Details ---");
            Console.WriteLine(ev.GetFullDetails());

            Console.WriteLine("\n--- Short Description ---");
            Console.WriteLine(ev.GetShortDescription());

            Console.WriteLine("\n===============================\n");
        }
    }
}

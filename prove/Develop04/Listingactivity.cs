using System;
using System.Collections.Generic;
using System.Threading;
class ListingActivity : Activity
{
    private static readonly string[] Prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life.") { }

    public override void Perform()
    {
        Start();
        Console.WriteLine(Prompts[new Random().Next(Prompts.Length)]);
        Thread.Sleep(3000);
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("List an item: ");
            items.Add(Console.ReadLine());
        }
        Console.WriteLine($"You listed {items.Count} items.");
        End();
    }
}

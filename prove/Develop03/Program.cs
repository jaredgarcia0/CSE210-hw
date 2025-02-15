using System;

class Program
{
    static void Main()
    {
        string reference = "Proverbs 3:5-6";
        string text = "Trust in the LORD with all thine heart; and lean not unto thine own understanding.\nIn all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit:");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "quit") break;
            if (scripture.IsFullyHidden()) break;

            scripture.HideRandomWords(3); // Hides 3 words at a time
        }

        scripture.Display();
        Console.WriteLine("\nAll words are hidden. Memorization complete!");
    }
}
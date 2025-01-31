using System;

class Menu
{
    private Journal journal = new Journal();

    public void DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("\nJournal Program");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    string prompt = PromptManager.GetRandomPrompt();
                    Console.WriteLine("\nPrompt: " + prompt);
                    Console.Write("Your response: ");
                    journal.AddEntry(prompt, Console.ReadLine());
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.Write("Enter filename: ");
                    journal.SaveToFile(Console.ReadLine());
                    break;
                case "4":
                    Console.Write("Enter filename: ");
                    journal.LoadFromFile(Console.ReadLine());
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();

        // Create goals
        manager.CreateGoal("Simple", "Run a marathon", 1000);
        manager.CreateGoal("Eternal", "Read scriptures", 100);
        manager.CreateGoal("Checklist", "Attend the temple", 50, 10, 500);

        // Record events
        manager.RecordEvent("Run a marathon");
        manager.RecordEvent("Read scriptures");
        manager.RecordEvent("Attend the temple");

        // Display goals and score
        manager.DisplayGoals();
        Console.WriteLine($"Total score: {manager.TotalScore} points");
    }
}
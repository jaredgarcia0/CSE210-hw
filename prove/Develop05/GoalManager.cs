using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();  // List to store all goals
    private int _totalPoints = 0;  // Total points player has earned

    // Main method to start the program
    public void Start()
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.Clear();
            Console.WriteLine("Goal Tracker");
            Console.WriteLine("-------------");
            Console.WriteLine($"Total Points: {_totalPoints}");
            Console.WriteLine("1. List Goals");
            Console.WriteLine("2. Create Goal");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ListGoalNames();
                    break;
                case "2":
                    CreateGoal();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    SaveGoals();
                    break;
                case "5":
                    LoadGoals();
                    break;
                case "6":
                    keepRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }

    // List all goal names
    public void ListGoalNames()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
            return;
        }

        Console.WriteLine("Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    // Create a new goal
    public void CreateGoal()
    {
        Console.WriteLine("Choose the type of goal to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.Write("Enter choice (1 or 2): ");
        string typeChoice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        if (typeChoice == "1")
        {
            newGoal = new SimpleGoal(name, description, points);
        }
        else if (typeChoice == "2")
        {
            newGoal = new EternalGoal(name, description, points);
        }

        if (newGoal != null)
        {
            _goals.Add(newGoal);
            Console.WriteLine("Goal created successfully!");
        }
        else
        {
            Console.WriteLine("Invalid goal type selected.");
        }

        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    // Record an event for a goal (mark as complete)
    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available to record events.");
            Console.ReadLine();
            return;
        }

        ListGoalNames();  // List all goal names so user can choose
        Console.Write("Select a goal by number: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal selectedGoal = _goals[goalIndex];
            int pointsEarned = selectedGoal.RecordEvent();
            _totalPoints += pointsEarned;
            Console.WriteLine($"Total points: {_totalPoints}");
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }

        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    // Save goals to a file
    public void SaveGoals()
    {
        Console.Write("Enter the file name to save goals: ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.SaveString());
            }
        }

        Console.WriteLine("Goals saved successfully!");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    // Load goals from a file
    public void LoadGoals()
    {
        Console.Write("Enter the file name to load goals: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            _goals.Clear();
            string[] lines = File.ReadAllLines(fileName);

            foreach (var line in lines)
            {
                string[] parts = line.Split(',');

                if (parts[0] == "SimpleGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    bool isComplete = bool.Parse(parts[4]);

                    SimpleGoal goal = new SimpleGoal(name, description, points);
                    if (isComplete)
                    {
                        goal.RecordEvent();  // Mark as complete
                    }

                    _goals.Add(goal);
                }
                else if (parts[0] == "EternalGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    EternalGoal goal = new EternalGoal(name, description, points);
                    _goals.Add(goal);
                }
            }

            Console.WriteLine("Goals loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }

        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}

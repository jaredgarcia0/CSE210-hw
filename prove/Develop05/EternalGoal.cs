using System;

public class EternalGoal : Goal
{
    // Constructor
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) // Call base constructor
    {
        // No extra attributes needed
    }

    // Record event: always awards points, never completes
    public override int RecordEvent()
    {
        Console.WriteLine($"You completed '{_name}' and earned {_points} points!");
        return _points;
    }

    // Eternal goals never complete
    public override bool IsComplete()
    {
        return false;
    }

    // Return details string
    public override string GetDetailsString()
    {
        return $"[Eternal Goal] {_name} ({_description})";
    }

    // Save string to file
    public override string SaveString()
    {
        // Format: EternalGoal,Name,Description,Points
        return $"EternalGoal,{_name},{_description},{_points}";
    }
}

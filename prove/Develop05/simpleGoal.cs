using System;

public class SimpleGoal : Goal
{
    // Attribute to track if the goal is complete
    private bool _isComplete;

    // Constructor
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false; // Starts as incomplete
    }

    // Record event: Marks complete, gives points if not already complete
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"You completed '{_name}' and earned {_points} points!");
            return _points;
        }
        else
        {
            Console.WriteLine($"Goal '{_name}' is already completed! No points awarded.");
            return 0;
        }
    }

    // Returns whether the goal is complete
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Display details (with [X] if complete, [ ] if not)
    public override string GetDetailsString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description})";
    }

    // Save to file
    public override string SaveString()
    {
        // Format: SimpleGoal,Name,Description,Points,IsComplete
        return $"SimpleGoal,{_name},{_description},{_points},{_isComplete}";
    }
}

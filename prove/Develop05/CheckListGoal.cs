using System;

public class CheckListGoal : Goal
{
    // Extra attributes specific to CheckListGoal
    private int _targetCount;      // How many times to complete
    private int _currentCount;     // Current completion count
    private int _bonusPoints;      // Bonus points when finished

    // Constructor
    public CheckListGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    // Record an event: increase current count, check for completion
    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            Console.WriteLine($"Progress: {_currentCount}/{_targetCount}");

            int totalPoints = _points;
            if (_currentCount == _targetCount)
            {
                Console.WriteLine($"Congratulations! You completed '{_name}' and earned a bonus of {_bonusPoints} points!");
                totalPoints += _bonusPoints;
            }
            else
            {
                Console.WriteLine($"You earned {_points} points!");
            }

            return totalPoints;
        }
        else
        {
            Console.WriteLine($"Goal '{_name}' is already fully completed!");
            return 0;
        }
    }

    // Check if the goal is complete
    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    // Display goal details
    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description}) -- Completed {_currentCount}/{_targetCount} times";
    }

    // Save goal info to a file
    public override string SaveString()
    {
        // Format: CheckListGoal,Name,Description,Points,TargetCount,CurrentCount,BonusPoints
        return $"CheckListGoal,{_name},{_description},{_points},{_targetCount},{_currentCount},{_bonusPoints}";
    }

    // Add GetName() so GoalManager can list the name
    public override string GetName()
    {
        return _name;
    }
}

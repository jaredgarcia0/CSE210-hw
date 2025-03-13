using System;
using System.Collections.Generic;
public class GoalManager
{
    public List<Goal> Goals;
    public int TotalScore;

    public GoalManager()
    {
        Goals = new List<Goal>();
        TotalScore = 0;
    }

    public void CreateGoal(string goalType, string name, int pointValue, int totalRepetitions = 0, int bonusPoints = 0)
    {
        Goal goal = goalType switch
        {
            "Simple" => new SimpleGoal(name, pointValue),
            "Eternal" => new EternalGoal(name, pointValue),
            "Checklist" => new ChecklistGoal(name, pointValue, totalRepetitions, bonusPoints),
            _ => throw new ArgumentException("Invalid goal type")
        };
        Goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        foreach (var goal in Goals)
        {
            if (goal.Name == goalName)
            {
                goal.RecordEvent();
                TotalScore += goal.TotalPoints;
                return;
            }
        }
        Console.WriteLine($"Goal {goalName} not found.");
    }

    public void DisplayGoals()
    {
        foreach (var goal in Goals)
        {
            Console.WriteLine(goal.DisplayStatus());
        }
    }

    public void SaveGoals()
    {
        // Implement saving goals (e.g., to a file)
    }

    public void LoadGoals()
    {
        // Implement loading goals from a file
    }
}
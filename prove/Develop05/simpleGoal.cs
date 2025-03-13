using System;
using System.Collections.Generic;
public class SimpleGoal : Goal
{
    private bool completed;

    public SimpleGoal(string name, int pointValue) : base(name, pointValue)
    {
        completed = false;
    }

    public override void RecordEvent()
    {
        if (!completed)
        {
            TotalPoints += PointValue;
            completed = true;
        }
    }

    public override string DisplayStatus()
    {
        return $"{Name}: {(completed ? "Completed" : "Not Completed")} - {TotalPoints} points";
    }
}
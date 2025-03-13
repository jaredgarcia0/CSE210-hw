using System;
using System.Collections.Generic;
public class EternalGoal : Goal
{
    public EternalGoal(string name, int pointValue) : base(name, pointValue) { }

    public override void RecordEvent()
    {
        TotalPoints += PointValue;
    }

    public override string DisplayStatus()
    {
        return $"{Name}: Ongoing - {TotalPoints} points";
    }
}
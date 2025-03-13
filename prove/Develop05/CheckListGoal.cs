using System;
using System.Collections.Generic;public class ChecklistGoal : Goal
{
    public int TotalRepetitions;
    public int CurrentCount;
    public int BonusPoints;

    public ChecklistGoal(string name, int pointValue, int totalRepetitions, int bonusPoints)
        : base(name, pointValue)
    {
        TotalRepetitions = totalRepetitions;
        CurrentCount = 0;
        BonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        if (CurrentCount < TotalRepetitions)
        {
            TotalPoints += PointValue;
            CurrentCount++;

            if (CurrentCount == TotalRepetitions)
            {
                TotalPoints += BonusPoints;
            }
        }
    }

    public override string DisplayStatus()
    {
        return $"{Name}: Completed {CurrentCount}/{TotalRepetitions} times - {TotalPoints} points";
    }
}

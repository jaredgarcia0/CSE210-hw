using System;
using System.Collections.Generic;

// Base Class for Goals
public abstract class Goal
{
    public string Name;
    public int PointValue;
    public int TotalPoints;

    public Goal(string name, int pointValue)
    {
        Name = name;
        PointValue = pointValue;
        TotalPoints = 0;
    }

    // Abstract methods
    public abstract void RecordEvent();
    public abstract string DisplayStatus();
}

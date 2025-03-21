using System;

public abstract class Goal
{
    // Attributes
    protected string _name;
    protected string _description;
    protected int _points;

    // Constructor
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // Abstract Methods
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string SaveString();

    // Add this virtual method 👇
    public virtual string GetName()
    {
        return _name;
    }
}

using System;
using System.Collections.Generic;
using System.Threading;

abstract class Activity
{
    public string Name;
    public string Description;
    private int duration;

    protected Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void SetDuration(int duration)
    {
        this.duration = duration;
    }

    public int GetDuration()
    {
        return duration;
    }

    public void Start()
    {
        Console.WriteLine($"Starting {Name} Activity");
        Console.WriteLine(Description);
        Console.Write("How many seconds would you like to do this activity? ");
        SetDuration(int.Parse(Console.ReadLine()));
        Console.WriteLine("Prepare to begin...");
        Spinner(3);
    }

    public void End()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {Name} activity for {GetDuration()} seconds.");
        Spinner(3);
    }

    protected void Spinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void Perform();
}
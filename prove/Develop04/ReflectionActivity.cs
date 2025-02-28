using System;
using System.Collections.Generic;
using System.Threading;
class ReflectionActivity : Activity
{
    private static readonly string[] Prompts =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly string[] Questions =
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?"
    };

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times when you have shown strength and resilience.") { }

    public override void Perform()
    {
        Start();
        Console.WriteLine(Prompts[new Random().Next(Prompts.Length)]);
        int timeLeft = GetDuration();
        Random rnd = new Random();
        while (timeLeft > 0)
        {
            Console.WriteLine(Questions[rnd.Next(Questions.Length)]);
            Spinner(5);
            timeLeft -= 5;
        }
        End();
    }
}

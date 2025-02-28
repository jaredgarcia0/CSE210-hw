using System;
using System.Collections.Generic;
using System.Threading;
class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly.") { }

    public override void Perform()
    {
        Start();
        for (int i = 0; i < GetDuration() / 4; i++)
        {
            Console.WriteLine("Breathe in...");
            Spinner(2);
            Console.WriteLine("Breathe out...");
            Spinner(2);
        }
        End();
    }
}

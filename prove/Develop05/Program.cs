using System;

namespace GoalTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a GoalManager instance
            GoalManager goalManager = new GoalManager();

            // Start the GoalManager, which will handle the user interface
            goalManager.Start();
        }
    }
}

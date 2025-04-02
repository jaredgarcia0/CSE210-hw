using System;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("03 Apr 2025", 60, 10.0),
            new Biking("04 Apr 2025", 45, 12.0),
            new Swimming("05 Apr 2025", 20, 40)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

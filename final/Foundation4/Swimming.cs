using System;

public class Swimming : Activity
{
    private int _laps;
    private const double LapLengthMiles = 50.0 / 1000 * 0.62; // Convert meters to miles

    public Swimming(string date, double minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance() => _laps * LapLengthMiles;

    public override double GetSpeed() => (GetDistance() / GetMinutes()) * 60;

    public override double GetPace() => GetMinutes() / GetDistance();
}

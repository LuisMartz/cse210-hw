
public class Activity
{
    private string name;
    private double distance;
    private DateTime startTime;

    public Activity(string name, double distance, DateTime startTime)
    {
        this.name = name;
        this.distance = distance;
        this.startTime = startTime;
    }

    public virtual double GetDistance()
    {
        return distance;
    }

    public virtual double GetSpeed()
    {
        TimeSpan duration = DateTime.Now - GetStartTime();
        double minutes = duration.TotalMinutes;
        return (distance / minutes) * 60;
    }

    public virtual TimeSpan GetPace()
    {
        double speed = GetSpeed();
        if (speed == 0)
        {
            return TimeSpan.MaxValue;
        }
        else
        {
            double pace = 60 / speed;
            return TimeSpan.FromMinutes(pace);
        }
    }

    public virtual string GetSummary()
    {
        return String.Format("{0}: Distance={1:F2} miles, Speed={2:F2} mph, Pace={3:mm\\:ss} per mile",
            name, GetDistance(), GetSpeed(), GetPace());
    }

    public DateTime GetStartTime()
    {
        return startTime;
    }
}

public class RunningActivity : Activity
{
    private double elevationGain;

    public RunningActivity(string name, double distance, DateTime startTime, double elevationGain)
        : base(name ?? "Running", distance, startTime)
    {
        this.elevationGain = elevationGain;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + String.Format(", Elevation Gain={0:F2} feet", elevationGain);
    }
}

public class CyclingActivity : Activity
{
    private double maxSpeed;

    public CyclingActivity(string name, double distance, DateTime startTime, double maxSpeed)
        : base(name ?? "Cycling", distance, startTime)
    {
        this.maxSpeed = maxSpeed;
    }

    public override double GetSpeed()
    {
        return maxSpeed;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + String.Format(", Max Speed={0:F2} mph", maxSpeed);
    }
}

public class HikingActivity : Activity
{
    private int numRestStops;

    public HikingActivity(string name, double distance, DateTime startTime, int numRestStops)
        : base(name ?? "Hiking", distance, startTime)
    {
        this.numRestStops = numRestStops;
    }

    public override TimeSpan GetPace()
    {
        double distanceWithoutRestStops = GetDistance() - (numRestStops * 0.1);
        double pace = distanceWithoutRestStops / 60;
        return TimeSpan.FromMinutes(pace);
    }

    public override string GetSummary()
    {
        return base.GetSummary() + String.Format(", Num Rest Stops={0}", numRestStops);
    }
}

public class SwimmingActivity : Activity
{
    private int numLaps;

    public SwimmingActivity(string name, int numLaps, DateTime startTime)
        : base(name ?? "Swimming", numLaps * 50 / 1000 * 0.62, startTime)
    {
        this.numLaps = numLaps;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + String.Format(", Num Laps={0}", numLaps);
    }

    public override double GetSpeed()
    {
        TimeSpan duration = DateTime.Now - GetStartTime();
        double minutes = duration.TotalMinutes;
        return (GetDistance() / minutes) * 60;
    }
}

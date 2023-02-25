public abstract class Activity
{
    public string description;
    public int duration;

    public Activity(string description, int duration)
    {
        this.description = description;
        this.duration = duration;
    }

    public abstract void Run();
}
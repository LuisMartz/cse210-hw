public class BreathingActivity : Activity
{
    public BreathingActivity(string description, int duration) : base(description, duration)
    {
    }

     public override void Run()
    {
        Console.WriteLine($"Breathing Activity: {description}");

        Console.Write("Enter the duration of the activity (in seconds; at least more than 10): ");
        int duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Duration: {duration} seconds");

        int breathCount = duration / 10;
        for (int b = 0; b < breathCount; b++)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(5000); 
            Console.WriteLine("Breathe out...");
            Thread.Sleep(5000);
        }
        Console.WriteLine("You finished the Breathing Activity.");
    }
}
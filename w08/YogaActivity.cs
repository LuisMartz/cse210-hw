public class YogaActivity : Activity
{
    public YogaActivity(string description, int duration) : base(description, duration)
    {
    }

    public override void Run()
    {
        Console.WriteLine($"Yoga Activity: {description}");
        Console.WriteLine(" ");
        Console.Write("Enter the number of yoga poses to do: ");
        int numPoses = int.Parse(Console.ReadLine());
        var poses = new List<string>()
        {
            "Tree Pose",
            "Triangle Pose",
            "Child's Pose",
            "Plank Pose",
            "Cobra Pose",
            "Corpse Pose"
        };
        for (int p = 0; p < numPoses; p++)
        {
            Console.Write($"Enter the duration (in seconds) for pose {p+1}: ");
            int poseDuration = int.Parse(Console.ReadLine());

            Console.WriteLine(poses[p % poses.Count]);
            Thread.Sleep(poseDuration * 1000);
        }
        Console.WriteLine("You finished the Yoga Activity");
    }
}
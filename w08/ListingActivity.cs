public class ListingActivity : Activity
{
    public ListingActivity(string description, int duration) : base(description, duration)
    {
    }

public override void Run()
{
    Console.WriteLine($"Listing Activity: {description}");
    Console.WriteLine("You have to list things for a certain duration of time.");
    Console.WriteLine("How long do you want to list things (in seconds; at least more than 10)?");
    int duration = int.Parse(Console.ReadLine());
    List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    int randomIndex = new Random().Next(prompts.Count);
    string prompt = prompts[randomIndex];

    List<string> items = new List<string>();
    Console.WriteLine($"{prompt}");

    while (duration > 0)
    {
        Console.WriteLine("Write about this:");
        string input = Console.ReadLine();
        items.Add(input);
        duration -= 1;
    }

    Console.WriteLine("\nThis is what you write:");
    foreach (string item in items)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("You finished the Listing Activity.");
}
}
public class ReflectionActivity : Activity
{
    public ReflectionActivity(string description, int duration) : base(description, duration)
    {
    }

    public override void Run()
    {
        Console.WriteLine($"Reflection Activity: {description}");
        var list1 = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need."
        };
        var list2 = new List<string>
        {
            "Why was this experience meaningful to you?",
            "How did you feel when it was complete?",
            "How can you keep this experience in mind in the future?"
        };
        var random = new Random();
        var remainingTime = duration;

        while (remainingTime > 0)
        {
            var question = list1[random.Next(list1.Count)];
            Console.WriteLine($"Question: {question}");

            for (int r = 0; r < 10; r++)
            {
                Console.Write("-");
                Thread.Sleep(1000);
                Console.Write("\\");
                Thread.Sleep(1000);
                Console.Write("-");
                Thread.Sleep(1000);
                Console.Write("/");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
            var reflection = list2[random.Next(list2.Count)];
            Console.WriteLine($"Reflection: {reflection}");
            Console.Write("Your response: ");
            var response = Console.ReadLine();
            Console.WriteLine();
            remainingTime -= 20;
        }
    }
}
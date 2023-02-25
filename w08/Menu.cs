
class Program
{
    static void Main(string[] args)
    {
        int option;

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Yoga Activity");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("You chose the Breathing Activity.");
                    BreathingActivity breathingActivity = new BreathingActivity("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 60);
                    breathingActivity.Run();
                    break;
                case 2:
                    Console.WriteLine("You chose the Reflection Activity.");
                    ReflectionActivity reflectionActivity = new ReflectionActivity("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 60);
                    reflectionActivity.Run();
                    break;
                case 3:
                    Console.WriteLine("You chose the Listing Activity.");
                    ListingActivity listingActivity = new ListingActivity("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 60);
                    listingActivity.Run();
                    break;
                case 4:
                    Console.WriteLine("You chose the Yoga Activity.");
                    YogaActivity yogaActivity = new YogaActivity("This activity will challenge you to meditate and relax yourself.", 60);
                    yogaActivity.Run();
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Please try again.");
                    break;
            }

            Console.WriteLine();
        } while (option != 5);
    }
}
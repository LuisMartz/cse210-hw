namespace GoalTracker
{
    static class Menu
    {
        public static void DisplayOptions()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Create a goal");
            Console.WriteLine("2. Load goals");
            Console.WriteLine("3. Mark a goal as completed");
            Console.WriteLine("4. Show total points from completed goals");
            Console.WriteLine("5. Quit");
        }

        public static void DisplayGoalTypes()
        {
            Console.WriteLine("What type of goal would you like to create?");
            Console.WriteLine("1. Basic goal");
            Console.WriteLine("2. Eternal goal");
            Console.WriteLine("3. Checklist goal");
        }

        public static void DisplayGoals(Goal[] goals)
        {
            if (goals == null || goals.Length == 0)
            {
                Console.WriteLine("No goals to load.");
                return;
            }

            Console.WriteLine("Here are your goals:");
            for (int i = 0; i < goals.Length; i++)
            {
                if (goals[i] != null)
                {
                    Console.WriteLine($"{i}. {goals[i].ToString()}");
                }
            }
        }

        public static int GetGoalIndex()
        {
            Console.WriteLine("Which goal would you like to mark as completed? (Enter the index number)");
            return int.Parse(Console.ReadLine());
        }

        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static string GetBasicGoalName()
        {
            Console.WriteLine("Enter a name for your goal:");
            return Console.ReadLine();
        }

        public static string GetEternalGoalName()
        {
            Console.WriteLine("Enter a name for your eternal goal:");
            return Console.ReadLine();
        }

        public static string GetEternalGoalDescription()
        {
            Console.WriteLine("Enter a description for your eternal goal:");
            return Console.ReadLine();
        }

        public static string GetChecklistGoalName()
        {
            Console.WriteLine("Enter a name for your checklist goal:");
            return Console.ReadLine();
        }

        public static string[] GetChecklistGoalItems()
        {
            Console.WriteLine("Enter the items for your checklist goal (separated by commas):");
            string checklistItemsString = Console.ReadLine();
            return checklistItemsString.Split(',');
        }

        public static void DisplayTotalPoints(int totalPoints)
        {
            Console.WriteLine($"Total points from completed goals: {totalPoints}");
        }
    }
}


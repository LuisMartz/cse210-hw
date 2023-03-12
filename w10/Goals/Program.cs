namespace GoalTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Goal[] goals = new Goal[10];
            int goalIndex = 0;

            while (true)
            {
                Menu.DisplayOptions();

                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Menu.DisplayGoalTypes();
                    int goalType = int.Parse(Console.ReadLine());

                    string name;
                    Goal? goal = null;

                    switch (goalType)
                    {
                        case 1:
                            name = Menu.GetBasicGoalName();
                            goal = new BasicGoal(name);
                            break;
                        case 2:
                            name = Menu.GetEternalGoalName();
                            string description = Menu.GetEternalGoalDescription();
                            goal = new EternalGoal(name, description);
                            break;
                        case 3:
                            name = Menu.GetChecklistGoalName();
                            string[] items = Menu.GetChecklistGoalItems();
                            goal = new ChecklistGoal(name, items);
                            break;
                            
                    }

                    if (goal != null)
                    {
                        goals[goalIndex] = goal;
                        goalIndex++;
                        Menu.DisplayMessage("Goal created!");
                    }
                }
                else if (option == 2)
                {
                    Menu.DisplayGoals(goals);
                }
                else if (option == 3)
                {
                    Menu.DisplayGoals(goals);
                    int index = Menu.GetGoalIndex();

                    if (index >= 0 && index < goals.Length && goals[index] != null)
                    {
                        goals[index].MarkCompleted();
                        Menu.DisplayMessage($"Goal {index} marked as completed!");
                    }
                    else
                    {
                        Menu.DisplayMessage("Invalid goal index.");
                    }
                }
                else if (option == 4)
                {
                     int totalPoints = 0;
    foreach (Goal goal in goals)
    {
        if (goal != null && goal.IsCompleted)
        {
            totalPoints += goal.Points;
        }
    }
    Menu.DisplayTotalPoints(totalPoints);
                }
                else if (option == 5)
                {
                    break;
                }
                
            }
        }
    }
}
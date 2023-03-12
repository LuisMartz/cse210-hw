namespace GoalTracker
{
    abstract class Goal
    {
        public string Name { get; protected set; }
        public bool IsCompleted { get; protected set; }
        public int Points { get; protected set; }
        

        public Goal(string name)
        {
            Name = name;
            IsCompleted = false;
            Points = 0;
        }

        public virtual void MarkCompleted()
        {
            IsCompleted = true;
        }

        public abstract override string ToString();

        public abstract int GetTotalPoints();
    }

    class BasicGoal : Goal
    {
        public BasicGoal(string name) : base(name)
        {
            Points = 10;
        }

        public override void MarkCompleted()
        {
            base.MarkCompleted();
            if (IsCompleted)
            {
                Points = 10;
            }
        }

        public override string ToString()
        {
            return $"Basic goal: {Name} ({(IsCompleted ? "completed" : "in progress")}) - Points: {Points}";
        }

        public override int GetTotalPoints()
        {
            return Points;
        }
    }

    class EternalGoal : Goal
    {
        public string Description { get; protected set; }

        public EternalGoal(string name, string description) : base(name)
        {
            Description = description;
            Points = 50;
        }

        public override void MarkCompleted()
        {
            base.MarkCompleted();
            if (IsCompleted)
            {
                Points = 50;
            }
        }

        public override string ToString()
        {
            return $"Eternal goal: {Name} ({(IsCompleted ? "completed" : "in progress")}) - Points: {Points}";
        }

        public override int GetTotalPoints()
        {
            return Points;
        }
    }

    class ChecklistGoal : Goal
    {
        public string[] Items { get; protected set; }

        public ChecklistGoal(string name, string[] items) : base(name)
        {
            Items = items;
            Points = items.Length * 5;
        }

        public override void MarkCompleted()
        {
            base.MarkCompleted();
            if (IsCompleted)
            {
                Points = Items.Length * 5;
            }
        }

        public override string ToString()
        {
            string status = IsCompleted ? "completed" : "in progress";
            string itemsString = string.Join(", ", Items);
            return $"Checklist goal: {Name} ({status}) - Items: {itemsString} - Points: {Points}";
        }

        public override int GetTotalPoints()
        {
            return Points;
        }
    }
}

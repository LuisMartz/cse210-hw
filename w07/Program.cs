class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Saul", "History");
        Console.WriteLine(assignment.Summary);

        MathAssigment mathAssigment = new MathAssigment("Lucas", "Fractions", "Chapter 6", "1-15 to 15-25");
        Console.WriteLine(mathAssigment.Summary);
        Console.WriteLine(mathAssigment.Homework);

        WritingAssignment writingAssignment = new WritingAssignment("Marta", "English", "Essay on Charles Dickens");
        Console.WriteLine(writingAssignment.Summary);
        Console.WriteLine(writingAssignment.GetWriting());

        Console.ReadLine();
    }
}
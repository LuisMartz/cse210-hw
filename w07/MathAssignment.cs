public class MathAssigment : Assignment
{
    private string bookSection;
    private string problems;

    public MathAssigment(string student, string topic, string bookSection, string problems)
        : base(student, topic)
    {
        this.bookSection = bookSection;
        this.problems = problems;
    }

    public string Homework
    {
        get { return "Section " + bookSection + ", Problems " + problems; }
    }
}
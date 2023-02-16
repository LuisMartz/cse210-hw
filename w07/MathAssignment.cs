public class MathAssigment : Assignment
{
    private string bookSection;
    private string problems;

    public MathAssigment(string student, string topic, string bookSection, string problems)
        : base(student, topic)
    {
        bookSection = _bookSection;
        problems = _problems;
    }

    public string Homework
    {
        get { return "Section " + _bookSection + ", Problems " + _problems; }
    }
}

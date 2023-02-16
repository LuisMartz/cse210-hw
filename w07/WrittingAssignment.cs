public class WritingAssignment : Assignment
{
    private string writing;
    
    public WritingAssignment(string student, string topic, string writing)
        : base(student, topic)
    {
        this.writing = writing;
    }

    public string GetWriting()
    {
        string student = GetStudent();
        return writing + " by " + student;
    }
}
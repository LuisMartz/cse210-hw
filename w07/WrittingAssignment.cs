public class WritingAssignment : Assignment
{
    private string writing;
    
    public WritingAssignment(string student, string topic, string writing)
        : base(student, topic)
    {
        writing = _writing;
    }

    public string GetWriting()
    {
       get { return _writing + " by " + student;
    }
}

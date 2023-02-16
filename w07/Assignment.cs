public class Assignment
{
    private string student;
    private string topic;
    
    public Assignment(string student, string topic)
    {
        student = _student;
        topic = _topic;
    }
    
    public string GetStudent()
    {
        return student;
    }
    
    public string GetTopic()
    {
        return topic;
    }
    
    public string Summary
    {
        get { return _student + ", complete the assignment on " + _topic; }
    }
}

public class Assignment
{
    private string student;
    private string topic;
    
    public Assignment(string student, string topic)
    {
        this.student = student;
        this.topic = topic;
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
        get { return student + ", complete the assignment on " + topic; }
    }
}
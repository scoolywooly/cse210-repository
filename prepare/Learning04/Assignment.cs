using System;
public class Assignment {
    protected string _studentName;
    protected string _topic;

    public Assignment()
    {
        _studentName = "Benjamin Brinkerhoff";  // Default will be my name
        _topic = "Advanced Algrebra";
    }

    public Assignment(string name, string topic) 
    {
        _studentName = name; // Allows the Program.cs to call other names into the assignment class
        _topic = topic;
    }

    public string GetSummary() {
        return $"{_studentName} -- {_topic}";
    }
}
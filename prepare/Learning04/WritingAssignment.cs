public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment() {
        _title = "Benefits of Traditional art in a Modern market";
        base._topic = "English Class";
    }

    public string GetWritingInformation() {
        string info = $"{base.GetSummary()}\n{_title} by {base._studentName}";
        return info;
    }
}
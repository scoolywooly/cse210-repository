public class Lecture : Event 
{

    private string _lectureSpeaker;
    private int _lectureCapacity;
    private string _lecture = "Lecture";

    public Lecture(string name, string date, string description, string time, string address, string speaker, int capacity) :base( name, date,  description,  time, address)
    {
        _lectureSpeaker = speaker;
        _lectureCapacity = capacity;
    }

    public string fullDetails() {
        string standard = getStandard();
        return $"Event Type: {_lecture}\n{standard}\nSpeaker: {_lectureSpeaker}\nMax Capacity: {_lectureCapacity}";
    }
    
}
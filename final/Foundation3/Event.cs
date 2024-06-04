public class Event {
    private string _eventTitle;
    private string _eventDate;
    private string _eventDescription;
    private string _eventTime;
    
    private Address _eventAddress = new Address();


    public Event(string name, string date, string description, string time, string address) {
        _eventTitle = name;
        _eventDate = date;
        _eventDescription = description;
        _eventTime = time;
        _eventAddress.setAddress(address);
    }


    public string getStandard() {
        return $"Title: {_eventTitle}\nDate: {_eventDate}\nTime: {_eventTime}";
    }

    public string shortDescription() {
        return $"Description: {_eventDescription}";
    }

}
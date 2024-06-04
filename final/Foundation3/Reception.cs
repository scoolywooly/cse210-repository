public class Reception : Event
{
    private string _email;
    private string _reception = "Reception";

    public Reception(string name, string date, string description, string time, string address, string email) :base(name, date, description, time, address) 
    {
        _email = email;
    }

    public string fullDetails() {
        string standard = getStandard();
        return $"Event Type: {_reception}\n{standard}\nEmail: {_email}";
    }
}
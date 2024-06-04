public class OutdoorGathering : Event
{
    private string _weatherForecast;
    private string _outdoorGathering = "Outdoor Gathering";
    public OutdoorGathering(string name, string date, string description, string time, string address, string forecast) :base(name, date, description, time, address) {
        _weatherForecast = forecast;
    }

    public string fullDetails() {
        string standard = getStandard();
        return $"Event Type: {_outdoorGathering}\n{standard}\nForecast: {_weatherForecast}";
    }
}
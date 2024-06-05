public class Swimming : Activity{
    private int _laps;

    public Swimming(string date, double minutes, int laps) :base(date, minutes)
    {
        _laps = laps;
        _date = date;
        _length = minutes;
    }

    public override double getDistance()
    {
        return _laps * 50 / (1000 * 0.62);
    }

    public override double getPace()
    {
        return _length / getDistance();
    }
    public override double getSpeed()
    {
        return getDistance() / _length * 60.00;
    }

    public override string GetSummary()
    {
        return $"Swimming Activity details:\n Date: {_date}, Length: {Math.Truncate(_length * 100) /100} - Minutes, Distance: {Math.Truncate(getDistance() * 100) /100} miles, Pace: {Math.Truncate(getPace() * 100)}, Speed: {Math.Truncate(getSpeed() * 100) /100}, Laps: {_laps}";
    }


}
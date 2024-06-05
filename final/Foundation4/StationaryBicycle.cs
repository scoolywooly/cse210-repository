using System.Diagnostics.Contracts;

public class StationaryBicycle : Activity{
    private double _speed;

    public StationaryBicycle(string date, double minutes, double speed) :base(date, minutes)
    {
        _date = date;
        _length = minutes;
        _speed = speed;
    }

    public override double getSpeed()
    {
        return _speed;
    }
    public override double getPace()
    {
        return 60.00 / _speed;
    }

    
    public override string GetSummary()
    {
        return $"Stationary Bicycle Activity details:\n Date: {_date}, Length: {Math.Truncate(_length * 100) /100} - Minutes, Distance: {Math.Truncate(getDistance() * 100) /100} miles, Pace: {Math.Truncate(getPace() * 100)}, Speed: {Math.Truncate(getSpeed() * 100) /100}";
    }

}
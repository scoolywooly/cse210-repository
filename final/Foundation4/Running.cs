using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

public class Running : Activity
{
    private double _distance;

    public Running(string date, double minutes, double distance) :base(date, minutes) /// takes whatever date and minutes is passed into the running object, and pass it into the base.  
    {
        _date = date;
        _length = minutes;
        _distance = distance;
    }

    public override double getDistance()
    {
        return _distance;
    }
    public override double getPace()
    {
        return _length / _distance;
    }
    public override double getSpeed()
    {
        return 60.00 / (_length/_distance);
    }
    public override string GetSummary()
    {
        return $"Running Activity details:\n Date: {_date}, Length: {Math.Truncate(_length * 100) /100} - Minutes, Distance: {Math.Truncate(_distance * 100) /100} miles, Pace: {Math.Truncate(getPace() * 100) /100}, Speed: {Math.Truncate(getSpeed() * 100) /100}";
    }

}
public abstract class Activity {
    
    protected string _date;
    protected double _length;

    public Activity(string date, double minutes) {
        _date = date;
        _length = minutes;
    }    

    public virtual double getDistance() {
        return getPace() * _length;
    }
    public virtual double getPace() {
        return _length / getDistance();
    }
    public virtual double getSpeed() {
        return getDistance() / _length * 60.00;
    }

    

    public virtual string GetSummary() {
        return $"Date: {_date}, Length: {_length} Minutes,";
    }
}
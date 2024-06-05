public abstract class Activity {
    
    protected string _date;
    protected double _length;

    public Activity(string date, double minutes) {
        _date = date;
        _length = minutes;
    }    

    public abstract double getDistance();
    public abstract double getPace();
    public abstract double getSpeed();

    public string getDate() {
        return _date;
    } 
    public double getMinues() {
        return _length;
    }

    public virtual string GetSummary() {
        return $"Date: {_date}, Length: {_length} Minutes,";
    }
}
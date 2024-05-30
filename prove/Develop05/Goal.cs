public abstract class Goal {
    protected string _shortName;
    protected string _description;
    protected int _points;

    protected string _goalType;


    protected bool _isComplete;
    

    public Goal(string name, string description, int points, int timesCheckedOff) { // points in this one just get added each time, you make progress.
        _shortName = name;
        _description = description;
        _points = points; // for eternal goals
        
        
    }
    public Goal(string name, string description, int points, bool completionStatus) {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = completionStatus; // for simple 
    }

    public Goal(string name, string description, int points, int target, int bonus) {
        _shortName = name;
        _description = description;
        _points = points;
        
    }

    

    public abstract int RecordEvent();

    public abstract bool IsComplete();
    
    public virtual string GetDetailsString() {
        if (_isComplete == true) {
            return $"[X] {_shortName} ({_description})";
        } else {
            return $"[ ] {_shortName} ({_description})";
        }
    }

    public abstract string GetStringRepresentation();    

    public string GetGoalName() {
        return _shortName;
    }

    public string GetGoalType() {
        return _goalType;
    }

}
public class ChecklistGoal : Goal
{
    protected int _amountCompleted;
    protected int _target;
    protected int _bonus;

    public ChecklistGoal(string name, string description, int points, int amountCompleted, int target, int bonus, bool completion) : base(name,description,points,target,bonus)
    {
        _shortName = name;
        _description = description;
        _points = points; // In this class, points is how many you earn each time, 
                          // where as target is the amount of times you want to do this goal.
        _isComplete = completion;
        _target = target;
        _bonus = bonus; // you get this if you actually complete a goal.
        _goalType = "ChecklistGoal";
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent() 
    {
        int award = _points;
        if (_isComplete == false) {
            _amountCompleted++; // we increase this after we check the iscompelte is false so 
                                // that we have a small window where isComplete is false
                                // and _amountCompleted == _target which allows us to add the bonus 
                                // to the award. Otherwise, this method just returns points.

            if (_amountCompleted == _target) { // if the amount completed isn't equal to the 
                award += _bonus;
                _isComplete = true;
            }
            return award;
        } else 
        {
            Console.WriteLine("You have already completed this goal, make a new one!");
            return 0;
        }

    }

    public override bool IsComplete() 
    {
        
        if (_amountCompleted == _target) {
            _isComplete = true;
            return true;
        } else {
            _isComplete = false;
            return false;
        }
        
    }
    
    public override string GetStringRepresentation() 
    {
        return $"{_goalType}|||{_shortName}|||{_description}|||{_points}|||{_amountCompleted}|||{_target}|||{_bonus}|||{_isComplete},,,";
    }

    public void setAmountCompleted(int amount) { // I have this so i don't have to keep making 
                                                 // new constructor arguements everytim I want to load something.
        _amountCompleted = amount;
    }

    public override string GetDetailsString() {
        if (_isComplete == true) {
            return $"[X] {_shortName} ({_description}) -- Completed {_amountCompleted}/{_target}";
        } else {
            return $"[ ] {_shortName} ({_description}) -- In progress {_amountCompleted}/{_target}";
        }
        
    }


}
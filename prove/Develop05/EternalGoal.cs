using System.ComponentModel;

public class EternalGoal : Goal
{
    private int _timesCompleted  = 0;
    protected int _earnedPointsCount;
    public EternalGoal(string name, string description, int points, int checkedOffCount) : base(name, description, points,checkedOffCount)
    {
        _shortName = name;
        _description = description;
        _points = points; // maybe i take a string and then combine the total points from the string of the text.
        _earnedPointsCount = checkedOffCount;// This keeps track how many times you earned _points, so we can tack it on the saved string
        _goalType = "EternalGoal";
        
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Hooray, here is {_points}");
        _earnedPointsCount += 1;
        
        return _points;

    }

    public override string GetStringRepresentation() 
    {
        

        return $"{_goalType}|||{_shortName}|||{_description}|||{_earnedPointsCount}|||{_points},,,";
        
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete. Ever.

    }
}
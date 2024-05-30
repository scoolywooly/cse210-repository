using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.IO;
public class SimpleGoal : Goal
{
    
    
   


    public SimpleGoal(string name, string description, int points, bool completionStatus) : base(name,description,points,completionStatus) {
        _shortName = name;
        _isComplete = completionStatus;
        _description = description;
        _points = points;
        _goalType = "SimpleGoal";
    } 

    public override int RecordEvent() 
    {
        _isComplete = true;
        return _points;




        // if (_isComplete == false) {
        //     Console.WriteLine("You have already been awarded points for completing this goal.");
        //     return 0; // returns 0, so that "nothing" is added onto the point counter when this function is called.
        // } else {
        //     Console.WriteLine($"You have completed {_shortName}! Here are your {_points} points!");
        //     _isComplete = true; // set it to true so this case only happens once.
        //     return _points ;
        // }

    }

    public override bool IsComplete() 
    {
        
        if (_isComplete == true) {
            return true;
        } else {
            return false;
        }
        
    }
    
    public override string GetStringRepresentation() 
    {
        return $"{_goalType}|||{_shortName}|||{_description}|||{_points}|||{_isComplete},,,";
    }



}
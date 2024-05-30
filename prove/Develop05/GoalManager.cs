using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.IO;
public class GoalManager {
    // Attributes
    
    protected List<Goal> _goals = new List<Goal>();
    private int _score;
    
    // Make the constructor here
    

    public void Start() {
        // Display the Main Menu
        // Call:
        // CreateGoal, DisplayPlayerInfo, SaveGoals, LoadGoals,
        // RecordEvent
        // Loop until quit is selected
        bool quit = false;
        Console.WriteLine("Welcome to the Gualp. (The Goal app)!");    

        while (quit == false) {
            Console.WriteLine("-------------------------\n   [1] Create Goal\n   [2] Display Scoreboard\n   [3] Save Goals\n   [4] Load Goals\n   [5] Quit\n   [6] Update Progress\n-------------------------");
            int userAction = Int16.Parse(Console.ReadLine());

            if (userAction == 1) {
                CreateGoal();
            } else if (userAction == 2) {
                DisplayPlayerInfo();
            } else if (userAction == 3) {
                SaveGoals();
            } else if (userAction == 4) {
                LoadGoals();
            } else if (userAction == 5) {
                Console.WriteLine("Quitting...");
                quit = true;
            } else if (userAction == 6) {
                RecordEvent();
            } else {
                Console.WriteLine("\nSorry! Please enter a number 1-5\n");
            }
        }
        // program ends.
    }
    public void DisplayPlayerInfo() {
        // Display the Player Info
        Console.WriteLine($"Here is your score: {_score}");
        ListGoalDetails();
    }
    public void ListGoalNames() {
        // Display the goals _shortNAme (foreach loop?)
        // (will need a .GetName Method for the Goal Class)
        int goalIndex = 0;
        Console.WriteLine("Here are your goals you've written so far:\n");
        foreach (Goal goal in _goals) {
            
            Console.WriteLine($"{_goals[goalIndex]} {goal.GetDetailsString()}");

            goalIndex++;
        }
    }
    public void ListGoalDetails() {
        // loop through the goals, displaying their details. (description? and completion?)
        int goalIndex = 0;
        Console.WriteLine("Here is all the progress on your goals so far:\n");
        foreach (Goal goal in _goals) {
            
            string currentGoalDetails = goal.GetDetailsString();
            Console.WriteLine($"{goalIndex + 1}. {currentGoalDetails}");

            goalIndex++;
        }
    }
    public void CreateGoal() {
        // Makes a Goal, its type, name, description, and points depending on the type.
        // If checklist make sure to ask for how many times the goal needs to be done.
        // Add to goal list after creation.
        Console.WriteLine("The types of goals are:\n");
        Console.WriteLine("    [1]. Simple Goal");
        Console.WriteLine("    [2]. Eternal Goal");
        Console.WriteLine("    [3]. Checklist Goal");
        Console.WriteLine("\nPlease enter a number:");

        int response = Int16.Parse(Console.ReadLine());
        
        if (response == 1) { // Simple goal

            // Get name
            Console.WriteLine("What is the goal's name?");
            string goalName = Console.ReadLine();
            // Get description
            Console.WriteLine("What is a short description of the goal?");
            string goalDescription = Console.ReadLine();
            // Get points for reward
            Console.WriteLine("How many points rewarded upon accomplishment?");
            int goalReward = Int32.Parse(Console.ReadLine()); // You never know if its a thousand points so I'm using a long number variable.

            // Now we make the goal
            SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalReward, false);
            _goals.Add(simpleGoal);

        } else if (response == 2) { // Eternal Goal

            // Get name
            Console.WriteLine("What is the goal's name?");
            string goalName = Console.ReadLine();
            // Get description
            Console.WriteLine("What is a short description of the goal?");
            string goalDescription = Console.ReadLine();
            // Get points for reward
            Console.WriteLine("How many points rewarded upon accomplishment?");
            int goalReward = Int32.Parse(Console.ReadLine()); // You never know if its a thousand points so I'm using a long number variable.

            // Now we make the goal
            EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalReward, 0);
            _goals.Add(eternalGoal);
        } else if (response == 3) { // Checklist Goal

            // Get name
            Console.WriteLine("What is the goal's name?");
            string goalName = Console.ReadLine();
            // Get description
            Console.WriteLine("What is a short description of the goal?");
            string goalDescription = Console.ReadLine();
            // Get points for reward
            Console.WriteLine("How many points rewarded upon accomplishment?");
            int goalReward = Int32.Parse(Console.ReadLine()); // You never know if its a thousand points so I'm using a long number variable.
            // Get target amount of times to complete this goal.
            Console.WriteLine("Have you many times have you worked on this goal already? (if not type 0)");
            int goalProgress = Int32.Parse(Console.ReadLine());

            Console.WriteLine("How many times do you need to do the goal?");
            int goalTarget = Int32.Parse(Console.ReadLine());
            // Get the bonus amount
            Console.WriteLine("What is the bonus amount for completion?");
            int goalBonus = Int32.Parse(Console.ReadLine());
            
            // Now we make the goal
            ChecklistGoal checklistGoal = new ChecklistGoal(goalName,goalDescription,goalReward,goalProgress,goalTarget,goalBonus,false);
            
            _goals.Add(checklistGoal);
        }
    }
    public void RecordEvent() {
        // Display a list of the goal names.
        // Update progress on a goal
        // User picks goal from a list using a seleciton number that is equal to the goal's index + 1.
        ListGoalNames();
        Console.WriteLine("Which Goal would you like to do?");
        int goalChoice = Int16.Parse(Console.ReadLine());

        Goal chosenGoal = _goals[goalChoice - 1];
        string goalType = chosenGoal.GetGoalType();

        if (goalType == "SimpleGoal") {
            Console.WriteLine($"{chosenGoal.GetGoalName()} - Have you completed this goal? [Y/N]");
            string response = Console.ReadLine();
            bool checkCompletion = chosenGoal.IsComplete();
            int awardedPoints;

            if (checkCompletion == false && (response.ToLower() == "yes" || response.ToLower() == "y")) {
                awardedPoints = chosenGoal.RecordEvent();
                _score += awardedPoints;
            } else if (checkCompletion == true) {
                Console.WriteLine("You have already completed this goal! \n(Perhaps you should have made it a checklist goal instead?)");
            } else {
                Console.WriteLine("You found an Easter Egg! +12 points.");
                _score += 12;
            }

        // The other two types of goals.
        } else {
            Console.WriteLine($"{chosenGoal.GetGoalName()} - Have you made progress on this goal? [Y/N]");
            string response = Console.ReadLine();

            if ((response.ToLower() == "yes" || response.ToLower() == "y") && chosenGoal.IsComplete() == false) {
                int awardedPoints = chosenGoal.RecordEvent();
                _score += awardedPoints;
             
            } else if (chosenGoal.IsComplete() == true) {
                Console.WriteLine("You have actually completed this goal! It should now be updated if you check your scoreboard.");
            }
            else {
                Console.WriteLine("Pick a different goal, this one is either completed or you haven't done anything yet.");
            }
            
            
        }
        
        
    }
    public void SaveGoals() {
        Console.WriteLine("What would you like to call the file to save your goals to? (include .txt)");
        string fileName = Console.ReadLine();
        string savedGoal = $"{_score}\n";

        foreach (Goal currentGoal in _goals) {           
            savedGoal += currentGoal.GetStringRepresentation();
        }

        if (File.Exists(fileName) == true) { // Replace old copy with new saved copy.
            File.Delete(fileName);
        }
        
        File.WriteAllText($"{fileName}", savedGoal);
        
    }
    public void LoadGoals() {
        Console.WriteLine("Name the file you want to load the goals from:");
        string whichLoadedFile = Console.ReadLine();
        string textFromFile = File.ReadAllText(whichLoadedFile);

        // Take each string and separate it out into variables
        // Use each set of variables to make a new object 
        // Add the Object into your list. (Clear list?)

        int loadedScore = Int32.Parse(File.ReadAllLines(whichLoadedFile).First());
        _score = loadedScore;

        string[] listOfLines = textFromFile.Split(",,,"); // each line in the file is an object and it's variables
        foreach(string objectLine in listOfLines) {
            string[] objectVariables = objectLine.Split("|||"); // separate the line into the object's values and create a new object with these values

            string objectName;
            string objectDescription;
            int objectPoints;
            int objectProgress;
            bool objectCompletion;


            string type = objectVariables[0];
            if (type == "SimpleGoal") {

                objectName = objectVariables[1];
                objectDescription = objectVariables[2];
                objectPoints = Int32.Parse(objectVariables[3]);
                objectCompletion = bool.Parse(objectVariables[4]);

                // Now we make a Simple Goal Object and then add it to the _goals list
                SimpleGoal sg = new SimpleGoal(objectName, objectDescription, objectPoints, objectCompletion);
                _goals.Add(sg);
            } else if (type == "ChecklistGoal") {

                

                objectName = objectVariables[1];
                objectDescription = objectVariables[2];
                objectPoints = Int32.Parse(objectVariables[3]);
                objectProgress = Int16.Parse(objectVariables[4]);
                int objectTarget = Int32.Parse(objectVariables[5]);
                int objectBonus = Int32.Parse(objectVariables[6]);
                objectCompletion = bool.Parse(objectVariables[7]);

                ChecklistGoal cg = new ChecklistGoal(objectName, objectDescription, objectPoints, objectProgress, objectTarget, objectBonus, objectCompletion);

                _goals.Add(cg);


            } else if (type == "EternalGoal") {
                objectName = objectVariables[1];
                objectDescription = objectVariables[2];
                int objectTimesCompleted = Int32.Parse(objectVariables[3]);
                objectPoints = Int32.Parse(objectVariables[4]);
                //objectPoints = Int32.Parse(objectVariables[3]);
                
                EternalGoal eg = new EternalGoal(objectName, objectDescription, objectTimesCompleted, objectPoints);


            }


        }
        

    }

}
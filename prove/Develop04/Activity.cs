using System;
public class Activity 
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity() {
        if (_name == "Breathing Activity") 
        {
            _description = "\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

        } else if (_name == "Reflecting Activity") 
        {
            _description = "\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        } else if (_name == "Listing Activity") 
        {
            _description = "\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        };
    }

    public Activity(string activityName, string activityDescription, int activityLength) 
    {
        _name = activityName;
        _description = activityDescription;
        _duration = activityLength;

    }

    public void DisplayStartingMessage() 
    {
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine(_description);
        Console.WriteLine("How many seconds would you like to do this activity for?");

        _duration = Int32.Parse(Console.ReadLine());
    }

    public void ShowSpinner(int seconds) 
    {

        List<string> animation = new List<string>();

        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        int index = 0;
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);


        while (DateTime.Now < endTime) {
            string frame = animation[index];
            Console.Write(frame);
            Thread.Sleep(500);
            Console.Write("\b \b");
            index++;

            if (index >= animation.Count) {
                index = 0;
            }
        }
        Console.Write("\b \b\n");
    }

    public void ShowCountDown(int seconds) {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime) 
        {
            Console.Write(seconds.ToString());
            Thread.Sleep(1000); // 1000 miliseconds = 1 second

            //Clear the number string, and take into account the possibility of large numbers.
            for (int i = 0; i < seconds.ToString().Length; i++) 
            {
                Console.Write("\b \b");
            }
            seconds -= 1;
        }
    }

    public void DisplayEndingMessage() {
        Console.WriteLine("Well Done!");
        Console.WriteLine($"\nYou completed the {_name} in {_duration} seconds!");
        ShowSpinner(3);
    }
}
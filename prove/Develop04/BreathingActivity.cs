using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity"; // I update the description as well... just in case
        _description = "\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run() {

        // We greet the user
        DisplayStartingMessage();
        
        Console.Clear();


        Console.WriteLine("Get Ready...");
        ShowSpinner(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);


        while (DateTime.Now < endTime)
        {
            BreathAnimation("in",4);
            Console.WriteLine("Hold! for ");
            ShowCountDown(3);
            Console.WriteLine("\n");
            BreathAnimation("out",6);
            Console.WriteLine("Take a deep breath in ");
            ShowCountDown(3);
            Console.WriteLine("\n");
        }
        DisplayEndingMessage();
        

    }

    public void BreathAnimation(string inOrOut, int seconds) {
        DateTime start = DateTime.Now;
		DateTime end = start.AddSeconds(seconds);

        if (inOrOut.ToLower() == "in") {
            Console.Write("Breath in");
        } else {
            Console.Write("Breath out");
        };
		

		
		for (int dotCounter = 0;DateTime.Now < end; dotCounter++) {
			Thread.Sleep(500);

			if (dotCounter >= 3){
				Console.Write("\b\b   \b\b\b");
				dotCounter = 0;
			} else {
				Console.Write(".");
			}
		}
        Console.Write("..");
    }
}

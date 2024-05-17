using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

public class ListingActivity : Activity {
    private int _count;
    private List<string> _prompts = new List<string>();
    

    public ListingActivity() {
        

        _count = 0;
        _name = "Listing Activity";
        _description = "";

        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("Who are some of your personal heroes?");
       
    }

    public void GetRandomPrompt() {
        Random rnd = new Random();
        int promptIndex = rnd.Next(0,_prompts.Count);
        string chosenPrompt = _prompts[promptIndex];
        Console.WriteLine("List as many things inspired by the following prompt as possible:");
        Console.WriteLine($"---{chosenPrompt}---");
    }

    public List<string> GetListFromUser() {

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        List<string> items = new List<string>();
        while (DateTime.Now < endTime) {
            
            Console.Write(">");
            items.Add(Console.ReadLine());
            _count++;

        }

        return items;
    }
    
    public void Run() {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Console.WriteLine($"Dureation:{_duration}");
        DateTime startTime = DateTime.Now;
        DisplayStartingMessage();
        DateTime endTime = startTime.AddSeconds(_duration);
        
        while (DateTime.Now < endTime) {
            ShowSpinner(2);
            GetRandomPrompt();
            GetListFromUser();
            Console.WriteLine("\n");
        }

        DisplayEndingMessage();
        ShowSpinner(2);
        Console.WriteLine($"You were able to write {_count} items in {_duration} seconds!");
        ShowSpinner(3);

    }

}

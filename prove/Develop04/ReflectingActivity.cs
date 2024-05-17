using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

public class ReflectingActivity : Activity {
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity() {
        
        _prompts.AddRange(new string[] {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you failed to do the right thing."
        });

        
        _questions.AddRange(new string[] {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        });

        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public string GetRandomPrompt() {
        Random rnd = new Random();
        int promptIndex = rnd.Next(0, _prompts.Count);
        string chosenPrompt = _prompts[promptIndex];

        return chosenPrompt;

    }

    public string GetRandomQuestion() {
        Random rnd = new Random();
        int questionIndex = rnd.Next(0, _questions.Count);
        string chosenQuestion = _questions[questionIndex];

        return chosenQuestion;
    }

    public void DisplayPrompt() {
        Console.Clear();
        string prompt = GetRandomPrompt();

        Console.WriteLine("Get Ready...");
        ShowSpinner(3);
        Console.WriteLine("\n");

        Console.WriteLine("Consider the following prompt:\n\n");


        Console.WriteLine($"---{prompt}---\n\n");

        Console.WriteLine("Press enter when you are ready to begin.");
        Console.ReadLine(); // We don't do the "while until time exceeds duration" loop until the DisplayQuestions Method.
        Console.WriteLine("You will begin in 5 seconds...\n");
        ShowCountDown(5);
    }

    public void DisplayQuestions() {
        Console.Clear();
        string question = GetRandomQuestion();

        Console.WriteLine("Get Ready...");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime) {
            ShowSpinner(3);
            Console.Clear();
            Console.WriteLine(question);
            
        }
    }

    public void Run() {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUserName();
        int favNum = PromptNumber();

        int squaredNumber = SquareNumber(favNum);

        DisplayOutput(squaredNumber, username);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }
    static string PromptUserName() 
    {
        Console.Write("What is your username: ");
        string username = Console.ReadLine();
        return username;
    }
    static int PromptNumber() 
    {
        Console.Write("What is your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }
    static int SquareNumber(int number) 
    {
        return number * number;
    }
    static void DisplayOutput(int squaredNum, string name)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNum}");
    }
}
    
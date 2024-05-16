using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment algebra = new MathAssignment();
        string homework = algebra.GetHomeworkList();
        Console.WriteLine(homework);


        WritingAssignment english = new WritingAssignment();
        string essay = english.GetWritingInformation();
        Console.WriteLine(essay);


        
    }
}
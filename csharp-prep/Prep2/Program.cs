using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? (without the %): ");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);
        int gradeOnesPlace = grade % 10;
        

        bool passed = false;
        //Determine which grade they got.
        string localLetter = "stand-in-value";
        string gradeSign = "stand-in-value";
        // Grade Letter
        if (grade < 60) // F
        {
            localLetter = "F";
            
        }
        else if (grade >= 60 && grade < 70) // D
        {
            localLetter = "D";
        }
        else if (grade >= 70 && grade < 80) // C
        {
            localLetter = "C";
            passed = true;
        }
        else if (grade >= 80 && grade <90) // B
        {
            localLetter = "B";
            passed = true;
        }
        else if (grade >= 90) // A
        {
            localLetter = "A";
            passed = true;
            
        }
        
        // Determine the sign. ["+", "-", or ""]
        if (gradeOnesPlace  < 3) {
            gradeSign = "-";
        }
        else if (gradeOnesPlace >= 3 && gradeOnesPlace <= 7) {
            gradeSign = ""; // I make sure the ones' place is between 3 and 7.
        }
        else if (gradeOnesPlace > 7) {
            gradeSign = "+";
        }

        // Determine if we shouldn't make an A+, F-, or F+ grade
        if (localLetter == "A" && (gradeSign == "+" || grade > 99)) { // Since A- exists in BYU-I's grading scale, then I only need to look for A+
            gradeSign = "";
        }
        else if (localLetter == "F") { // I can handle both signs like this
            gradeSign = "";
        }


        //print out the earned grade
        Console.WriteLine($"You earned the {localLetter}{gradeSign} grade.");

        if (passed == true) 
        {
            Console.WriteLine("Congratulations, You passed!");
        }
        else
        {
            Console.WriteLine("Well, you should retake this class if you want to pass.");
        }
    }

}
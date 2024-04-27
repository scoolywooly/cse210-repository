using System;
using System.Collections.Generic;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {

        
        List<int> numbers = new List<int>();
        
        bool exit = false; // for the while loop
        int numToAdd; // for the sum 

        while (exit == false) //make the list
        {
            Console.WriteLine("Enter a number (type 0 when you are done): ");
            numToAdd = int.Parse(Console.ReadLine());

            if (numToAdd == 0) {
                break;
            } else {
                numbers.Add(numToAdd);
            }
        };

        // get Cound
        int numberCount = numbers.Count();

        // get sum
        int numberSum = 0;
        foreach (int num in numbers) {
            numberSum += num;
        };

        // get average
        float average = numberSum / numberCount;



        // get largest
        int biggestSoFar = 0;
        for (int index = 0; index < numberCount; index++) {
            if (numbers[index] > biggestSoFar) {
                biggestSoFar = numbers[index];
            };
        };


        //give output
        Console.WriteLine($"The Count of this list is {numberCount}.");
        Console.WriteLine($"The Sum of this list is {numberSum}");
        Console.WriteLine($"The biggest number in this list is {biggestSoFar}");

    }
}
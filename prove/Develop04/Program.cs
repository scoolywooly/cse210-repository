using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Quic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{

    

    static void Main(string[] args){
        string quit = "no";

        while (quit.ToLower() == "no") {
            int userActivityChoice = 0;
            DisplayMenu();
            userActivityChoice = Int16.Parse(Console.ReadLine());

            if (userActivityChoice == 1) {
                BreathingActivity breathe = new BreathingActivity();
                breathe.Run();
            } else if (userActivityChoice == 2) {
                ReflectingActivity reflect = new ReflectingActivity();
                reflect.Run();
            } else if (userActivityChoice == 3) {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            } else if (userActivityChoice == 4) {
                quit = "yes";
            }
        }
        Console.WriteLine("Thanks for taking the time to relax and destress!");
        Console.WriteLine("Press any key to quit...");
        Console.ReadLine();

        
    }
    public static void DisplayMenu() {
        Console.Clear();
        Console.WriteLine("Menu Options: \n");
        Console.WriteLine("    [1] Breathing Activity\n");
        Console.WriteLine("    [2] Reflecting Activity\n");
        Console.WriteLine("    [3] Listing Activity\n");
        Console.WriteLine("    [4] Quit Activities\n");
        Console.WriteLine("----------------------------\n\n");
        
    }

    
}
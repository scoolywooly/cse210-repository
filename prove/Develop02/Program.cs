using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();

        int choice = 0;

        while (choice != 5) {
    

        // Display Menu
        Console.WriteLine("-------------------");
        Console.WriteLine("(1) Add New Entry.");
        Console.WriteLine("(2) Save Entries to file.");
        Console.WriteLine("(3) Load Entries from file.");
        Console.WriteLine("(4) Display all current Entries.");
        Console.WriteLine("(5) Quit");
        Console.WriteLine("-------------------");

        // Ask user what they want to do.
        Console.WriteLine("What would you like to do? (1-5)");
        Console.Write(">");
        choice = Int16.Parse(Console.ReadLine());
        
        
        if (choice == 1) { // Add new entry
            Entry newEntry = new Entry();
            
            theJournal.AddEntry(newEntry);



        } else if (choice == 2) { // Save the _entries list to a file.
            Console.WriteLine("Name the file.");
            Console.Write(">");
            string savedFileName = Console.ReadLine();

            theJournal.SaveToFile(savedFileName);
        } else if (choice == 3) { // Load a string containing entry information to be converted to Entry classes and then saved to the _entries list for display.

            Console.WriteLine("Name the file including the directory. ( ./Documents/example.txt)");
            Console.Write(">");
            string filepath = Console.ReadLine();

            theJournal.LoadFromFile(filepath);
        } else if (choice == 4) {
            theJournal.DisplayAll();
        }






        }

        
    }
}
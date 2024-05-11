using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Journal {
    private List<Entry> _entries;

    public Journal() {
        this._entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry) {
        //Get The DateTime for _date
        DateTime currentTimeAndDate = DateTime.Now;
        string currentDate = currentTimeAndDate.ToString("MM/dd/yyyy");
        //Now I set the date to the _date member variable.
        newEntry.SetDate(currentDate);

        Prompt currentPrompt = new Prompt();
        
        currentPrompt.SetPromptList("What do you regret?");
        currentPrompt.SetPromptList("What are you proud of?");
        currentPrompt.SetPromptList("What or who do you miss?");
        currentPrompt.SetPromptList("How did the hand of the Lord act in your life, today?");
        currentPrompt.SetPromptList("How will you accomplish your dreams?");

        string newPrompt = currentPrompt.GetRandomPrompt();
        newEntry.SetPrompt(newPrompt);


        //Get the text for the Entry
        Console.WriteLine(newEntry.GetPrompt());
        Console.WriteLine(">");
        newEntry.SetEntryText(Console.ReadLine());
        
        this._entries.Add(newEntry); // now we add the whole entry instance to the list
        
        
    }

    public void DisplayAll() {
        // we iterate through the _entry list to display all the entries
        foreach (Entry individualEntry in this._entries) {
            individualEntry.Display();
        }
    }

    public void SaveToFile(string file) {
        
        string allEntries = "";

        foreach (Entry singleEntry in this._entries) {
            string text = singleEntry.GetEntryText();
            string date = singleEntry.GetDate();
            string prompt = singleEntry.GetPrompt();

            allEntries += $"{date}|||{prompt}|||{text}+++"; // +++ is my separator for my load function
            
        }
        
        // In order to save it locally if the user wishes, the program needs to know what kind of operating system the computer as (Mac or Windows for example) so 
        // The program.cs can use the proper file directory slashes. ("/" or "\").    
        string slash = "";
        // I had a little help from Microsoft Co-Piliot to know if this was possible, but all the code is written by me.
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
            slash = @"\";

        } else {
            slash = "/";
        }




        Console.WriteLine("Where would you like to save this journal? (enter LOCAL if you want to save locally!)");
        string path = Console.ReadLine();

        if (path.ToLower() == "local") {
            //Set the path to the local directory
            path = $".{slash}journal{slash}{file}";
            File.WriteAllText(path, allEntries);
        } else {
            File.WriteAllText(path, allEntries);
        }
        this._entries.Clear();
    }

    public void LoadFromFile(string filepath) {
        

        string load = File.ReadAllText(filepath);
        string[] fileContents = load.Split("+++");




        foreach (string entry in fileContents) {


            // Makes ure we aren't tryingto save an empty stringto an Entry class

            if (entry != "") {
            // Now we add a new entry to _entries with the information in the following foreach loop.
            Entry loadedEntry = new Entry();

            string[] entryInfo = entry.Split("|||");

            loadedEntry.SetDate(entryInfo[0]);
            loadedEntry.SetPrompt(entryInfo[1]);
            loadedEntry.SetEntryText(entryInfo[2]);

            this._entries.Add(loadedEntry);
            }


        }

        
    }
}
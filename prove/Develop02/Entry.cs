using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Entry {
    private string _date;
    private string _promptString;

   
    private string _entryText;

    public void Display() {
        Console.WriteLine("-------------------");
        
        Console.WriteLine($"Date: {_date} Prompt: {_promptString} \n{_entryText}");
        
    }

    public string GetDate() {
        return _date;
    }

    public void SetDate(string newDate) {
        _date = newDate;
    }

    public string GetPrompt() {
        return _promptString;
    }

    public void SetPrompt(string newPrompt) {
        _promptString = newPrompt;
    }

    public void SetEntryText(string text) {
        _entryText = text;
    }

    public string GetEntryText() {
        return _entryText;
    }
}
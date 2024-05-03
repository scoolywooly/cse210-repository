using System.Security.Cryptography.X509Certificates;

public class Entry {
    public string _date;
    public string _promptString;

    public string _entryText;

    public void Display() {
        Console.WriteLine("-------------------");
        Console.WriteLine($"Date: {_date} Prompt: {_promptString} \n{_entryText}");
        
    }
}
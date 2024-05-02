using System.Security.Cryptography.X509Certificates;

public class Resume() {
    public string _personName = "";
    // I made use the Job class that I made earlier to create a list of work-experience.
    public List<Job> _jobs = new List<Job>(0);


    public void DisplayResume() {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine($"Jobs:");

        // We iterate through the jobs list
        foreach (Job job in _jobs) { // O_o ooohhhh! you cna iterate through a class!
            job.DisplayJobDetails();
        }
    }

}
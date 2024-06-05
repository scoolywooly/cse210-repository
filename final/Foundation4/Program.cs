using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running morningJog = new Running("1/22/2004",34,100);
        activities.Add(morningJog);
        StationaryBicycle legDay = new StationaryBicycle("3/4/2005",60,10);
        activities.Add(legDay);
        Swimming hotSummerDay = new Swimming("4/5/2006",25,8);
        activities.Add(hotSummerDay);

        foreach (Activity activity in activities) {
            if (activity is Running) {
                Console.WriteLine(activity.GetSummary() + "\n\n");                
            } else if (activity is StationaryBicycle) {
                Console.WriteLine(activity.GetSummary() + "\n\n");            
            } else if (activity is Swimming) {
                Console.WriteLine(activity.GetSummary() + "\n\n");            
            }
        }


    }
}
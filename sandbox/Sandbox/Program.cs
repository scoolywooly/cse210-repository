using System;
using System.Threading;		
public class Program
{
	public static void Main()
	{
    	DateTime start = DateTime.Now;
		DateTime end = start.AddSeconds(5);
		Console.Write("Breath in");

		
		for (int dotCounter = 0;DateTime.Now < end; dotCounter++) {
			Thread.Sleep(500);

			if (dotCounter >= 3){
				Console.Write("\b\b   \b\b\b");
				dotCounter = 0;
			} else {
				Console.Write(".");
			}
		}
        Console.Write("..");
	}
}
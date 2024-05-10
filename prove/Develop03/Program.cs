using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string response = "continue";

        // Moroni 10:4
        Reference scriptureToMemorize1 = new Reference("Moroni",10,4);
        Scripture scripture = new Scripture(scriptureToMemorize1, "And when ye shall receive these things, I would \nexhort you that ye would ask God, the \nEternal Father, in the name of Christ, if \nthese things are not true; and if ye \nshall ask with a sincere heart, with real \nintent, having faith in Christ, he will manifest \nthe truth of it unto you, by the power of the Holy Ghost.");

        while (response.ToLower() != "quit") {
            
            // User Display
            
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue, or type 'quit' to exit the program.");
            response = Console.ReadLine();        
            
            // Hide Words

            Random rnd = new Random();
            
            scripture.HideRandomWords(rnd.Next(2,6));
            
            // check to see if hte scripture is completely hidden, if so then close the program
            if (scripture.IsCompletelyHidden() == true) {
                response = "quit";
                
                
            }
            
            Console.Clear();
        }

        response = "continue";
        Reference scriptureToMemorize2 = new Reference("1 Corinthians",10,13,14);
        Scripture scripture2 = new Scripture(scriptureToMemorize2, "\n\n13 There hath no temptation taken you but such as is common to man: but God is faithful, who will not suffer you to be tempted above that ye are able; but will with the temptation also make a way to escape, that ye may be able to bear it.\n\n14 Wherefore, my dearly beloved, flee from idolatry.");
        
        while (response.ToLower() != "quit") {
            
            // User Display
            
            Console.WriteLine(scripture2.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue, or type 'quit' to exit the program.");
            response = Console.ReadLine();        
            
            // Hide Words

            Random rnd = new Random();
            
            scripture2.HideRandomWords(rnd.Next(2,6));
            
            // check to see if hte scripture is completely hidden, if so then close the program
            if (scripture2.IsCompletelyHidden() == true) {
                response = "quit";
                
                
            }
            
            Console.Clear();
        }

    }
}
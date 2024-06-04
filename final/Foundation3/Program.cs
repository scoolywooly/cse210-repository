using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();


        // Lecture event.
        Lecture cse210 = new Lecture("Programming with Classes", "05/02/2024",
                                    "We will begin disscussions on the topic of Encapsulation so that we all understand it well.",
                                    "2:00 pm", "510 S Center St, Room 356, Rexburg, ID 83460", "Brother Chad Macbeth", 25);
        events.Add(cse210);


        // Reception event.
        Reception sealingCeremony = new Reception("Temple Wedding Sealing", "04/01/2023", "I am TOTTALLY getting married, at the temple. Please come!", "3:00 pm", "1471 S Geneva Rd, Orem, UT 84058", "TerryCatcher@gmail.com");
        events.Add(sealingCeremony);

        // Outdoor Gathering
        OutdoorGathering chilliCookout = new OutdoorGathering("Chilli Competition", "12/25/2024", "We will be competing to make Chilli in the Christmas spirit! Then we will have a spiritual thought about Christ's birth", "11:30 am", "1075 S Geneva Rd, Orem, UT 84057", "20% Snow");
        events.Add(chilliCookout);


        foreach (Event E in events) {
            if (E is Lecture) {
                Lecture lectureObject = E as Lecture;
                Console.WriteLine(lectureObject.fullDetails() + "\n" + lectureObject.shortDescription() + "\n\n");
            } else if (E is Reception) {
                Reception receptionObject = E as Reception;
                Console.WriteLine(receptionObject.fullDetails() + "\n" + receptionObject.shortDescription() + "\n\n");
            } else if (E is OutdoorGathering) {
                OutdoorGathering outdoorObject = E as OutdoorGathering;
                Console.WriteLine(outdoorObject.fullDetails() + "\n" + outdoorObject.shortDescription() + "\n\n");
            }
        }

    }
    }
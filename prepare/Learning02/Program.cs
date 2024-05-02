using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        // Testing Job Class

        Job job1 = new Job();
        Job job2 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Tesla";
        job1._startYear = 2017;
        job1._endYear = 2021;

        job2._jobTitle = "Software Engineer";
        job2._company = "Microsoft";
        job2._startYear = 2021;
        job2._endYear = 2024;

        
        job1.DisplayJobDetails();
        job2.DisplayJobDetails();



        // Testing Resume Class

        Resume futureResume = new Resume();

        // Add the jobs to the resume's empty list 
        //(I had a hard time at first until I realized I was asking the console to print out an empty list with the index of 0)
        futureResume._personName = "Benjamin Brinkerhoff";
        futureResume._jobs.Add(job1);
        futureResume._jobs.Add(job2);

        futureResume.DisplayResume();


       

        

        


    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 1952;
        job1._endYear = 1995;

        Job job2 = new Job();
        job2._jobTitle = "Drafter";
        job2._company = "Horrocks";
        job2._startYear = 1996;
        job2._endYear = 2025;

//        job1.DisplayDetails();
//        job2.DisplayDetails();

        Resume person1= new Resume();
        person1._name = "Heather Kinsey";
        person1._jobs.Add(job1);
        person1._jobs.Add(job2);

        person1.DisplayJob();

    }
}
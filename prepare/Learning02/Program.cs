using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._start = 1987;
        job1._end = 2001;

        Job job2 = new Job();
        job2._jobTitle = "Janitor";
        job2._company = "Google";
        job2._start = 1989;
        job2._end = 2013;

        Resume newResume = new Resume();
        newResume._name = "Johnny Smithington";
        newResume._jobs.Add(job1);
        newResume._jobs.Add(job2);

        newResume.Display();
    }
}
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Resume resume1 = new Resume();

        resume1._name = "Jared Remington";


        Job job1 = new Job();

        job1._jobTitle = "Jr. Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2006;
        job1._endYear = 2012;

        resume1._jobs.Add(job1);


        Job job2 = new Job();

        job2._jobTitle = "Sr. Software Engineer";
        job2._company = "Microsoft";
        job2._startYear = 2013;
        job2._endYear = 2019;

        resume1._jobs.Add(job2);


        Console.Clear();
        resume1.Display();
    }
}
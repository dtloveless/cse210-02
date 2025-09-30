using System

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine(_name);
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Work History");
        Console.WriteLine("----------------------------------------");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
        Console.WriteLine("----------------------------------------");
    }
}
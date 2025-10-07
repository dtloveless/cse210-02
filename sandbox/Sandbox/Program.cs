using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        School school1 = new School();
        school1._name = "BYU-I";
        school1._numTeachers = 100;
        school1._numStudents = 2000;

        string userResponse;
        while (true)
        {
            Console.Write("Would you like to add a student (y/n)? ");
            userResponse = Console.ReadLine();

            if (userResponse == "y")
            {
                school1.AddStudent();
            }
            else
            {
                break;
            }
        }

        school1.ShowDetails();
    }
}
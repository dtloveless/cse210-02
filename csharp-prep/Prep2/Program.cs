using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // Retrieve grade from user as a percentage
        Console.Write("Please enter your percent grade: ");
        string userResponse = Console.ReadLine();
        float percentGrade = float.Parse(userResponse);

        // // Core Requirement 1 - Determine letter grade and display result
        // if (percentGrade >= 90)
        // {
        //     Console.WriteLine("Congrats, you earned an A!");
        // }
        // else if (percentGrade >= 80)
        // {
        //     Console.WriteLine("Good job, you earned a B.");
        // }
        // else if (percentGrade >= 70)
        // {
        //     Console.WriteLine("You earned a C.");
        // }
        // else if (percentGrade >= 60)
        // {
        //     Console.WriteLine("You earned a D.");
        // }
        // else
        // {
        //     Console.WriteLine("You earned an F.");
        // }

        // Core Requirement 3 - Determine letter grade
        string letterGrade;
        if (percentGrade >= 90)
        {
            letterGrade = "A";
        }
        else if (percentGrade >= 80)
        {
            letterGrade = "B";
        }
        else if (percentGrade >= 70)
        {
            letterGrade = "C";
        }
        else if (percentGrade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        // Stretch Challenges 1-3 - Determine signed letter grade
        int onesDigit = (int)percentGrade % 10;
        string sign;

        if (onesDigit >= 7 && !(letterGrade == "A" || letterGrade == "F"))
        {
            sign = "+";
        }
        else if (onesDigit < 3 && letterGrade != "F")
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // Print letter grade
        Console.WriteLine($"Letter grade earned: {letterGrade}{sign}");

        // Core Requirement 2 - Determine if passing and output result
        if (percentGrade >= 70)
        {
            Console.WriteLine("Congrats, you passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the course. Do try again!");
        }
    }
}
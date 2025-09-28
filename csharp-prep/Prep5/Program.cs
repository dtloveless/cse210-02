using System;
using System.ComponentModel;

class Program
{
    static void DisplayWelcome(string message)
    {
        Console.WriteLine(message);
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        int squaredNumber;

        squaredNumber = (int)Math.Pow(number, 2);

        return squaredNumber;
    }

    static void DisplayResult(string name, int squaredNumber, int birthYear)
    {
        int age = 2025 - birthYear;

        Console.WriteLine($"{name}, the square of your number is {squaredNumber}.");
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }

    static void Main(string[] args)
    {
        string message = "Welcome to the Program!";
        string userName;
        int userNumber;
        int userBirthYear;
        int squaredNumber;

        DisplayWelcome(message);
        userName = PromptUserName();
        userNumber = PromptUserNumber();
        PromptUserBirthYear(out userBirthYear);
        squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber, userBirthYear);

    }
}

// DisplayWelcome - Displays the message, "Welcome to the Program!"
// PromptUserName - Asks for and returns the user's name (as a string)
// PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
// PromtUserBirthYear - Accepts out integer parameter and prompts the user for the year they were born. The out parameter is set to their birth year. This function does not return a value. The user's birth year is given back from the function via the out parameter.
// SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
// DisplayResult - Accepts the user's name, the squared number, and the user's birth year. Display the user's name and squared number. Calculate hold many years old they will turn this year and display that.

// Welcome to the program!
// Please enter your name: Brother Burton
// Please enter your favorite number: 42
// Please enter the year you were born: 1990
// Brother Burton, the square of your number is 1764
// Brother Burton, you will turn 35 this year.
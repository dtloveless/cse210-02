using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int newNumber;
        while (true)
        {
            Console.Write("Enter number: ");
            newNumber = int.Parse(Console.ReadLine());
            if (newNumber == 0)
            {
                break;
            }
            else
            {
                numbers.Add(newNumber);
            }
        }

        int sum = 0;
        int greatestNum = -2147483647;
        int smallestNum = 2147483647;
        int smallestPosNum = 2147483647;
        bool hasPosNum = false;

        foreach (int number in numbers)
        {
            sum += number;
            if (number > greatestNum)
            {
                greatestNum = number;
            }
            if (number < smallestNum)
            {
                smallestNum = number;
                if (number > 0)
                {
                    smallestPosNum = number;
                    hasPosNum = true;
                }
            }
        }

        double average = (double)sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {greatestNum}");
        if (hasPosNum) { Console.WriteLine($"The smallest positive number is: {smallestPosNum}"); }
        Console.WriteLine($"The smallest number is: {smallestNum}");

        List<int> sortedList = new List<int>();
        List<int> workingList = numbers;

        workingList.Remove(smallestNum);
        sortedList.Add(smallestNum);

        while (workingList.Count > 0)
        {
            int nextSmallestNum = 2147483647;
            foreach (int num in workingList)
            {
                if (num < nextSmallestNum)
                {
                    nextSmallestNum = num;
                }
            }

            workingList.Remove(nextSmallestNum);
            sortedList.Add(nextSmallestNum);
        }

        Console.WriteLine("The sorted list is: ");
        foreach (int number in sortedList) { Console.WriteLine(number); }
    }
}
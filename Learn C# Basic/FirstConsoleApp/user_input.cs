using System;

class userInput
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input Student information ");
        Console.Write("Enter your name: ");
        string studentName = Console.ReadLine() ?? string.Empty;
        Console.Write("Enter your Age: ");
        int age = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter your Varsity name: ");
        string varsityName = Console.ReadLine() ?? string.Empty;
        Console.Write("Enter Student ID: ");
        long stuID = long.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter your Program Name: ");
        string programName = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Student Name: " + studentName);
        Console.WriteLine("Student Age: " + age);
        Console.WriteLine("Varsity Name: " + varsityName);
        Console.WriteLine("Student ID: " + stuID);
        Console.WriteLine("Program Name: " + programName);
    }
}
using System;

class userInput
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input your University information: ");
        Console.Write("Enter your name: ");
        string studentName = Console.ReadLine() ?? string.Empty;
        Console.Write("Enter your Age: ");
        int age = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter your University name: ");
        string varsityName = Console.ReadLine() ?? string.Empty;
        Console.Write("Enter Student ID: ");
        long stuID = long.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter your Program Name: ");
        string programName = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("\nHere is your information (Printed copy):");

        Console.WriteLine("Student Name: Welcome " + studentName);
        Console.WriteLine("Student Age: " + age);
        Console.WriteLine("University Name: " + varsityName);
        Console.WriteLine("Student ID: " + stuID);
        Console.WriteLine("Program Name: " + programName);
    }
}
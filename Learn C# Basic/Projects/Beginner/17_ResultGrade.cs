using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Result Calculator.");
        Console.Write("Enter your name: ");
        string name = Console.ReadLine()!;
        Console.Write("Enter your Physics Marks: ");
        int phyMarks = Convert.ToInt32(Console.ReadLine()!);
        Console.Write("Enter your Chmiestry Marks: ");
        int chemMarks = Convert.ToInt32(Console.ReadLine()!);
        Console.Write("Enter your Biology Marks: ");
        int bioMarks = Convert.ToInt32(Console.ReadLine()!);
        int total = phyMarks + chemMarks + bioMarks;
        int avgMarks = total / 3;
        string grade;
        if (avgMarks >= 80)
            grade = "A+";
        else if (avgMarks >= 70)
            grade = "A";
        else if (avgMarks >= 60)
            grade = "A-";
        else if (avgMarks >= 50)
            grade = "B";
        else if (avgMarks >= 40)
            grade = "C";
        else
            grade = "F";
        Console.Write("Name:" + name);
        Console.Write("\nTotal Marks: " + total);
        Console.WriteLine("\nAverage Marks: " + avgMarks);
        Console.WriteLine("Grade: " + grade);

    }

}
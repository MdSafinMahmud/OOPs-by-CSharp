using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a character for ASCII value: ");
        char character = Convert.ToChar(Console.ReadLine()!);
        int ascii = character;
        Console.WriteLine($"ASCII value is {ascii}"); 
    }
}
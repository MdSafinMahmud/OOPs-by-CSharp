using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 20;
        Console.WriteLine($"Before Swap: a={a},b={b}");
        a = a + b;
        b = a - b;
        a = a - b;
        Console.Write($"After swap: a={a},b={b}");
    }
}
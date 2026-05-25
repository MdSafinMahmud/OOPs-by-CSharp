using System;

class MyClass
{
    static void Main(string[] args)
    {
        double number = 10.5;
        int number2 = Convert.ToInt32(number);
        Console.WriteLine($"number2={number2}");
        Console.ReadKey();
    }
}
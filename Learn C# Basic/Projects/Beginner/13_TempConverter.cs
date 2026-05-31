using System;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        Console.WriteLine("Enter temperature: ");
        Console.WriteLine("1.Celcius to fahrenheit.");
        Console.WriteLine("2.Fahrenheit to celcius.");
        Console.Write("Choose an option: ");
        choice = Convert.ToInt32(Console.ReadLine()!);
        switch (choice)
        {
            case 1:
                double celcius;
                double farh;
                Console.Write("Enter celcius: ");
                celcius = double.Parse(Console.ReadLine()!);
                farh = 1.8 * celcius + 32;
                Console.WriteLine("The fahrenheit Temerature is= " + farh);
                break;
            case 2:
                double farhenheit;
                double cel;
                Console.Write("Enter farhenheit: ");
                farhenheit = double.Parse(Console.ReadLine()!);
                cel = (farhenheit - 32) * 0.555555556;
                Console.WriteLine("The celcius temperature is= " + cel);
                break;
            default:
                Console.WriteLine("Enter temperature please");
                break;
        }
    }
}
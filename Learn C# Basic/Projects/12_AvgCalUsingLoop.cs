using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nAverage Calculator");
            Console.WriteLine("Enter 0 to close calculator");
            Console.WriteLine("How many numbers you want to average? ");
            int choice = int.Parse(Console.ReadLine()!);
            if (choice == 0)
            {
                Console.WriteLine("Calculator Closed!");
                return;
            }
            if (choice < 2 || choice > 10)
            {
                Console.WriteLine("Invalid Input");
                continue;
            }
            double sum = 0;
            int i;
            for (i = 0; i <= choice; i++)
            {
                Console.WriteLine("Enter number: " + i + ":");
                double number = double.Parse(Console.ReadLine()!);
                sum += number;
            }
            double avg = sum / choice;
            Console.Write("Average number is = " + avg);
        }
    }
}

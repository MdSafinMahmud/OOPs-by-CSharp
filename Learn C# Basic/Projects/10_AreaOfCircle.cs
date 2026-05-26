using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nArea Calculator");
            Console.WriteLine("1.Circle ");
            Console.WriteLine("2.Triangle");
            Console.WriteLine("3.Square");
            Console.WriteLine("4.Rectangle");
            Console.WriteLine("5.Exit");

            Console.Write("Choose an option ");
            int choice = int.Parse(Console.ReadLine()!);
            if (choice == 5)
            {
                Console.WriteLine("Exiting calculator...");
                break;
            }

            switch (choice)
            {
                case 1:
                    double pi = 3.1416;
                    Console.Write("Enter the radius of circle: ");
                    double r = double.Parse(Console.ReadLine()!);
                    double result = pi * r * r;
                    Console.Write("The area of circle is = " + result);
                    break;
                case 2:
                    double b, h;
                    Console.Write("Enter the triangle base: ");
                    b = double.Parse(Console.ReadLine()!);
                    Console.Write("Enter the triangle hight: ");
                    h = double.Parse(Console.ReadLine()!);
                    double triangleArea = 0.5 * b * h;
                    Console.WriteLine("The area of triangle : " + triangleArea);
                    break;
                case 3:
                    double x;
                    Console.Write("Enter the length of square: ");
                    x = double.Parse(Console.ReadLine()!);
                    double squareArea = x * x;
                    Console.Write("The area of square: " + squareArea);
                    break;
                case 4:
                    double l, w;
                    Console.Write("Enter the rectangle length: ");
                    l= double.Parse(Console.ReadLine()!);
                    Console.Write("Enter the rectangle width : ");
                    w = double.Parse(Console.ReadLine()!);
                    double rectangleArea = l * w;
                    Console.Write("The area of rectangle is= " + rectangleArea);
                    break;
                default:
                    Console.WriteLine("Please input Number.");
                    break;
            }

        }
    }
}


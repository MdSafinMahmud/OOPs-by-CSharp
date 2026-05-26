using System;

class CalculatorProgram
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {

            Console.WriteLine("==Calculator Menu==");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Substraction");
            Console.WriteLine("3.Division");
            Console.WriteLine("4.Multiplication");
            Console.WriteLine("5.Exit");

            Console.WriteLine("Choose an Option: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 5)
            {
                Console.WriteLine("Calculator Closed. Good Bye...");
                running = false;
                break;
            }
            Console.WriteLine("Enter number: ");
            double number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            double number2 = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Result= " + (number1 + number2));
                    break;
                case 2:
                    Console.WriteLine("Result=" + (number1 - number2));
                    break;
                case 3:
                    Console.WriteLine("Result= " + (number1 / number2));
                    break;
                case 4:
                    Console.WriteLine("Result= " + (number1 * number2));
                    break;
                default:
                    Console.WriteLine("Please INPUT numbers not words!");
                    break;

            }
        }
    }
}
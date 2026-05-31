using System;
using System.Data.Common;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        double balance = 1000;
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nATM Menu: ");
            Console.WriteLine("1. Check Balance: ");
            Console.WriteLine("2. Deposit:  ");
            Console.WriteLine("3. Withdraw: ");
            Console.WriteLine("4. Exit. ");
            Console.Write("Choose an option: ");
            int choice = Convert.ToInt32(Console.ReadLine()!);
            switch (choice)
            {
                case 1:
                    Console.Write("Current Balance: " + balance + "TK");
                    break;
                case 2:
                    Console.Write("Enter deposit amount: ");
                    double deposit = Convert.ToInt32(Console.ReadLine()!);
                    if (deposit > 0)
                    {
                        balance += deposit;
                        Console.WriteLine("Deposit Successfull");
                        Console.WriteLine("New Balance: "+ balance + "TK");
                    }
                    else
                    {
                        Console.WriteLine("Invalid!");
                    }
                    break;
                case 3:
                    Console.Write("Enter withdraw amount: ");
                    double withdraw = Convert.ToInt32(Console.ReadLine()!);
                    if (withdraw > balance)
                    {
                        Console.Write("Insufficient balance: ");
                    }
                    else if (withdraw <= 0)
                    {
                        Console.Write("Invalid amount: ");
                    }
                    else
                    {
                        balance -= withdraw;
                        Console.Write("Withdraw successfull! ");
                        Console.Write("\nRemaining Balance: " + balance + "TK");
                    }
                    break;
                case 4:
                    running = false;
                    Console.Write("ATM Closed");
                    break;
                default:
                    Console.Write("Invalid option");
                    break;

            }
        }
    }
}
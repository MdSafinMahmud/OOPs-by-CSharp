using System;

class Program
{
    static string filePath = "user.txt";
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nATM MENU...");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Password Reset");
            Console.WriteLine("4. Exit");
            Console.Write("Choose option: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Register();
                    break;

                case 2:
                    Login();
                    break;

                case 3:
                    PassReset();
                    break;

                case 4:
                    Console.WriteLine("ATM Closed!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid Option!");
                    break;
            }
        }
    }
    static void Register()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine()!;
        Console.Write("Enter password: ");
        string password = Console.ReadLine()!;
        File.WriteAllText(filePath, username + "," + password);
        Console.WriteLine("Registration Successful!");
    }
    static void Login()
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("No user found. Please register first.");
            return;
        }
        string data = File.ReadAllText(filePath);
        string[] parts = data.Split(',');
        string savedUsername = parts[0];
        string savedPassword = parts[1];
        Console.Write("Enter username: ");
        string username = Console.ReadLine()!;
        Console.Write("Enter password: ");
        string password = Console.ReadLine()!;
        if (username == savedUsername && password == savedPassword)
        {
            Console.WriteLine("Login Successful!");

            ATMMenu();
        }
        else
        {
            Console.WriteLine("Wrong username or password!");
        }
    }
    static void PassReset()
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("No account found!");
            return;
        }
        string data = File.ReadAllText(filePath);
        string[] parts = data.Split(',');
        string savedUsername = parts[0];
        Console.Write("Enter your username: ");
        string username = Console.ReadLine()!;
        if (username == savedUsername)
        {
            Console.Write("Enter new password: ");
            string newPass = Console.ReadLine()!;

            File.WriteAllText(filePath, username + "," + newPass);

            Console.WriteLine("Password Reset Successful!");
        }
        else
        {
            Console.WriteLine("Username not found!");
        }
    }
    static void ATMMenu()
    {
        bool loggedIn = true;
        double balance = 1000;
        while (loggedIn)
        {
            Console.WriteLine("\nATM MENU");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Logout");
            Console.Write("Choose option: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Current Balance: " + balance + " TK");
                    break;
                case 2:
                    Console.Write("Enter deposit amount: ");
                    double deposit = Convert.ToDouble(Console.ReadLine());

                    if (deposit > 0)
                    {
                        balance += deposit;

                        Console.WriteLine("Deposit Successful!");
                        Console.WriteLine("New Balance: " + balance + " TK");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Amount!");
                    }

                    break;
                case 3:
                    Console.Write("Enter withdraw amount: ");
                    double withdraw = Convert.ToDouble(Console.ReadLine());

                    if (withdraw > balance)
                    {
                        Console.WriteLine("Insufficient Balance!");
                    }
                    else if (withdraw <= 0)
                    {
                        Console.WriteLine("Invalid Amount!");
                    }
                    else
                    {
                        balance -= withdraw;

                        Console.WriteLine("Withdraw Successful!");
                        Console.WriteLine("Remaining Balance: " + balance + " TK");
                    }
                    break;
                case 4:
                    loggedIn = false;
                    Console.WriteLine("Logout Successful!");
                    break;

                default:
                    Console.WriteLine("Invalid Option!");
                    break;
            }
        }
    }
}
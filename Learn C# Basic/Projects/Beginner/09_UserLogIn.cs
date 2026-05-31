using System;
// using System.Data.Common;
using System.IO;
class Program
{
    static string filePath = "user.txt";

    static void Main()

    {
        Console.WriteLine("1. Register");
        Console.WriteLine("2. Log in");
        Console.WriteLine("3. Password Reset");
        Console.Write("Choose an option: ");
        int choice = Convert.ToInt32(Console.ReadLine()!);
        switch (choice)
        {
            case 1:
                Register();
                break;
            case 2:
                Login();
                break;
            case 3:
                ResetPassword();
                break;
        }

    }
    static void Register()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine()!;
        Console.Write("Enter password: ");

        string password = Console.ReadLine()!;

        File.WriteAllText(filePath, username + "," + password);
        Console.WriteLine("Registration successfull");
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
            Console.WriteLine("Log in Successfull");
        }
        else
        {
            Console.WriteLine("Wrong Username or Password");
        }
    }
    static void ResetPassword()
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("No Account Found");
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
            string newPassword = Console.ReadLine()!;
            File.WriteAllText(filePath, username + "," + newPassword);
            Console.WriteLine("Password reset Successfull");
        }
        else
        {
            Console.WriteLine("User Name not found!");
        }
    }

}

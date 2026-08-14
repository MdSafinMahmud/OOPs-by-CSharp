using System;

class BankAccount
{
    public double balance;
    public string name = "";

    public void DisplayInfo()
    {
        Console.WriteLine($"Account Holder:{name}");
        Console.WriteLine($"Account Balance:{balance}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        BankAccount myAccount = new();
        myAccount.balance = 5000;
        myAccount.name = "Safin Mahmud";
        myAccount.DisplayInfo();
    }
}

// public → Access Modifier
// void   → Return Type
// DisplayInfo → Method Name
// ()     → Parameters
// {}     → Method Body
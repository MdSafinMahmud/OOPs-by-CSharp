class Assignment
{
    public static void Main(string[] args)
    {
        string phoneName;
        double prize;
        string category;
        bool isAvailable;
        int sold;

        phoneName = "Apple iphone 14";
        prize = 320.5;
        category = "Smartphone";
        isAvailable = true;
        sold = 5;

        Console.WriteLine("Name: " + phoneName);
        Console.WriteLine("Prize:\t$" + prize);
        Console.WriteLine("Category: " + category);
        Console.WriteLine("isAvailable: " + isAvailable);
        Console.WriteLine("Sold: " + sold);


    }
}
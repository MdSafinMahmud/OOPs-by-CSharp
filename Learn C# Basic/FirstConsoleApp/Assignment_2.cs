class Assignment
{
    public static void Main(string[] args)
    {
        string phoneName;
        double prize;
        string category;
        bool available;
        int sold;

        phoneName = "Apple iphone 14";
        prize = 320.0;
        category = "Smartphone";
        available = true;
        sold = 5;

        Console.WriteLine("Name: " + phoneName);
        Console.WriteLine("Prize:\t$" + prize);
        Console.WriteLine("Category: " + category);
        Console.WriteLine("Available: " + available);
        Console.WriteLine("Sold: " + sold);


    }
}
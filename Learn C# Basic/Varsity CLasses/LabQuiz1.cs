class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the radius: ");
        double radius = double.Parse(Console.ReadLine()!);
        double pi = 3.1416;
        double circleArea = pi * radius * radius;
        Console.Write("The area of circle is: " + circleArea);

        Console.Write("\nEnter the Base: ");
        double base1 = double.Parse(Console.ReadLine()!);
        Console.Write("Enter the height: ");
        double height = double.Parse(Console.ReadLine()!);
        double triagnleArea = .5 * base1 * height;
        Console.Write("The area of triagnle: " + triagnleArea);
    }
}
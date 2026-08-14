class Student
{
    public string name = "";
    public uint id;
    public int age;
    public void Study()
    {
        Console.WriteLine($"{name} is studiyng...");
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name:{name}");
        Console.WriteLine($"ID:{id}");
        Console.WriteLine($"Age:{age}");
    }
}
class Program
{
    static void Main()
    {
        Student student1 = new();
        student1.name = "Md. Safin Mahmud";
        student1.id = 2252081107;
        student1.age = 20;

        student1.DisplayInfo();
        student1.Study();
    }
}

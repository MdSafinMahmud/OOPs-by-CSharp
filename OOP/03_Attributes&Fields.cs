using System;
class Student
{
    public string name = "";
    public int age;
    public void DisplayInfo()
    {
        Console.WriteLine($"Name:{name}");
        Console.WriteLine($"Age:{age}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new();
        Student s2 = new();
        Student s3 = new();
        Student s4 = new();

        s1.name = "Safin Mahmud";
        s1.age = 21;
        s2.name = "Shanto";
        s2.age = 22;
        s3.name = "Sadman";
        s3.age = 21;
        s4.name = "Hridoy";
        s4.age = 23;

        s1.DisplayInfo();
        s2.DisplayInfo();
        s3.DisplayInfo();
        s4.DisplayInfo();
    }
}
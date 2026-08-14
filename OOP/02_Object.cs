using System;

class Student
{
    public string name = "";
    public int age;

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new()
        {
            name = "Safin Mahmud",
            age = 20
        };

        s1.DisplayInfo();
    }
}
// Structure:

// Student Class
// ├── name
// ├── age
// └── DisplayInfo()

// Program Class
// └── Main()
//       ↓
//    Student Object
//       ↓
//      s1
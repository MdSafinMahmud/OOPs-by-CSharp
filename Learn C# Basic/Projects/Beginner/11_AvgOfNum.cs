using System;
using System.Data;
using System.Security.Cryptography;
class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nHow many numbers do you want to average? ");
            Console.WriteLine("1. 2 Numbers");
            Console.WriteLine("2. 3 Numbers");
            Console.WriteLine("3. 4 Numbers");
            Console.WriteLine("4. 5 Numbers");
            Console.WriteLine("5. 6 Numbers");
            Console.WriteLine("6. 7 Numbers");
            Console.WriteLine("7. 8 Numbers");
            Console.WriteLine("8. 9 Numbers");
            Console.WriteLine("9. 10 Numbers");
            Console.WriteLine("10. Close?");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine()!);
            if (choice == 10)
            {
                Console.WriteLine("Calculator Closed.\nGood bye!");
                return;
            }
            switch (choice)
            {
                case 1:
                    double x, y, avg;
                    Console.WriteLine("Enter the numbers: ");
                    x = double.Parse(Console.ReadLine()!);
                    y = double.Parse(Console.ReadLine()!);
                    avg = (x + y) / 2;
                    Console.Write("The average is: " + avg);
                    break;
                case 2:
                    double a, b, c, avg1;
                    Console.WriteLine("Enter the numbers: ");
                    a = double.Parse(Console.ReadLine()!);
                    b = double.Parse(Console.ReadLine()!);
                    c = double.Parse(Console.ReadLine()!);
                    avg1 = (a + b + c) / 3;
                    Console.Write("The average is: " + avg1);
                    break;

                case 3:
                    double d, e, f, g, avg2;
                    Console.WriteLine("Enter the numbers: ");
                    d = double.Parse(Console.ReadLine()!);
                    e = double.Parse(Console.ReadLine()!);
                    f = double.Parse(Console.ReadLine()!);
                    g = double.Parse(Console.ReadLine()!);
                    avg2 = (d + e + f + g) / 4;
                    Console.Write("The average is: " + avg2);
                    break;

                case 4:
                    double h, h1, j, k, l, m, avg3;
                    Console.WriteLine("Enter the numbers: ");
                    h = double.Parse(Console.ReadLine()!);
                    h1 = double.Parse(Console.ReadLine()!);
                    j = double.Parse(Console.ReadLine()!);
                    k = double.Parse(Console.ReadLine()!);
                    l = double.Parse(Console.ReadLine()!);
                    m = double.Parse(Console.ReadLine()!);
                    avg3 = (h + h1 + j + k + l + m) / 5;
                    Console.Write("The average is: " + avg3);
                    break;

                case 5:
                    double n, o, p, q, r, s, avg4;
                    Console.WriteLine("Enter the numbers: ");
                    n = double.Parse(Console.ReadLine()!);
                    o = double.Parse(Console.ReadLine()!);
                    p = double.Parse(Console.ReadLine()!);
                    q = double.Parse(Console.ReadLine()!);
                    r = double.Parse(Console.ReadLine()!);
                    s = double.Parse(Console.ReadLine()!);
                    avg4 = (n + o + p + q + r + s) / 6;
                    Console.Write("The average is: " + avg4);
                    break;

                case 6:
                    double t, u, v, w, x1, y1, z, avg5;
                    Console.WriteLine("Enter the numbers: ");
                    t = double.Parse(Console.ReadLine()!);
                    u = double.Parse(Console.ReadLine()!);
                    v = double.Parse(Console.ReadLine()!);
                    w = double.Parse(Console.ReadLine()!);
                    x1 = double.Parse(Console.ReadLine()!);
                    y1 = double.Parse(Console.ReadLine()!);
                    z = double.Parse(Console.ReadLine()!);
                    avg5 = (t + u + v + w + x1 + y1 + z) / 7;
                    Console.Write("The average is: " + avg5);
                    break;


                case 7:
                    double t1, u1, v1, w1, x2, y2, z1, a1, avg6;
                    Console.WriteLine("Enter the numbers: ");
                    t1 = double.Parse(Console.ReadLine()!);
                    u1 = double.Parse(Console.ReadLine()!);
                    v1 = double.Parse(Console.ReadLine()!);
                    w1 = double.Parse(Console.ReadLine()!);
                    x2 = double.Parse(Console.ReadLine()!);
                    y2 = double.Parse(Console.ReadLine()!);
                    z1 = double.Parse(Console.ReadLine()!);
                    a1 = double.Parse(Console.ReadLine()!);
                    avg6 = (t1 + u1 + v1 + w1 + x2 + y2 + z1 + a1) / 8;
                    Console.Write("The average is: " + avg6);
                    break;

                case 8:
                    double t2, u2, v2, w2, x3, y3, z2, a2, b1, avg7;
                    Console.WriteLine("Enter the numbers: ");
                    t2 = double.Parse(Console.ReadLine()!);
                    u2 = double.Parse(Console.ReadLine()!);
                    v2 = double.Parse(Console.ReadLine()!);
                    w2 = double.Parse(Console.ReadLine()!);
                    x3 = double.Parse(Console.ReadLine()!);
                    y3 = double.Parse(Console.ReadLine()!);
                    z2 = double.Parse(Console.ReadLine()!);
                    a2 = double.Parse(Console.ReadLine()!);
                    b1 = double.Parse(Console.ReadLine()!);
                    avg7 = (t2 + u2 + v2 + w2 + x3 + y3 + z2 + a2 + b1) / 9;
                    Console.Write("The average is: " + avg7);
                    break;

                case 9:
                    double t3, u3, v3, w3, x4, y4, z3, a3, b2, c1, avg8;
                    Console.WriteLine("Enter the numbers: ");
                    t3 = double.Parse(Console.ReadLine()!);
                    u3 = double.Parse(Console.ReadLine()!);
                    v3 = double.Parse(Console.ReadLine()!);
                    w3 = double.Parse(Console.ReadLine()!);
                    x4 = double.Parse(Console.ReadLine()!);
                    y4 = double.Parse(Console.ReadLine()!);
                    z3 = double.Parse(Console.ReadLine()!);
                    a3 = double.Parse(Console.ReadLine()!);
                    b2 = double.Parse(Console.ReadLine()!);
                    c1 = double.Parse(Console.ReadLine()!);
                    avg8 = (t3 + u3 + v3 + w3 + x4 + y4 + z3 + a3 + b2 + c1) / 10;
                    Console.Write("The average is: " + avg8);
                    break;
                default:
                    Console.WriteLine("Please Enter only numbers");
            }
        }
    }
}

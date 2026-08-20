using System;
using System.Collections.Generic;

interface IOrder // INTERFACE
{
    void PlaceOrder();
}

class Product : IOrder // PRODUCT CLASS
{
    private int id;
    private string name;
    private double price;

    protected string category;

    private static int productCount = 0;

    // Encapsulation - ID
    public int Id
    {
        get { return id; }
        set
        {
            if (value > 0)
                id = value;
            else
                id = 0;
        }
    }

    // Encapsulation - Name
    public string Name
    {
        get { return name; }
        set
        {
            name = value ?? "Unknown";
        }
    }

    // Encapsulation - Price
    public double Price
    {
        get { return price; }
        set
        {
            if (value >= 0)
                price = value;
            else
                price = 0;
        }
    }

    // Default Constructor
    public Product()
    {
        id = 0;
        name = "Unknown";
        price = 0;
        category = "General Product";
        productCount++;
    }

    // Constructor Overloading
    public Product(int id, string name, double price)
    {
        this.id = id;
        this.name = name ?? "Unknown";
        this.price = price >= 0 ? price : 0;
        category = "General Product";
        productCount++;
    }

    // Copy Constructor
    public Product(Product p)
    {
        id = p.id;
        name = p.name;
        price = p.price;
        category = p.category;
        productCount++;
    }

    // Method
    public void Display()
    {
        Console.WriteLine($"ID       : {Id}");
        Console.WriteLine($"Name     : {Name}");
        Console.WriteLine($"Price    : {Price} Tk");
    }

    // Method Overloading
    public void Display(string message)
    {
        Console.WriteLine(message);
        Display();
    }

    // Virtual Function
    public virtual void ShowCategory()
    {
        Console.WriteLine("Category : General Product");
    }

    // Static Method
    public static void ShowProductCount()
    {
        Console.WriteLine("Total Products Created: " + productCount);
    }

    // Interface Method
    public void PlaceOrder()
    {
        Console.WriteLine("Order placed successfully!");
    }

    // Destructor
    ~Product()
    {
    }
}


// ELECTRONICS
class Electronics : Product
{
    private int warranty;

    public int Warranty
    {
        get { return warranty; }
        set
        {
            warranty = value >= 0 ? value : 0;
        }
    }

    public Electronics(int id, string name, double price, int warranty)
        : base(id, name, price)
    {
        this.warranty = warranty >= 0 ? warranty : 0;
        category = "Electronics";
    }

    // Method Overriding
    public override void ShowCategory()
    {
        Console.WriteLine("Category : Electronics");
        Console.WriteLine($"Warranty : {Warranty} months");
    }
}


// CLOTHING
class Clothing : Product
{
    private string size;

    public string Size
    {
        get { return size; }
        set
        {
            size = value ?? "Unknown";
        }
    }

    public Clothing(int id, string name, double price, string size)
        : base(id, name, price)
    {
        this.size = size ?? "Unknown";
        category = "Clothing";
    }

    // Method Overriding
    public override void ShowCategory()
    {
        Console.WriteLine("Category : Clothing");
        Console.WriteLine("Size     : " + Size);
    }
}


// ABSTRACT PAYMENT CLASS
abstract class Payment
{
    public void PaymentMessage()
    {
        Console.WriteLine("Payment processing...");
    }

    public abstract void Pay();

    // Payment Name
    public abstract string GetPaymentMethod();
}


// CASH PAYMENT
class CashPayment : Payment
{
    public override void Pay()
    {
        Console.WriteLine("Payment completed by Cash.");
    }

    public override string GetPaymentMethod()
    {
        return "Cash";
    }
}


// CARD PAYMENT
class CardPayment : Payment
{
    public override void Pay()
    {
        Console.WriteLine("Payment completed by Card.");
    }

    public override string GetPaymentMethod()
    {
        return "Card";
    }
}


// MAIN PROGRAM
class Program
{
    static List<Product> products = new List<Product>();

    static void Main()
    {
        while (true)
        {
            Console.Clear();

            // Console.WriteLine("────────────────────────────");
            Console.WriteLine("◆ ONLINE SHOPPING MANAGEMENT");
            Console.WriteLine("────────────────────────────");

            Console.WriteLine("1. Add Electronics");
            Console.WriteLine("2. Add Clothing");
            Console.WriteLine("3. Show All Products");
            Console.WriteLine("4. Copy Product");
            Console.WriteLine("5. Buy Product");
            Console.WriteLine("6. Show Product Count");
            Console.WriteLine("7. Exit");

            Console.WriteLine("────────────────────────────");
            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("\nInvalid input! Please enter a number.");
                Pause();
                continue;
            }

            if (choice == 1)
                AddElectronics();

            else if (choice == 2)
                AddClothing();

            else if (choice == 3)
                ShowProducts();

            else if (choice == 4)
                CopyProduct();

            else if (choice == 5)
                BuyProduct();

            else if (choice == 6)
            {
                Product.ShowProductCount();
                Pause();
            }

            else if (choice == 7)
            {
                Console.WriteLine("\nHappy Shopping! See you Again...");
                break;
            }

            else
            {
                Console.WriteLine("\nInvalid choice!");
                Pause();
            }
        }
    }


    // ADD ELECTRONICS
    static void AddElectronics()
    {
        Console.Clear();

        Console.WriteLine("===== ADD ELECTRONICS =====\n");

        Console.Write("Enter Product ID: ");

        if (!int.TryParse(Console.ReadLine(), out int id) || id <= 0)
        {
            Console.WriteLine("Invalid Product ID!");
            Pause();
            return;
        }

        Console.Write("Enter Product Name: ");
        string name = Console.ReadLine() ?? "";

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Product name cannot be empty!");
            Pause();
            return;
        }

        Console.Write("Enter Price: ");

        if (!double.TryParse(Console.ReadLine(), out double price) || price < 0)
        {
            Console.WriteLine("Invalid Price!");
            Pause();
            return;
        }

        Console.Write("Enter Warranty (months): ");

        if (!int.TryParse(Console.ReadLine(), out int warranty) || warranty < 0)
        {
            Console.WriteLine("Invalid Warranty!");
            Pause();
            return;
        }

        Electronics e = new Electronics(id, name, price, warranty);

        products.Add(e);

        Console.WriteLine("\nElectronics added successfully!");

        Pause();
    }


    // ADD CLOTHING
    static void AddClothing()
    {
        Console.Clear();

        Console.WriteLine("===== ADD CLOTHING =====\n");

        Console.Write("Enter Product ID: ");

        if (!int.TryParse(Console.ReadLine(), out int id) || id <= 0)
        {
            Console.WriteLine("Invalid Product ID!");
            Pause();
            return;
        }

        Console.Write("Enter Product Name: ");
        string name = Console.ReadLine() ?? "";

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Product name cannot be empty!");
            Pause();
            return;
        }

        Console.Write("Enter Price: ");

        if (!double.TryParse(Console.ReadLine(), out double price) || price < 0)
        {
            Console.WriteLine("Invalid Price!");
            Pause();
            return;
        }

        Console.Write("Enter Size: ");
        string size = Console.ReadLine() ?? "";

        if (string.IsNullOrWhiteSpace(size))
        {
            Console.WriteLine("Size cannot be empty!");
            Pause();
            return;
        }

        Clothing c = new Clothing(id, name, price, size);

        products.Add(c);

        Console.WriteLine("\nClothing added successfully!");

        Pause();
    }


    // SHOW PRODUCTS
    static void ShowProducts()
    {
        Console.Clear();

        Console.WriteLine("===== ALL PRODUCTS =====\n");

        if (products.Count == 0)
        {
            Console.WriteLine("No products available.");
            Pause();
            return;
        }

        foreach (Product p in products)
        {
            Console.WriteLine("--------------------------");

            p.Display();

            // Polymorphism
            p.ShowCategory();
        }

        Console.WriteLine("--------------------------");

        Pause();
    }


    // COPY PRODUCT
    static void CopyProduct()
    {
        Console.Clear();

        Console.WriteLine("===== COPY PRODUCT =====\n");

        if (products.Count == 0)
        {
            Console.WriteLine("No products available.");
            Pause();
            return;
        }

        ShowProductsWithoutPause();

        Console.Write("\nEnter Product ID to copy: ");

        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Invalid Product ID!");
            Pause();
            return;
        }

        Product? selected = null;

        foreach (Product p in products)
        {
            if (p.Id == id)
            {
                selected = p;
                break;
            }
        }

        if (selected != null)
        {
            // Copy Constructor
            Product copy = new Product(selected);

            Console.WriteLine("\nCopied Product:");
            copy.Display();
            copy.ShowCategory();
        }
        else
        {
            Console.WriteLine("\nProduct not found!");
        }

        Pause();
    }

    // BUY PRODUCT
    static void BuyProduct()
    {
        Console.Clear();

        Console.WriteLine("===== BUY PRODUCT =====\n");

        if (products.Count == 0)
        {
            Console.WriteLine("No products available.");
            Pause();
            return;
        }

        ShowProductsWithoutPause();

        Console.Write("\nEnter Product ID to buy: ");

        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Invalid Product ID!");
            Pause();
            return;
        }

        Product? selected = null;

        foreach (Product p in products)
        {
            if (p.Id == id)
            {
                selected = p;
                break;
            }
        }

        if (selected == null)
        {
            Console.WriteLine("\nProduct not found!");
            Pause();
            return;
        }

        Console.WriteLine("\nSelected Product:");
        selected.Display();

        Console.WriteLine("\n===== PAYMENT METHOD =====");
        Console.WriteLine("1. Cash");
        Console.WriteLine("2. Card");

        Console.Write("Enter choice: ");

        if (!int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.WriteLine("Invalid payment choice!");
            Pause();
            return;
        }

        Payment payment;

        // Polymorphism
        if (choice == 1)
        {
            payment = new CashPayment();
        }
        else if (choice == 2)
        {
            payment = new CardPayment();
        }
        else
        {
            Console.WriteLine("Invalid payment method!");
            Pause();
            return;
        }

        // Payment
        payment.PaymentMessage();
        payment.Pay();

        // Interface
        selected.PlaceOrder();

        // Invoice
        ShowInvoice(selected, payment);

        Pause();
    }


    // INVOICE
    static void ShowInvoice(Product p, Payment payment)
    {
        Console.WriteLine("\n");
        Console.WriteLine("────────────────────────────");
        Console.WriteLine("      SHOPPING INVOICE");
        Console.WriteLine("────────────────────────────");

        Console.WriteLine($"Product ID    : {p.Id}");
        Console.WriteLine($"Product Name  : {p.Name}");

        if (p is Electronics e)
        {
            Console.WriteLine("Category      : Electronics");
            Console.WriteLine("Warranty      : " + e.Warranty + " months");
        }
        else if (p is Clothing c)
        {
            Console.WriteLine("Category      : Clothing");
            Console.WriteLine("Size          : " + c.Size);
        }

        Console.WriteLine("────────────────────────────");

        Console.WriteLine("Price         : " + p.Price + " Tk");
        Console.WriteLine("Payment       : " + payment.GetPaymentMethod());

        Console.WriteLine("────────────────────────────");

        Console.WriteLine("Total Amount  : " + p.Price + " Tk");

        Console.WriteLine("────────────────────────────");
        Console.WriteLine("   THANK YOU FOR SHOPPING!");
        Console.WriteLine("────────────────────────────");
    }


    // SHOW PRODUCTS WITHOUT PAUSE
    static void ShowProductsWithoutPause()
    {
        foreach (Product p in products)
        {
            Console.WriteLine("--------------------------");

            p.Display();
            p.ShowCategory();
        }
    }


    // PAUSE
    static void Pause()
    {
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }
}
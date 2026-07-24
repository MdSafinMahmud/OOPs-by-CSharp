using System;

class Member
{
    private readonly int membershipId;
    private readonly string memberName;
    private double fine;
    private readonly string bookReturnTime;
    private static int totalBooks = 0;

    public Member(int membershipId, string memberName, double fine, string bookReturnTime)
    {
        this.membershipId = membershipId;
        this.memberName = memberName;
        this.fine = fine;
        this.bookReturnTime = bookReturnTime;

        totalBooks++;
    }

    public Member(Member existingMember)
    {
        this.membershipId = existingMember.membershipId;
        this.memberName = existingMember.memberName;
        this.fine = existingMember.fine;
        this.bookReturnTime = existingMember.bookReturnTime;

        totalBooks++;
    }
  
    public double GetFine()
    {
        return fine;
    }

    public void PayFine(double amount)
    {
        fine -= amount;

      
        if (fine < 0)
        {
            fine = 0;
        }
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Membership ID: {membershipId}");
        Console.WriteLine($"Member Name:{memberName} ");
        Console.WriteLine($"Fine:{fine} " );
        Console.WriteLine($"Book Return Time:{bookReturnTime}\n" );
    }

    public static void DisplayTotalBooks()
    {
        Console.WriteLine($"Total Number of Books:{totalBooks}" );
    }

    public static void LibraryName()
    {
        Console.WriteLine("Library Name: Central Public Library");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Member.LibraryName();
        Console.WriteLine();
        Member member1 = new(
            101,
            "Md. Safin Mahmud",
            500,
            "10:00 AM"
        );
       
        Member member2 = new(
            102,
            "Rahim Mahmud",
            300,
            "11:30 AM"
        );
       
        Member member3 = new(member1);

     
        Console.WriteLine("Member 1 Details:");
        member1.DisplayDetails();
        Console.WriteLine("Member 2 Details:");
        member2.DisplayDetails();
        Console.WriteLine("Member 3 Details (Copied from Member 1):");
        member3.DisplayDetails();
         Console.WriteLine($"Member 1 Current Fine:{member1.GetFine()}" );
        member1.PayFine(200);
        Console.WriteLine($"Member 1 Fine After Paying 200:{member1.GetFine()} ");
        Member.DisplayTotalBooks();
    }
}
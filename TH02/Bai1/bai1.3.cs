using System;

class Person
{
    // Data members
    private int id;
    private string name;
    private int yob;
    private int yod;

    // Default Constructor
    public Person()
    {
        id = 0;
        name = "";
        yob = 0;
        yod = 0;
    }

    // Copy Constructor
    public Person(Person p)
    {
        id = p.id;
        name = p.name;
        yob = p.yob;
        yod = p.yod;
    }

    // Input
    public void Input()
    {
        Console.Write("Nhap ID: ");
        id = int.Parse(Console.ReadLine());

        Console.Write("Nhap ten: ");
        name = Console.ReadLine();

        Console.Write("Nhap nam sinh: ");
        yob = int.Parse(Console.ReadLine());

        Console.Write("Nhap nam mat (0 neu con song): ");
        yod = int.Parse(Console.ReadLine());
    }

    // Output
    public void Output()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Nam sinh: " + yob);
        Console.WriteLine("Nam mat: " + yod);
    }

    // Kiem tra con song
    public bool IsLiving()
    {
        return yod == 0;
    }
}

class Program
{
    static void Main()
    {
        // Tao Person va nhap thong tin
        Person p1 = new Person();

        Console.WriteLine("NHAP THONG TIN PERSON");
        p1.Input();

        // Xuat thong tin
        Console.WriteLine("\nTHONG TIN PERSON");
        p1.Output();

        // Kiem tra con song
        if (p1.IsLiving())
        {
            Console.WriteLine("Trang thai: Con song");
        }
        else
        {
            Console.WriteLine("Trang thai: Da mat");
        }

        // Test Copy Constructor
        Person p2 = new Person(p1);

        Console.WriteLine("\nPERSON COPY");
        p2.Output();
    }
}
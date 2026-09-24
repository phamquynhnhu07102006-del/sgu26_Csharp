using System;

class DaySo
{
    private int[] a;
    private int n;

    // a. Default Constructor
    public DaySo()
    {
        n = 0;
        a = new int[0];
    }

    // Constructor có tham số
    public DaySo(int n)
    {
        this.n = n;
        a = new int[n];
    }

    // Copy Constructor
    public DaySo(DaySo d)
    {
        n = d.n;
        a = new int[n];

        for (int i = 0; i < n; i++)
        {
            a[i] = d.a[i];
        }
    }

    // b. Indexer
    public int this[int i]
    {
        get
        {
            return a[i];
        }
        set
        {
            a[i] = value;
        }
    }

    // c. Nhập dãy số
    public void Input()
    {
        Console.Write("Nhap so luong phan tu n = ");
        n = int.Parse(Console.ReadLine());

        a = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("a[" + i + "] = ");
            a[i] = int.Parse(Console.ReadLine());
        }
    }

    // Xuất dãy số
    public void Output()
    {
        Console.Write("Day so: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }

        Console.WriteLine();
    }

    // d. Tìm các số chẵn
    public void TimSoChan()
    {
        Console.Write("Cac so chan: ");

        for (int i = 0; i < n; i++)
        {
            if (a[i] % 2 == 0)
            {
                Console.Write(a[i] + " ");
            }
        }

        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        DaySo ds = new DaySo();

        // Nhập dãy
        ds.Input();

        // Xuất dãy
        ds.Output();

        // Tìm số chẵn
        ds.TimSoChan();

        // Test Indexer
        Console.WriteLine("Phan tu thu 2: " + ds[1]);
    }
}
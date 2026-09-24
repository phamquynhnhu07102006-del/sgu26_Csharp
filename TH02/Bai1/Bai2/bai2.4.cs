using System;

class MangHaiChieu
{
    private int[,] a;
    private int n, m;

    // a. Default Constructor
    public MangHaiChieu()
    {
        n = 0;
        m = 0;
        a = new int[0, 0];
    }

    // Constructor co tham so
    public MangHaiChieu(int n, int m)
    {
        this.n = n;
        this.m = m;
        a = new int[n, m];
    }

    // Copy Constructor
    public MangHaiChieu(MangHaiChieu x)
    {
        n = x.n;
        m = x.m;
        a = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                a[i, j] = x.a[i, j];
            }
        }
    }

    // b. Indexer
    public int this[int i, int j]
    {
        get
        {
            return a[i, j];
        }
        set
        {
            a[i, j] = value;
        }
    }

    // c. Nhap
    public void Input()
    {
        Console.Write("Nhap so dong n = ");
        n = int.Parse(Console.ReadLine());

        Console.Write("Nhap so cot m = ");
        m = int.Parse(Console.ReadLine());

        a = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("a[" + i + "," + j + "] = ");
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    // Xuat
    public void Output()
    {
        Console.WriteLine("\nMa tran:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(a[i, j] + "\t");
            }

            Console.WriteLine();
        }
    }

    // d. Kiem tra so nguyen to
    private bool LaSoNguyenTo(int x)
    {
        if (x < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(x); i++)
        {
            if (x % i == 0)
                return false;
        }

        return true;
    }

    // Tim cac so nguyen to
    public void TimSoNguyenTo()
    {
        Console.Write("Cac so nguyen to: ");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (LaSoNguyenTo(a[i, j]))
                {
                    Console.Write(a[i, j] + " ");
                }
            }
        }

        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        MangHaiChieu a = new MangHaiChieu();

        // Nhap
        a.Input();

        // Xuat
        a.Output();

        // Tim so nguyen to
        a.TimSoNguyenTo();

        // Test Indexer
        Console.WriteLine("\nPhan tu a[0,0] = " + a[0, 0]);
    }
}
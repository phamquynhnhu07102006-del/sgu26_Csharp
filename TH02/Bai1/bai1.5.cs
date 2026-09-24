using System;

class DonThuc
{
    // Field
    private double a;
    private int n;

    // Constructor mac nhien
    public DonThuc()
    {
        a = 0;
        n = 0;
    }

    // Constructor khoi tao
    public DonThuc(double a, int n)
    {
        if (n < 0)
            throw new ArgumentException("So mu n phai >= 0!");

        this.a = a;
        this.n = n;
    }

    // Tinh gia tri P(x) = a*x^n
    public double GiaTri(double x)
    {
        return a * Math.Pow(x, n);
    }

    // Dao ham
    public DonThuc DaoHam()
    {
        // Neu n = 0 thi P(x) = a, dao ham = 0
        if (n == 0)
            return new DonThuc(0, 0);

        return new DonThuc(a * n, n - 1);
    }

    // Xuat don thuc
    public override string ToString()
    {
        if (a == 0)
            return "0";

        if (n == 0)
            return a.ToString();

        if (n == 1)
            return a + "x";

        return a + "x^" + n;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Nhap he so a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhap so mu n: ");
        int n = int.Parse(Console.ReadLine());

        DonThuc P = new DonThuc(a, n);

        Console.WriteLine("\nDon thuc P(x) = " + P);

        // (a) Tinh gia tri
        Console.Write("\nNhap x: ");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("P(" + x + ") = " + P.GiaTri(x));

        // (b) Dao ham
        DonThuc Q = P.DaoHam();

        Console.WriteLine("P'(x) = " + Q);
    }
}
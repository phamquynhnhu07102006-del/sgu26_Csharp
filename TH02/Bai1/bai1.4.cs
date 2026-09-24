using System;

class PhanSo
{
    private int tu;
    private int mau;

    // Constructor mac nhien
    public PhanSo()
    {
        tu = 0;
        mau = 1;
    }

    // Constructor khoi tao tu va mau
    public PhanSo(int tu, int mau)
    {
        if (mau == 0)
            throw new ArgumentException("Mau so phai khac 0!");

        this.tu = tu;
        this.mau = mau;

        RutGon();
    }

    // Constructor chi co tu
    public PhanSo(int tu)
    {
        this.tu = tu;
        this.mau = 1;
    }

    // Copy Constructor
    public PhanSo(PhanSo p)
    {
        tu = p.tu;
        mau = p.mau;
    }

    // Tim UCLN
    private int UCLN(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);

        while (b != 0)
        {
            int temp = a % b;
            a = b;
            b = temp;
        }

        return a;
    }

    // Rut gon phan so
    private void RutGon()
    {
        int ucln = UCLN(tu, mau);

        tu /= ucln;
        mau /= ucln;

        // Dua dau am len tu
        if (mau < 0)
        {
            tu = -tu;
            mau = -mau;
        }
    }

    // Override ToString
    public override string ToString()
    {
        if (mau == 1)
            return tu.ToString();

        return tu + "/" + mau;
    }

    // ==========================================
    // TOAN TU MOT NGOI
    // ==========================================

    // +A
    public static PhanSo operator +(PhanSo p)
    {
        return new PhanSo(p.tu, p.mau);
    }

    // -A
    public static PhanSo operator -(PhanSo p)
    {
        return new PhanSo(-p.tu, p.mau);
    }

    // ==========================================
    // TOAN TU HAI NGOI
    // ==========================================

    // A + B
    public static PhanSo operator +(PhanSo a, PhanSo b)
    {
        return new PhanSo(
            a.tu * b.mau + b.tu * a.mau,
            a.mau * b.mau
        );
    }

    // A - B
    public static PhanSo operator -(PhanSo a, PhanSo b)
    {
        return new PhanSo(
            a.tu * b.mau - b.tu * a.mau,
            a.mau * b.mau
        );
    }

    // A * B
    public static PhanSo operator *(PhanSo a, PhanSo b)
    {
        return new PhanSo(
            a.tu * b.tu,
            a.mau * b.mau
        );
    }

    // A / B
    public static PhanSo operator /(PhanSo a, PhanSo b)
    {
        if (b.tu == 0)
            throw new DivideByZeroException("Khong the chia cho 0!");

        return new PhanSo(
            a.tu * b.mau,
            a.mau * b.tu
        );
    }

    // ==========================================
    // TOAN TU SO SANH
    // ==========================================

    // A > B
    public static bool operator >(PhanSo a, PhanSo b)
    {
        return a.tu * b.mau > b.tu * a.mau;
    }

    // A < B
    public static bool operator <(PhanSo a, PhanSo b)
    {
        return a.tu * b.mau < b.tu * a.mau;
    }

    // A >= B
    public static bool operator >=(PhanSo a, PhanSo b)
    {
        return a.tu * b.mau >= b.tu * a.mau;
    }

    // A <= B
    public static bool operator <=(PhanSo a, PhanSo b)
    {
        return a.tu * b.mau <= b.tu * a.mau;
    }

    // A == B
    public static bool operator ==(PhanSo a, PhanSo b)
    {
        if (ReferenceEquals(a, b))
            return true;

        if (a is null || b is null)
            return false;

        return a.tu * b.mau == b.tu * a.mau;
    }

    // A != B
    public static bool operator !=(PhanSo a, PhanSo b)
    {
        return !(a == b);
    }

    public override bool Equals(object obj)
    {
        if (obj is not PhanSo)
            return false;

        return this == (PhanSo)obj;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(tu, mau);
    }
}

class Program
{
    static void Main()
    {
        PhanSo A = new PhanSo(1, 2);
        PhanSo B = new PhanSo(2, 3);

        Console.WriteLine("A = " + A);
        Console.WriteLine("B = " + B);

        // Toan tu mot ngoi
        Console.WriteLine("\n+A = " + (+A));
        Console.WriteLine("-A = " + (-A));

        // Toan tu hai ngoi
        Console.WriteLine("\nA + B = " + (A + B));
        Console.WriteLine("A - B = " + (A - B));
        Console.WriteLine("A * B = " + (A * B));
        Console.WriteLine("A / B = " + (A / B));

        // So sanh
        Console.WriteLine("\nA > B  : " + (A > B));
        Console.WriteLine("A < B  : " + (A < B));
        Console.WriteLine("A >= B : " + (A >= B));
        Console.WriteLine("A <= B : " + (A <= B));
        Console.WriteLine("A == B : " + (A == B));
        Console.WriteLine("A != B : " + (A != B));

        // Copy Constructor
        PhanSo C = new PhanSo(A);
        Console.WriteLine("\nC (copy A) = " + C);
    }
}
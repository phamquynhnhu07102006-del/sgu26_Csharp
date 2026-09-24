using System;

class Point
{
    // Field
    private double x;
    private double y;

    // Property
    public double X
    {
        get { return x; }
        set { x = value; }
    }

    public double Y
    {
        get { return y; }
        set { y = value; }
    }

    // Default constructor
    public Point()
    {
        x = 0;
        y = 0;
    }

    // Constructor co tham so
    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    // Nhap toa do
    public void Input()
    {
        Console.Write("Nhap x: ");
        x = double.Parse(Console.ReadLine());

        Console.Write("Nhap y: ");
        y = double.Parse(Console.ReadLine());
    }

    // Xuat toa do
    public void Output()
    {
        Console.WriteLine("(" + x + ", " + y + ")");
    }

    // Override ToString()
    public override string ToString()
    {
        return "(" + x + ", " + y + ")";
    }

    // Phep cong 2 Point
    public static Point operator +(Point A, Point B)
    {
        return new Point(A.x + B.x, A.y + B.y);
    }

    // Phep tru 2 Point
    public static Point operator -(Point A, Point B)
    {
        return new Point(A.x - B.x, A.y - B.y);
    }

    // Lay am Point
    public static Point operator -(Point A)
    {
        return new Point(-A.x, -A.y);
    }

    // ==================================================
    // (a) Khoang cach - Phuong thuc thanh vien
    // ==================================================
    public double Distance(Point B)
    {
        double dx = x - B.x;
        double dy = y - B.y;

        return Math.Sqrt(dx * dx + dy * dy);
    }

    // ==================================================
    // (a) Khoang cach - Phuong thuc tinh
    // ==================================================
    public static double Distance(Point A, Point B)
    {
        double dx = A.x - B.x;
        double dy = A.y - B.y;

        return Math.Sqrt(dx * dx + dy * dy);
    }

    // ==================================================
    // (b) Trung diem - Phuong thuc thanh vien
    // ==================================================
    public Point MidPoint(Point B)
    {
        return new Point(
            (x + B.x) / 2,
            (y + B.y) / 2
        );
    }

    // ==================================================
    // (b) Trung diem - Phuong thuc tinh
    // ==================================================
    public static Point MidPoint(Point A, Point B)
    {
        return new Point(
            (A.x + B.x) / 2,
            (A.y + B.y) / 2
        );
    }
}

class Program
{
    static void Main()
    {
        // Nhap diem A
        Console.WriteLine("Nhap diem A:");
        Point A = new Point();
        A.Input();

        // Nhap diem B
        Console.WriteLine("\nNhap diem B:");
        Point B = new Point();
        B.Input();

        Console.WriteLine("\n--- THONG TIN ---");

        Console.WriteLine("A = " + A);
        Console.WriteLine("B = " + B);

        // (a) Khoang cach bang phuong thuc thanh vien
        double d1 = A.Distance(B);
        Console.WriteLine("\nKhoang cach AB (thanh vien): " + d1);

        // (a) Khoang cach bang phuong thuc tinh
        double d2 = Point.Distance(A, B);
        Console.WriteLine("Khoang cach AB (tinh): " + d2);

        // (b) Trung diem bang phuong thuc thanh vien
        Point I1 = A.MidPoint(B);
        Console.WriteLine("\nTrung diem I (thanh vien): " + I1);

        // (b) Trung diem bang phuong thuc tinh
        Point I2 = Point.MidPoint(A, B);
        Console.WriteLine("Trung diem I (tinh): " + I2);

        // Thu phep cong
        Point C = A + B;
        Console.WriteLine("\nA + B = " + C);

        // Thu phep tru
        Point D = A - B;
        Console.WriteLine("A - B = " + D);

        // Thu lay am
        Point E = -A;
        Console.WriteLine("-A = " + E);
    }
}
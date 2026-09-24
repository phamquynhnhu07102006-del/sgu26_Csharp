using System;
using System.Collections;

class Point
{
    private double x;
    private double y;

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

    public Point()
    {
        x = 0;
        y = 0;
    }

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return "(" + x + ", " + y + ")";
    }
}

class ArrayPoint
{
    // Field: ArrayList luu cac Point
    private ArrayList dsPoint;

    // Constructor
    public ArrayPoint()
    {
        dsPoint = new ArrayList();
    }

    // Them Point vao danh sach
    public void Add(Point p)
    {
        dsPoint.Add(p);
    }

    // Indexer
    public Point this[int i]
    {
        get
        {
            return (Point)dsPoint[i];
        }

        set
        {
            dsPoint[i] = value;
        }
    }

    // So luong Point
    public int Count
    {
        get { return dsPoint.Count; }
    }
}

class Program
{
    static void Main()
    {
        ArrayPoint arr = new ArrayPoint();

        // Them cac Point
        arr.Add(new Point(1, 2));
        arr.Add(new Point(3, 4));
        arr.Add(new Point(5, 6));

        // Truy cap Point bang Indexer
        Console.WriteLine("Danh sach Point:");

        for (int i = 0; i < arr.Count; i++)
        {
            Console.WriteLine("Point[" + i + "] = " + arr[i]);
        }

        // Thay doi Point thu 1
        arr[1] = new Point(10, 20);

        Console.WriteLine("\nSau khi thay doi Point[1]:");

        for (int i = 0; i < arr.Count; i++)
        {
            Console.WriteLine("Point[" + i + "] = " + arr[i]);
        }
    }
}
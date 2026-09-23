using System;

class TimMinMax
{
    public void TimMinMaxBaSo(double a, double b, double c, out double min, out double max)
    {
        min = a;
        max = a;

        if (b < min)
            min = b;

        if (c < min)
            min = c;

        if (b > max)
            max = b;

        if (c > max)
            max = c;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Nhap a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhap b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Nhap c: ");
        double c = double.Parse(Console.ReadLine());

        TimMinMax t = new TimMinMax();

        double min, max;

        t.TimMinMaxBaSo(a, b, c, out min, out max);

        Console.WriteLine("Gia tri nho nhat: " + min);
        Console.WriteLine("Gia tri lon nhat: " + max);
    }
}
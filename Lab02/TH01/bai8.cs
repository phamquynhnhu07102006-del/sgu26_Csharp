using System;

class HoanVi
{
    public void HoanViHaiSo(ref double a, ref double b)
    {
        double temp = a;
        a = b;
        b = temp;
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

        Console.WriteLine("Truoc khi hoan vi: a = " + a + ", b = " + b);

        HoanVi hv = new HoanVi();

        hv.HoanViHaiSo(ref a, ref b);

        Console.WriteLine("Sau khi hoan vi: a = " + a + ", b = " + b);
    }
}
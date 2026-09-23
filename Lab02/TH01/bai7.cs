using System;

class KiemTraSoNguyenTo
{
    public bool LaSoNguyenTo(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        KiemTraSoNguyenTo kt = new KiemTraSoNguyenTo();

        bool ketQua = kt.LaSoNguyenTo(n);

        if (ketQua)
            Console.WriteLine(n + " la so nguyen to.");
        else
            Console.WriteLine(n + " khong phai la so nguyen to.");
    }
}
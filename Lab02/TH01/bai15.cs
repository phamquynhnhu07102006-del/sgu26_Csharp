using System;
using System.Collections.Generic;

class MangSoNguyen
{
    private int[] a;
    private int n;

    // Nhap mang
    public void Nhap()
    {
        Console.Write("Nhap n: ");
        n = int.Parse(Console.ReadLine());

        a = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("a[" + i + "] = ");
            a[i] = int.Parse(Console.ReadLine());
        }
    }

    // In mang
    public void Xuat()
    {
        Console.Write("Mang: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }

        Console.WriteLine();
    }

    // Tim phan tu lon nhat
    public int TimMax()
    {
        int max = a[0];

        for (int i = 1; i < n; i++)
        {
            if (a[i] > max)
                max = a[i];
        }

        return max;
    }

    // Tim phan tu nho nhat
    public int TimMin()
    {
        int min = a[0];

        for (int i = 1; i < n; i++)
        {
            if (a[i] < min)
                min = a[i];
        }

        return min;
    }

    // Kiem tra so nguyen to
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

    // Tra ve mang cac so nguyen to
    public int[] LayMangSoNguyenTo()
    {
        List<int> ketQua = new List<int>();

        for (int i = 0; i < n; i++)
        {
            if (LaSoNguyenTo(a[i]))
            {
                ketQua.Add(a[i]);
            }
        }

        return ketQua.ToArray();
    }
}

class Program
{
    static void Main()
    {
        MangSoNguyen mang = new MangSoNguyen();

        mang.Nhap();
        mang.Xuat();

        Console.WriteLine("Phan tu lon nhat: " + mang.TimMax());
        Console.WriteLine("Phan tu nho nhat: " + mang.TimMin());

        int[] soNguyenTo = mang.LayMangSoNguyenTo();

        Console.Write("Cac so nguyen to: ");

        if (soNguyenTo.Length == 0)
        {
            Console.WriteLine("Khong co");
        }
        else
        {
            for (int i = 0; i < soNguyenTo.Length; i++)
            {
                Console.Write(soNguyenTo[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
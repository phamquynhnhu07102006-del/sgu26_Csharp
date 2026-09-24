using System;
using System.Collections.Generic;

class MangHaiChieu
{
    private int[,] A;
    private int n, m;

    // Sinh ngau nhien mang
    public void SinhMang()
    {
        Console.Write("Nhap n: ");
        n = int.Parse(Console.ReadLine());

        Console.Write("Nhap m: ");
        m = int.Parse(Console.ReadLine());

        A = new int[n, m];

        Random rd = new Random();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                A[i, j] = rd.Next(10, 101);
            }
        }
    }

    // In mang
    public void Xuat()
    {
        Console.WriteLine("\nMang A:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(A[i, j] + "\t");
            }

            Console.WriteLine();
        }
    }

    // Tra ve mang cac so chan
    public int[] LaySoChan()
    {
        List<int> soChan = new List<int>();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] % 2 == 0)
                {
                    soChan.Add(A[i, j]);
                }
            }
        }

        return soChan.ToArray();
    }

    // Tra ve mang cac so le
    public int[] LaySoLe()
    {
        List<int> soLe = new List<int>();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] % 2 != 0)
                {
                    soLe.Add(A[i, j]);
                }
            }
        }

        return soLe.ToArray();
    }
}

class Program
{
    static void Main()
    {
        MangHaiChieu mang = new MangHaiChieu();

        mang.SinhMang();
        mang.Xuat();

        int[] soChan = mang.LaySoChan();
        int[] soLe = mang.LaySoLe();

        Console.Write("\nMang so chan: ");
        foreach (int x in soChan)
        {
            Console.Write(x + " ");
        }

        Console.Write("\nMang so le: ");
        foreach (int x in soLe)
        {
            Console.Write(x + " ");
        }

        Console.WriteLine();
    }
}
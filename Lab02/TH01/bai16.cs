using System;

class DanhSachHoTen
{
    private string[] a;
    private int n;

    // Nhap danh sach ho ten
    public void Nhap()
    {
        Console.Write("Nhap so nguoi n: ");
        n = int.Parse(Console.ReadLine());

        a = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap ho ten nguoi thu " + (i + 1) + ": ");
            a[i] = Console.ReadLine();
        }
    }

    // Sap xep tang dan
    public void SapXepTangDan()
    {
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (string.Compare(a[i], a[j]) > 0)
                {
                    string temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }
    }

    // Xuat danh sach
    public void Xuat()
    {
        Console.WriteLine("\nDanh sach sau khi sap xep:");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        DanhSachHoTen ds = new DanhSachHoTen();

        ds.Nhap();

        Console.WriteLine("\nTruoc khi sap xep:");
        ds.Xuat();

        ds.SapXepTangDan();

        ds.Xuat();
    }
}
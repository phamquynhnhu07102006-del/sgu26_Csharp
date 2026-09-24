using System;

class SinhVien
{
    private string hoTen;
    private int namSinh;

    public void Nhap()
    {
        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine();

        Console.Write("Nhap nam sinh: ");
        namSinh = int.Parse(Console.ReadLine());
    }

    public int TinhTuoi()
    {
        return 2026 - namSinh;
    }

    public void Xuat()
    {
        Console.WriteLine("\n--- THONG TIN SINH VIEN ---");
        Console.WriteLine("Ho ten: " + hoTen);
        Console.WriteLine("Nam sinh: " + namSinh);
        Console.WriteLine("Tuoi: " + TinhTuoi());
    }
}

class Program
{
    static void Main()
    {
        SinhVien sv = new SinhVien();

        sv.Nhap();
        sv.Xuat();
    }
}
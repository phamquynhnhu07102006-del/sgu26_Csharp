using System;

class NhanVien
{
    private string hoTen;
    private double mucLuong;
    private int soNgayVang;

    public void Nhap()
    {
        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine();

        Console.Write("Nhap muc luong: ");
        mucLuong = double.Parse(Console.ReadLine());

        Console.Write("Nhap so ngay vang: ");
        soNgayVang = int.Parse(Console.ReadLine());
    }

    public double TinhLuong()
    {
        return mucLuong - soNgayVang * 100000;
    }

    public void Xuat()
    {
        Console.WriteLine("\n--- THONG TIN NHAN VIEN ---");
        Console.WriteLine("Ho ten: " + hoTen);
        Console.WriteLine("Muc luong: " + mucLuong.ToString("N0") + " VNĐ");
        Console.WriteLine("So ngay vang: " + soNgayVang);
        Console.WriteLine("Luong thuc nhan: " + TinhLuong().ToString("N0") + " VNĐ");
    }
}

class Program
{
    static void Main()
    {
        NhanVien nv = new NhanVien();

        nv.Nhap();
        nv.Xuat();
    }
}
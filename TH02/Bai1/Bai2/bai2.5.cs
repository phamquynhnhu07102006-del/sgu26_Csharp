using System;

class NhanVien
{
    private string hoTen;
    private double mucLuong;
    private int soNgayVang;

    public NhanVien()
    {
        hoTen = "";
        mucLuong = 0;
        soNgayVang = 0;
    }

    public void Input()
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

    public void Output()
    {
        Console.WriteLine("Ho ten: " + hoTen);
        Console.WriteLine("Muc luong: " + mucLuong);
        Console.WriteLine("So ngay vang: " + soNgayVang);
        Console.WriteLine("Luong thuc nhan: " + TinhLuong());
    }
}

class PhongBan
{
    private NhanVien[] ds;
    private int n;

    public PhongBan()
    {
        n = 0;
        ds = new NhanVien[0];
    }

    public void Input()
    {
        Console.Write("Nhap so luong nhan vien n = ");
        n = int.Parse(Console.ReadLine());

        ds = new NhanVien[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nNhap nhan vien thu " + (i + 1) + ":");
            ds[i] = new NhanVien();
            ds[i].Input();
        }
    }

    public void Output()
    {
        Console.WriteLine("\n--- DANH SACH NHAN VIEN ---");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nNhan vien thu " + (i + 1) + ":");
            ds[i].Output();
        }
    }

    public double TongLuong()
    {
        double tong = 0;

        for (int i = 0; i < n; i++)
        {
            tong += ds[i].TinhLuong();
        }

        return tong;
    }
}

class Program
{
    static void Main()
    {
        PhongBan pb = new PhongBan();

        pb.Input();
        pb.Output();

        Console.WriteLine("\nTong luong cua phong ban: " + pb.TongLuong() + " VNĐ");
    }
}
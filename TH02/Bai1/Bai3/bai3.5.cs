using System;

class NhanVien
{
    protected string maNV;
    protected string hoTen;

    public NhanVien(string maNV, string hoTen)
    {
        this.maNV = maNV;
        this.hoTen = hoTen;
    }

    public virtual double TinhLuong()
    {
        return 0;
    }

    public virtual void Xuat()
    {
        Console.WriteLine("Ma NV: " + maNV);
        Console.WriteLine("Ho ten: " + hoTen);
    }
}

class NhanVienKinhDoanh : NhanVien
{
    private double luongCoBan;
    private int soHopDong;

    public NhanVienKinhDoanh(
        string maNV,
        string hoTen,
        double luongCoBan,
        int soHopDong) : base(maNV, hoTen)
    {
        this.luongCoBan = luongCoBan;
        this.soHopDong = soHopDong;
    }

    public override double TinhLuong()
    {
        return luongCoBan + soHopDong * 500000;
    }

    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine("Loai: Nhan vien kinh doanh");
        Console.WriteLine("Luong co ban: " + luongCoBan);
        Console.WriteLine("So hop dong: " + soHopDong);
        Console.WriteLine("Luong: " + TinhLuong());
    }
}

class NhanVienSanXuat : NhanVien
{
    private int soSanPham;

    public NhanVienSanXuat(
        string maNV,
        string hoTen,
        int soSanPham) : base(maNV, hoTen)
    {
        this.soSanPham = soSanPham;
    }

    public override double TinhLuong()
    {
        double luong = soSanPham * 1000;

        if (soSanPham > 3000)
        {
            luong = luong * 1.05;
        }

        return luong;
    }

    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine("Loai: Nhan vien san xuat");
        Console.WriteLine("So san pham: " + soSanPham);
        Console.WriteLine("Luong: " + TinhLuong());
    }
}

class Program
{
    static void Main()
    {
        NhanVien[] ds = new NhanVien[4];

        ds[0] = new NhanVienKinhDoanh(
            "KD01", "Nguyen Van A", 10000000, 5);

        ds[1] = new NhanVienKinhDoanh(
            "KD02", "Tran Thi B", 12000000, 3);

        ds[2] = new NhanVienSanXuat(
            "SX01", "Le Van C", 2500);

        ds[3] = new NhanVienSanXuat(
            "SX02", "Pham Van D", 4000);

        Console.WriteLine("===== DANH SACH NHAN VIEN =====");

        for (int i = 0; i < ds.Length; i++)
        {
            Console.WriteLine("\nNhan vien thu " + (i + 1));
            ds[i].Xuat();
        }

        double tongLuong = 0;

        for (int i = 0; i < ds.Length; i++)
        {
            tongLuong += ds[i].TinhLuong();
        }

        Console.WriteLine("\nTong luong cong ty: " + tongLuong + " VNĐ");
    }
}
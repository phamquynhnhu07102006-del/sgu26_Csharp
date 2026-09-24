using System;

class ThiSinh
{
    protected string sbd;
    protected string hoTen;
    protected double bai1;
    protected double bai2;
    protected double bai3;

    public ThiSinh(
        string sbd,
        string hoTen,
        double bai1,
        double bai2,
        double bai3)
    {
        this.sbd = sbd;
        this.hoTen = hoTen;
        this.bai1 = bai1;
        this.bai2 = bai2;
        this.bai3 = bai3;
    }

    public virtual double TongDiem()
    {
        return bai1 + bai2 + bai3;
    }

    public virtual void Xuat()
    {
        Console.WriteLine("SBD: " + sbd);
        Console.WriteLine("Ho ten: " + hoTen);
        Console.WriteLine("Bai 1: " + bai1);
        Console.WriteLine("Bai 2: " + bai2);
        Console.WriteLine("Bai 3: " + bai3);
    }
}

class ThiSinhChuyen : ThiSinh
{
    private double tiengAnh;

    public ThiSinhChuyen(
        string sbd,
        string hoTen,
        double bai1,
        double bai2,
        double bai3,
        double tiengAnh)
        : base(sbd, hoTen, bai1, bai2, bai3)
    {
        this.tiengAnh = tiengAnh;
    }

    public override double TongDiem()
    {
        double diem = bai1 + bai2 + bai3;

        if (tiengAnh >= 7 && tiengAnh <= 8)
        {
            diem += 1;
        }
        else if (tiengAnh >= 9 && tiengAnh <= 10)
        {
            diem += 2;
        }

        return diem;
    }

    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine("Diem tieng Anh: " + tiengAnh);
        Console.WriteLine("Tong diem: " + TongDiem());
    }
}

class ThiSinhSieuCup : ThiSinh
{
    private double csdl;

    public ThiSinhSieuCup(
        string sbd,
        string hoTen,
        double bai1,
        double bai2,
        double bai3,
        double csdl)
        : base(sbd, hoTen, bai1, bai2, bai3)
    {
        this.csdl = csdl;
    }

    public override double TongDiem()
    {
        return bai1 + bai2 + bai3 + csdl;
    }

    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine("Diem CSDL: " + csdl);
        Console.WriteLine("Tong diem: " + TongDiem());
    }
}

class CuocThi
{
    private ThiSinh[] ds;

    public CuocThi()
    {
        ds = new ThiSinh[0];
    }

    public CuocThi(ThiSinh[] ds)
    {
        this.ds = ds;
    }

    public void Xuat()
    {
        Console.WriteLine("===== KET QUA CUOC THI =====");

        for (int i = 0; i < ds.Length; i++)
        {
            Console.WriteLine("\nThi sinh thu " + (i + 1));
            ds[i].Xuat();
        }
    }
}

class Program
{
    static void Main()
    {
        ThiSinh[] ds = new ThiSinh[4];

        ds[0] = new ThiSinhChuyen(
            "C001",
            "Nguyen Van A",
            7,
            8,
            9,
            8);

        ds[1] = new ThiSinhChuyen(
            "C002",
            "Tran Thi B",
            8,
            7,
            9,
            9);

        ds[2] = new ThiSinhSieuCup(
            "SC001",
            "Le Van C",
            8,
            9,
            7,
            9);

        ds[3] = new ThiSinhSieuCup(
            "SC002",
            "Pham Van D",
            10,
            8,
            9,
            8);

        CuocThi ct = new CuocThi(ds);

        ct.Xuat();
    }
}
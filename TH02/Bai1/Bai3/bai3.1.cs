using System;

class SinhVien : IComparable<SinhVien>
{
    private string hoTen;
    private double diemTB;

    public SinhVien(string hoTen, double diemTB)
    {
        this.hoTen = hoTen;
        this.diemTB = diemTB;
    }

    public void Output()
    {
        Console.WriteLine(hoTen + " - " + diemTB);
    }

    public int CompareTo(SinhVien other)
    {
        return diemTB.CompareTo(other.diemTB);
    }
}

class Program
{
    static void Main()
    {
        SinhVien[] ds =
        {
            new SinhVien("Nguyen Van A", 8.5),
            new SinhVien("Tran Thi B", 7.2),
            new SinhVien("Le Van C", 9.0),
            new SinhVien("Pham Van D", 6.8)
        };

        Array.Sort(ds);

        Console.WriteLine("Danh sach sau khi sap xep:");

        for (int i = 0; i < ds.Length; i++)
        {
            ds[i].Output();
        }
    }
}

using System;

interface ISortable<T>
{
    int CompareTo(T other);
}

class SinhVien : ISortable<SinhVien>
{
    private string hoTen;
    private double diemTB;

    public SinhVien(string hoTen, double diemTB)
    {
        this.hoTen = hoTen;
        this.diemTB = diemTB;
    }

    public int CompareTo(SinhVien other)
    {
        return diemTB.CompareTo(other.diemTB);
    }

    public void Output()
    {
        Console.WriteLine(hoTen + " - " + diemTB);
    }
}

class SapXep
{
    public static void Sort<T>(T[] a) where T : ISortable<T>
    {
        for (int i = 0; i < a.Length - 1; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[i].CompareTo(a[j]) > 0)
                {
                    T temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }
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

        SapXep.Sort(ds);

        Console.WriteLine("Danh sach sau khi sap xep:");

        for (int i = 0; i < ds.Length; i++)
        {
            ds[i].Output();
        }
    }
}
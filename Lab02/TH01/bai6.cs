using System;

class TimMax
{
    public int TimGiaTriLonNhat(int a, int b, int c)
    {
        int max = a;

        if (b > max)
            max = b;

        if (c > max)
            max = c;

        return max;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Nhap so thu nhat: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhap so thu hai: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Nhap so thu ba: ");
        int c = int.Parse(Console.ReadLine());

        TimMax tm = new TimMax();

        int ketQua = tm.TimGiaTriLonNhat(a, b, c);

        Console.WriteLine("Gia tri lon nhat la: " + ketQua);
    }
}
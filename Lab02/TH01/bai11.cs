using System;

class DaoChuoi
{
    public string Dao(string chuoi)
    {
        string ketQua = "";

        for (int i = chuoi.Length - 1; i >= 0; i--)
        {
            ketQua += chuoi[i];
        }

        return ketQua;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Nhap chuoi: ");
        string chuoi = Console.ReadLine();

        DaoChuoi obj = new DaoChuoi();

        string ketQua = obj.Dao(chuoi);

        Console.WriteLine("Chuoi dao: " + ketQua);
    }
}
using System;

class ChuoiDoiXung
{
    public bool KiemTraDoiXung(string chuoi)
    {
        int dau = 0;
        int cuoi = chuoi.Length - 1;

        while (dau < cuoi)
        {
            if (chuoi[dau] != chuoi[cuoi])
                return false;

            dau++;
            cuoi--;
        }

        return true;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Nhap chuoi: ");
        string chuoi = Console.ReadLine();

        ChuoiDoiXung c = new ChuoiDoiXung();

        if (c.KiemTraDoiXung(chuoi))
            Console.WriteLine("Chuoi doi xung.");
        else
            Console.WriteLine("Chuoi khong doi xung.");
    }
}
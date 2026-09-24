using System;

class XuLyChuoi
{
    public string ChuThuong(string chuoi)
    {
        return chuoi.ToLower();
    }

    public string ChuHoa(string chuoi)
    {
        return chuoi.ToUpper();
    }

    public int DemSoTu(string chuoi)
    {
        string[] tu = chuoi.Trim().Split(
            new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries
        );

        return tu.Length;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Nhap chuoi: ");
        string chuoi = Console.ReadLine();

        XuLyChuoi obj = new XuLyChuoi();

        Console.WriteLine("Chuoi thuong: " + obj.ChuThuong(chuoi));
        Console.WriteLine("Chuoi hoa: " + obj.ChuHoa(chuoi));
        Console.WriteLine("So tu trong chuoi: " + obj.DemSoTu(chuoi));
    }
}
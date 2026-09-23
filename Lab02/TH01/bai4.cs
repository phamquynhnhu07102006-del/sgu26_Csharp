using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so nguyen x: ");
        string inputX = Console.ReadLine();

        if (!int.TryParse(inputX, out int x))
        {
            Console.WriteLine("Loi: x khong phai la so nguyen!");
            return;
        }

        Console.Write("Nhap so nguyen y: ");
        string inputY = Console.ReadLine();

        if (!int.TryParse(inputY, out int y))
        {
            Console.WriteLine("Loi: y khong phai la so nguyen!");
            return;
        }

        int ketQua = (int)Math.Pow(x, y);

        Console.WriteLine("Ket qua " + x + " mu " + y + " la: " + ketQua);
    }
}
using System;

class bai3
{
    static void Main()
    {
        Console.Write("Nhap so nguyen x: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Nhap so nguyen y: ");
        int y = int.Parse(Console.ReadLine());

        int ketQua = (int)Math.Pow(x, y);

        Console.WriteLine("Ket qua " + x + " mu " + y + " la: " + ketQua);
    }
}
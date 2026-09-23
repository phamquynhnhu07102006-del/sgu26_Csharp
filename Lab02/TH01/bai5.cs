using System;

class Program
{
    static void Main()
    {
        double x = 0, y = 0;
        int chon;

        do
        {
            Console.WriteLine("\nMENU");
            Console.WriteLine("1. Nhap hai gia tri so thuc cho x, y");
            Console.WriteLine("2. Tinh x^y");
            Console.WriteLine("3. Tinh can bac 2 cua x va y");
            Console.WriteLine("4. Thoat");
            Console.Write("Chon chuc nang: ");

            chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1:
                    Console.Write("Nhap x: ");
                    x = double.Parse(Console.ReadLine());

                    Console.Write("Nhap y: ");
                    y = double.Parse(Console.ReadLine());

                    Console.WriteLine("Da nhap x = " + x + ", y = " + y);
                    break;

                case 2:
                    Console.WriteLine("Ket qua x^y = " + Math.Pow(x, y));
                    break;

                case 3:
                    if (x >= 0 && y >= 0)
                    {
                        Console.WriteLine("Can bac 2 cua x = " + Math.Sqrt(x));
                        Console.WriteLine("Can bac 2 cua y = " + Math.Sqrt(y));
                    }
                    else
                    {
                        Console.WriteLine("Loi: x va y phai >= 0 de tinh can bac 2.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Chuong trinh ket thuc!");
                    break;

                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }

        } while (chon != 4);
    }
}
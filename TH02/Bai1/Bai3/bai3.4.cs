using System;

class ConsoleMenu
{
    public delegate void ChooseHandler(int chon);

    public event ChooseHandler Choose;

    public void Run()
    {
        int chon;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Giai phuong trinh bac 2");
            Console.WriteLine("2. Thong tin");
            Console.WriteLine("0. Thoat chuong trinh");

            Console.Write("Thuc hien: ");
            chon = int.Parse(Console.ReadLine());

            if (Choose != null)
            {
                Choose(chon);
            }

        } while (chon != 0);
    }
}

class PTBac2Console : ConsoleMenu
{
    public PTBac2Console()
    {
        Choose += XuLyChucNang;
    }

    private void XuLyChucNang(int chon)
    {
        switch (chon)
        {
            case 1:
                GiaiPTBac2();
                break;

            case 2:
                Console.WriteLine("Ban dang su dung chuong trinh giai phuong trinh bac 2.");
                break;

            case 0:
                Console.WriteLine("Thoat chuong trinh.");
                break;

            default:
                Console.WriteLine("Chuc nang khong hop le!");
                break;
        }
    }

    private void GiaiPTBac2()
    {
        Console.Write("Nhap a = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhap b = ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Nhap c = ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                    Console.WriteLine("Phuong trinh co vo so nghiem.");
                else
                    Console.WriteLine("Phuong trinh vo nghiem.");
            }
            else
            {
                double x = -c / b;
                Console.WriteLine("Phuong trinh co nghiem x = " + x);
            }

            return;
        }

        double delta = b * b - 4 * a * c;

        if (delta < 0)
        {
            Console.WriteLine("Phuong trinh vo nghiem.");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("Phuong trinh co nghiem kep x = " + x);
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
    }
}

class Program
{
    static void Main()
    {
        PTBac2Console app = new PTBac2Console();

        app.Run();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
namespace BaiThucHanhLINQ;
public class Program
{
    public static void Output(ref int[] mangSo)
    {
        for(int i = 0; i < mangSo.Length; i++){
            Console.WriteLine(mangSo[i]);
        }

    }
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("  BÀI 2 ");
        LINQ_Array.B2.ArrayLINQ.run();

        Console.WriteLine("\n  BÀI 3 ");
        LINQ_Array.B3.ThongKePhanNhom.run();

        Console.WriteLine("\n  BÀI 4, 5, 6 ");
        LINQ_Array.B4.TruyVanMonHoc.run();
    }
}

using System.Linq;
namespace LINQ_Array.B2;
//Bài 2.1. Truy vấn mảng số nguyên
public class ArrayLINQ
{
    public static void Output(int[] mangSo)
    {
        Console.WriteLine("Mảng là: ");
        for (int i = 0; i < mangSo.Length; i++)
        {
            Console.Write(mangSo[i] + " ");
        }
    }
//a. Liệt kê các phần tử chia hết cho 4 và 3.
    public static void LietKeChiaHet3Va4(int[] array)
    {
        Console.WriteLine("2.1.a: ");
        array            .Where(x => x % 3 == 0 && x % 4 == 0)
            .ToList()
            .ForEach(Console.WriteLine);
    }
//b. Liệt kê các phần tử nhỏ hơn hoặc bằng 3.
    public static void LietKeNhoHonBang3(int[] array)
    {
         Console.WriteLine("2.1.b: ");
        array
            .Where(x => x <= 3)
            .ToList()
            .ForEach(Console.WriteLine);
    }
//c. Tạo một dãy mới: số chẵn chia đôi, số lẻ giữ nguyên giá trị.
    public static int[] TaoDayMoi(int[] array)
    {
         Console.WriteLine("2.1.c: ");
        return array
            .Select(x => x % 2 == 0 ? x / 2 : x)
            .ToArray();
    }
    public static void CauA(string[] mangChuoi)
    {
        Console.WriteLine("2.2.a: ");
        mangChuoi
            .Where(x => x.Length == 4)
            .OrderBy(x => x[0])
            .ToList()
            .ForEach(Console.WriteLine);
    }

    // b. chữ thường - CHỮ HOA
    public static void CauB(string[] mangChuoi)
    {
        Console.WriteLine("2.2.b: ");
        mangChuoi
            .Select(x => $"{x.ToLower()} - {x.ToUpper()}")
            .ToList()
            .ForEach(Console.WriteLine);
    }

    // c. Chứa ký tự "u"
    public static void CauC(string[] mangChuoi)
    {
        Console.WriteLine("2.2.c: ");
        mangChuoi
            .Where(x => x.Contains("u"))
            .ToList()
            .ForEach(Console.WriteLine);
    }

    // d. Các từ bắt đầu bằng chữ in hoa
    public static void CauD(string[] mangChuoi)
    {
        Console.WriteLine("2.2.d: ");
        mangChuoi
            .Where(x => char.IsUpper(x[0]))
            .ToList()
            .ForEach(Console.WriteLine);
    }
    public static void run()
    {
        int[] mangSo = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };
        Output(mangSo);
        LietKeChiaHet3Va4(mangSo);
        LietKeNhoHonBang3(mangSo);
        TaoDayMoi(mangSo).ToList().ForEach(Console.WriteLine);

        string[] mangChuoi = { "đầu", "lòng", "hai", "ả", "tố", "nga",
        "Thúy", "Kiều", "là", "chị", "em", "là", "Thúy", "Vân" };
        CauA(mangChuoi);
        CauB(mangChuoi);
        CauC(mangChuoi);
        CauD(mangChuoi);
    }
}
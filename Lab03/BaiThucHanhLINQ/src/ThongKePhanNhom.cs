using System.Linq;

namespace LINQ_Array.B3;

public class ThongKePhanNhom
{
    public static void Bai31()
    {
        int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };

        Console.WriteLine("Bài 3.1 - Thống kê mảng số");
        Console.WriteLine($"a. Tổng số phần tử: {mangSo.Count()}");
        Console.WriteLine($"   Số phần tử chẵn: {mangSo.Count(x => x % 2 == 0)}");
        Console.WriteLine($"   Số phần tử lẻ: {mangSo.Count(x => x % 2 != 0)}");

        Console.WriteLine($"b. Tổng các giá trị: {mangSo.Sum()}");
        Console.WriteLine($"   Giá trị lớn nhất: {mangSo.Max()}");
        Console.WriteLine($"   Giá trị nhỏ nhất: {mangSo.Min()}");

        Console.WriteLine($"c. Số giá trị khác nhau: {mangSo.Distinct().Count()}");

        Console.WriteLine("d. Nhóm theo số dư khi chia cho 5:");
        var nhomSoDu = mangSo.GroupBy(x => x % 5).OrderBy(nhom => nhom.Key);
        foreach (var nhom in nhomSoDu)
        {
            Console.WriteLine($"   Số dư {nhom.Key}: {string.Join(", ", nhom)}");
        }
    }

    public static void Bai32()
    {
        string[] monAn = { "Bún bò Huế", "Hủ tiếu heo", "Bánh canh", "Bánh mì",
            "Nước Cà phê", "Mì quảng", "Cơm tấm", "Nước Chanh dây", "Mì xào",
            "Bún riêu", "Bánh cuốn", "Mì gói", "Bún chả", "Hủ tiếu Nam vang" };

        int doDaiNganNhat = monAn.Min(mon => mon.Length);
        int doDaiDaiNhat = monAn.Max(mon => mon.Length);

        Console.WriteLine("\nBài 3.2 - Thống kê mảng chuỗi");
        Console.WriteLine("a. Món có chiều dài ngắn nhất:");
        monAn.Where(mon => mon.Length == doDaiNganNhat).ToList().ForEach(Console.WriteLine);

        Console.WriteLine("   Món có chiều dài dài nhất:");
        monAn.Where(mon => mon.Length == doDaiDaiNhat).ToList().ForEach(Console.WriteLine);

        Console.WriteLine("b. Nhóm theo từ đầu tiên:");
        var nhomMonAn = monAn.GroupBy(mon => mon.Split(' ')[0]);
        foreach (var nhom in nhomMonAn)
        {
            Console.WriteLine($"   {nhom.Key}:");
            nhom.ToList().ForEach(mon => Console.WriteLine($"   - {mon}"));
        }

        int soMonBatDauBangBanh = monAn.Count(mon => mon.Split(' ')[0] == "Bánh");
        Console.WriteLine($"c. Số món có từ đầu tiên là \"Bánh\": {soMonBatDauBangBanh}");
    }

    public static void run()
    {
        Bai31();
        Bai32();
    }
}

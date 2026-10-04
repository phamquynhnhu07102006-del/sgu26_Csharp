using System.Linq;

namespace LINQ_Array.B4;

// Lưu thông tin một môn học.
public class MonHoc
{
    public string MaMon { get; set; } = "";
    public string TenMon { get; set; } = "";
    public string He { get; set; } = "";
    public byte SoTiet { get; set; }
}

// Lưu thông tin một hệ đào tạo.
public class He
{
    public string MaHe { get; set; } = "";
    public string TenHe { get; set; } = "";
}

// Chứa dữ liệu mẫu dùng chung cho các bài.
public class DuLieu
{
    public static List<MonHoc> DS_Mon()
    {
        return new List<MonHoc>
        {
            new() { MaMon = "HP2_1", TenMon = "Nền tảng C#", He = "KTV", SoTiet = 64 },
            new() { MaMon = "HP2_2", TenMon = "Công nghệ ADO.NET", He = "KTV", SoTiet = 64 },
            new() { MaMon = "HP3_1", TenMon = "Lập trình Windows Forms", He = "KTV", SoTiet = 64 },
            new() { MaMon = "HP3_2", TenMon = "Xây dựng ứng dụng Windows Forms", He = "KTV", SoTiet = 64 },
            new() { MaMon = "HP4_1", TenMon = "Lập trình Web với HTML, CSS và JavaScript", He = "KTV", SoTiet = 64 },
            new() { MaMon = "HP4_2", TenMon = "Xây dựng ứng dụng Web với ASP.NET", He = "KTV", SoTiet = 64 },
            new() { MaMon = "HP5_1", TenMon = "Lập trình CSDL SQL Server căn bản", He = "KTV", SoTiet = 64 },
            new() { MaMon = "HP5_2", TenMon = "Lập trình CSDL SQL Server nâng cao", He = "KTV", SoTiet = 64 },
            new() { MaMon = "JLCB", TenMon = "Joomla cơ bản", He = "CD", SoTiet = 72 },
            new() { MaMon = "LINQ", TenMon = "Language-Integrated Query", He = "CD", SoTiet = 64 },
            new() { MaMon = "DAWEB", TenMon = "Đồ án thực tế Web với ASP.NET", He = "CD", SoTiet = 40 },
            new() { MaMon = "DAWIN", TenMon = "Đồ án thực tế Windows Forms", He = "CD", SoTiet = 40 },
            new() { MaMon = "CC++", TenMon = "Lập trình hướng đối tượng với C/C++", He = "CD", SoTiet = 128 },
            new() { MaMon = "JQUE", TenMon = "JQuery", He = "CD", SoTiet = 22 },
            new() { MaMon = "XML", TenMon = "Công nghệ XML", He = "CD", SoTiet = 32 },
            new() { MaMon = "CRYS", TenMon = "Crystal Report trong Visual Studio", He = "CD", SoTiet = 32 },
            new() { MaMon = "BWEB", TenMon = "HTML, CSS và JavaScript", He = "CD", SoTiet = 32 },
            new() { MaMon = "XYZ", TenMon = "Chưa đặt tên môn", He = "", SoTiet = 0 }
        };
    }

    public static List<He> DS_He()
    {
        return new List<He>
        {
            new() { MaHe = "KTV", TenHe = "Kỹ thuật viên" },
            new() { MaHe = "CD", TenHe = "Chuyên đề" },
            new() { MaHe = "QT", TenHe = "Chứng chỉ quốc tế" }
        };
    }
}

public class TruyVanMonHoc
{
    // Bài 5.1: Các truy vấn cơ bản trên List<MonHoc>.
    public static void Bai51(List<MonHoc> dsMon)
    {
        Console.WriteLine("Bài 5.1 - Truy vấn cơ bản");

        Console.WriteLine("a. Môn bắt đầu bằng 'Lập trình':");
        dsMon.Where(mon => mon.TenMon.StartsWith("Lập trình"))
             .ToList().ForEach(mon => Console.WriteLine($"   {mon.TenMon}"));

        Console.WriteLine("b. Môn hệ CD, số tiết giảm dần, mã môn tăng dần:");
        dsMon.Where(mon => mon.He == "CD")
             .OrderByDescending(mon => mon.SoTiet).ThenBy(mon => mon.MaMon)
             .ToList().ForEach(mon => Console.WriteLine($"   {mon.MaMon} - {mon.TenMon} - {mon.SoTiet} tiết"));

        Console.WriteLine("c. Môn có tên chứa 'web':");
        dsMon.Where(mon => mon.TenMon.Contains("web", StringComparison.OrdinalIgnoreCase))
             .Select(mon => new { mon.TenMon, mon.He })
             .ToList().ForEach(mon => Console.WriteLine($"   {mon.TenMon} - {mon.He}"));

        Console.WriteLine("d. Môn hệ KTV, mã môn tăng dần:");
        dsMon.Where(mon => mon.He == "KTV").OrderBy(mon => mon.MaMon)
             .ToList().ForEach(mon => Console.WriteLine($"   {mon.MaMon} - {mon.TenMon}"));
    }

    // Bài 5.2: Thống kê và phân nhóm List<MonHoc>.
    public static void Bai52(List<MonHoc> dsMon)
    {
        Console.WriteLine("\nBài 5.2 - Thống kê List<MonHoc>");
        Console.WriteLine($"a. Tổng số môn: {dsMon.Count()}");
        Console.WriteLine($"b. Số môn bắt đầu bằng 'Lập trình': {dsMon.Count(mon => mon.TenMon.StartsWith("Lập trình"))}");
        Console.WriteLine($"c. Tổng số tiết hệ KTV: {dsMon.Where(mon => mon.He == "KTV").Sum(mon => mon.SoTiet)}");

        Console.WriteLine("d. Tổng số môn của mỗi hệ:");
        dsMon.GroupBy(mon => mon.He)
             .ToList().ForEach(nhom => Console.WriteLine($"   {TenHeHienThi(nhom.Key)}: {nhom.Count()} môn"));

        Console.WriteLine("e. Nhóm theo số tiết:");
        dsMon.GroupBy(mon => mon.SoTiet).OrderByDescending(nhom => nhom.Key)
             .ToList().ForEach(nhom => Console.WriteLine($"   {nhom.Key} tiết: {nhom.Count()} môn"));

        MonHoc monNhieuTietNhat = dsMon.OrderByDescending(mon => mon.SoTiet).First();
        Console.WriteLine($"f. Môn có số tiết cao nhất: {monNhieuTietNhat.MaMon} - {monNhieuTietNhat.TenMon} - {monNhieuTietNhat.SoTiet} tiết");

        Console.WriteLine("g. Thống kê theo hệ:");
        dsMon.GroupBy(mon => mon.He).ToList().ForEach(nhom =>
            Console.WriteLine($"   {TenHeHienThi(nhom.Key)}: {nhom.Count()} môn, tổng {nhom.Sum(mon => mon.SoTiet)} tiết, " +
                              $"cao nhất {nhom.Max(mon => mon.SoTiet)}, thấp nhất {nhom.Min(mon => mon.SoTiet)}"));

        Console.WriteLine("h. Môn học phân nhóm theo hệ:");
        foreach (var nhom in dsMon.GroupBy(mon => mon.He))
        {
            Console.WriteLine($"   {TenHeHienThi(nhom.Key)}:");
            nhom.ToList().ForEach(mon => Console.WriteLine($"   - {mon.MaMon} - {mon.TenMon}"));
        }

        Console.WriteLine("i. Môn học phân nhóm theo số tiết:");
        foreach (var nhom in dsMon.GroupBy(mon => mon.SoTiet).OrderBy(nhom => nhom.Key))
        {
            Console.WriteLine($"   {nhom.Key} tiết:");
            nhom.ToList().ForEach(mon => Console.WriteLine($"   - {mon.MaMon} - {mon.TenMon}"));
        }

        Console.WriteLine("j. Hệ KTV nhóm theo học phần HP2, HP3, HP4, HP5:");
        foreach (var nhom in dsMon.Where(mon => mon.He == "KTV")
                                  .GroupBy(mon => mon.MaMon.Split('_')[0]).OrderBy(nhom => nhom.Key))
        {
            Console.WriteLine($"   {nhom.Key}:");
            nhom.OrderBy(mon => mon.MaMon).ToList()
                .ForEach(mon => Console.WriteLine($"   - {mon.MaMon} - {mon.TenMon}"));
        }

        Console.WriteLine("k. Nhóm theo hệ, chỉ lấy môn có số tiết > 40:");
        foreach (var nhom in dsMon.Where(mon => mon.SoTiet > 40).GroupBy(mon => mon.He))
        {
            Console.WriteLine($"   {TenHeHienThi(nhom.Key)}:");
            nhom.OrderBy(mon => mon.MaMon).ToList()
                .ForEach(mon => Console.WriteLine($"   - {mon.MaMon} - {mon.TenMon}"));
        }
    }

    // Bài 6.2: Join hai nguồn dữ liệu MonHoc và He.
    public static void Bai62(List<MonHoc> dsMon, List<He> dsHe)
    {
        Console.WriteLine("\nBài 6.2 - Join và các toán tử tập hợp");

        Console.WriteLine("a. Join: Tên hệ, mã môn, tên môn:");
        var joinMonHe = dsHe.Join(dsMon, he => he.MaHe, mon => mon.He,
            (he, mon) => new { he.TenHe, mon.MaMon, mon.TenMon });
        joinMonHe.ToList().ForEach(x => Console.WriteLine($"   {x.TenHe} - {x.MaMon} - {x.TenMon}"));

        Console.WriteLine("b. Left outer join (kể cả hệ chưa có môn):");
        var leftJoin = dsHe.GroupJoin(dsMon, he => he.MaHe, mon => mon.He,
            (he, dsMonTheoHe) => new { he, dsMonTheoHe })
            .SelectMany(x => x.dsMonTheoHe.DefaultIfEmpty(),
                (x, mon) => new { x.he.TenHe, Mon = mon?.TenMon ?? "Chưa có môn học" });
        leftJoin.ToList().ForEach(x => Console.WriteLine($"   {x.TenHe} - {x.Mon}"));

        Console.WriteLine("c. Full outer join (kể cả hệ hoặc môn chưa khai báo):");
        var monCoHe = leftJoin.Select(x => $"   {x.TenHe} - {x.Mon}");
        var monChuaCoHe = dsMon.Where(mon => !dsHe.Any(he => he.MaHe == mon.He))
                                .Select(mon => $"   Chưa khai báo hệ - {mon.TenMon}");
        monCoHe.Concat(monChuaCoHe).ToList().ForEach(Console.WriteLine);

        Console.WriteLine("d. Hệ chưa có môn và môn chưa khai báo hệ:");
        dsHe.Where(he => !dsMon.Any(mon => mon.He == he.MaHe))
            .ToList().ForEach(he => Console.WriteLine($"   {he.TenHe} - Chưa có môn học"));
        dsMon.Where(mon => !dsHe.Any(he => he.MaHe == mon.He))
             .ToList().ForEach(mon => Console.WriteLine($"   Chưa khai báo hệ - {mon.TenMon}"));

        Console.WriteLine("e. Năm môn có số tiết cao nhất:");
        dsMon.OrderByDescending(mon => mon.SoTiet).Take(5)
             .GroupJoin(dsHe, mon => mon.He, he => he.MaHe,
                 (mon, he) => new { mon, he = he.FirstOrDefault() })
             .ToList().ForEach(x => Console.WriteLine($"   {x.he?.TenHe ?? "Chưa khai báo hệ"} - {x.mon.MaMon} - {x.mon.TenMon} - {x.mon.SoTiet} tiết"));

        Console.WriteLine("f. Tổng số môn học của mỗi hệ:");
        dsHe.GroupJoin(dsMon, he => he.MaHe, mon => mon.He,
            (he, mon) => new { he.MaHe, he.TenHe, TongSoMon = mon.Count() })
            .ToList().ForEach(x => Console.WriteLine($"   {x.MaHe} - {x.TenHe}: {x.TongSoMon} môn"));

        Console.WriteLine($"g. Số loại số tiết khác nhau: {dsMon.Select(mon => mon.SoTiet).Distinct().Count()}");

        MonHoc? monDauTien = dsMon.FirstOrDefault(mon => mon.TenMon.StartsWith("Lập trình"));
        Console.WriteLine($"h. Môn đầu tiên bắt đầu bằng 'Lập trình': {monDauTien?.TenMon ?? "Không tìm thấy"}");

        Console.WriteLine("i. Liệt kê môn theo từng hệ và đánh số thứ tự:");
        foreach (var he in dsHe)
        {
            Console.WriteLine($"   {he.TenHe}:");
            dsMon.Where(mon => mon.He == he.MaHe).Select((mon, index) => new { mon, index })
                 .ToList().ForEach(x => Console.WriteLine($"   {x.index + 1}. {x.mon.MaMon} - {x.mon.TenMon}"));
        }
    }

    private static string TenHeHienThi(string maHe)
    {
        return string.IsNullOrWhiteSpace(maHe) ? "Chưa khai báo hệ" : maHe;
    }

    public static void run()
    {
        List<MonHoc> dsMon = DuLieu.DS_Mon();
        List<He> dsHe = DuLieu.DS_He();

        Bai51(dsMon);
        Bai52(dsMon);
        Bai62(dsMon, dsHe);
    }
}

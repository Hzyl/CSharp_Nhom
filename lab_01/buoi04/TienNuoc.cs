namespace NMLT.Buoi04
{
    public static class TienNuoc
    {
        public static void Main()
        {
            Console.Write("Nhap chi so nuoc thang truoc: ");
            double cu = double.Parse(Console.ReadLine()!);
            Console.Write("Nhap chi so nuoc trong thang: ");
            double moi = double.Parse(Console.ReadLine()!);
            Console.Write("Nhap so nguoi dang ky: ");
            int nguoi = int.Parse(Console.ReadLine()!);
            if (moi < cu || nguoi <= 0)
            {
                Console.WriteLine("Du lieu khong hop le.");
                return;
            }
            double m3 = moi - cu, dinhMuc = 4 * nguoi, gia = Math.Min(m3, dinhMuc) * 4400;
            if (m3 > dinhMuc) gia += Math.Min(m3 - dinhMuc, 2 * nguoi) * 8300;
            if (m3 > dinhMuc + 2 * nguoi) gia += (m3 - dinhMuc - 2 * nguoi) * 10500;
            Console.WriteLine($"So tien phai tra cho {m3:F1} m3 tieu thu la {gia * 1.15:F0} D.");
        }
    }
}

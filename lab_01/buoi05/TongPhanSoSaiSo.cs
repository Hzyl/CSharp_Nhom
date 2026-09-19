namespace NMLT.Buoi05
{
    public static class TongPhanSoSaiSo
    {
        public static void Main()
        {
            Console.Write("Nhap so thuc a: ");
            double a = double.Parse(Console.ReadLine()!);
            Console.Write("Nhap sai so epsilon (<= 0.1): ");
            double eps = double.Parse(Console.ReadLine()!);
            if (a <= 0 || eps <= 0 || eps > 0.1)
            {
                Console.WriteLine("Du lieu khong hop le.");
                return;
            }
            double s = 0;
            int n = 0;
            while (1.0 / (a + n) >= eps)
            {
                s += 1.0 / (a + n);
                n++;
            }
            Console.WriteLine($"S(a={a}, epsilon={eps}) = {s:F6} (gom {n} so hang).");
        }
    }
}

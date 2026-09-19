namespace NMLT.Buoi05
{
    public static class GiaTriBieuThuc
    {
        public static void Main()
        {
            Console.Write("Nhap so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine()!);
            if (n < 1)
            {
                Console.WriteLine("n phai duong.");
                return;
            }
            double s1 = 0, s2 = 0;
            for (int i = 1; i <= n; i++) s1 += 1.0 / i;
            for (int i = n; i >= 1; i--) s2 += ((n - i) % 2 == 0 ? 1 : -1) * 1.0 / i;
            Console.WriteLine($"S1(n={n}) = {s1:F6}.");
            Console.WriteLine($"S2(n={n}) = {s2:F6}.");
        }
    }
}

namespace NMLT.Buoi07
{
    public static class KiemTraSoHoanHao
    {
        static int TongUoc(int n)
        {
            int s = 0;
            for (int i = 1; i < n; i++) if (n % i == 0) s += i;
            return s;
        }
        public static void Main()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.WriteLine(TongUoc(n) == n && n > 1 ? $"{n} la so hoan hao." : $"{n} khong la so hoan hao.");
        }
    }
}

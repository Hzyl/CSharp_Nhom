namespace NMLT.Buoi06
{
    public static class PhanTichThuaSo1
    {
        public static void Main()
        {
            Console.Write("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine()!);
            bool dau = true;
            Console.Write($"{n} = ");
            for (int p = 2; p * p <= n; p += (p == 2 ? 1 : 2)) while (n % p == 0)
            {
                if (!dau) Console.Write(" x ");
                Console.Write(p);
                dau = false;
                n /= p;
            }
            if (n > 1)
            {
                if (!dau) Console.Write(" x ");
                Console.Write(n);
            }
            Console.WriteLine();
        }
    }
}

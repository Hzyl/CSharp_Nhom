namespace NMLT.Buoi08
{
    public static class LietKeSoHoanHao
    {
        static bool HoanHao(int n)
        {
            int s = 0;
            for (int i = 1; i < n; i++) if (n % i == 0) s += i;
            return n > 1 && s == n;
        }
        public static void Main()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Cac so hoan hao: {string.Join(" ", Enumerable.Range(1, n).Where(HoanHao).Reverse())}");
        }
    }
}

namespace NMLT.Buoi11
{
    public static class ThemChanLe
    {
        public static void Main()
        {
            Console.Write("Nhap day so nguyen: ");
            List<int> a = (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            for (int i = 0; i < a.Count - 1; i++) if (a[i] % 2 == 0 && a[i + 1] % 2 == 0)
            {
                Console.Write($"Nhap so le chen giua {a[i]} va {a[i + 1]}: ");
                int x = int.Parse(Console.ReadLine()!);
                if (x % 2 == 0)
                {
                    Console.WriteLine("Gia tri phai la so le.");
                    return;
                }
                a.Insert(++i, x);
            }
            Console.WriteLine("Mang sau khi them: " + string.Join(" ", a));
        }
    }
}

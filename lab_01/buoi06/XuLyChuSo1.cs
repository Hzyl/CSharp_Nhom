namespace NMLT.Buoi06
{
    public static class XuLyChuSo1
    {
        public static void Main()
        {
            Console.Write("Nhap so nguyen n: ");
            string s = (Console.ReadLine() ?? "").Trim().TrimStart('-');
            Console.Write("Nhap vi tri k (tu trai, bat dau 1): ");
            int k = int.Parse(Console.ReadLine()!);
            int tongLe = 0, minLe = 10, maxLe = -1;
            foreach (char c in s)
            {
                int d = c - '0';
                if (d % 2 == 1)
                {
                    tongLe += d;
                    minLe = Math.Min(minLe, d);
                    maxLe = Math.Max(maxLe, d);
                }
            }
            Console.WriteLine(k >= 1 && k <= s.Length ? $"Chu so thu {k} la {s[k - 1]}." : "Vi tri k khong hop le.");
            Console.WriteLine($"Tong cac chu so le la {tongLe}.");
            Console.WriteLine(maxLe < 0 ? "Khong co chu so le." : $"Chu so le nho nhat la {minLe}, lon nhat la {maxLe}.");
        }
    }
}

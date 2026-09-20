namespace NMLT.Buoi11
{
    public static class DaoDay
    {
        public static void Main()
        {
            Console.Write("Nhap day so nguyen: ");
            List<int> a = (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Console.WriteLine("* Mang truoc khi dao: ");
            Console.WriteLine("Day so co " + a.Count + " phan tu: " + string.Join(" ", a));

            for (int i = 0, j = a.Count - 1; i < j; i++, j--)
                (a[i], a[j]) = (a[j], a[i]);

            Console.WriteLine("* Mang sau khi dao: ");
            Console.WriteLine("Day so co " + a.Count + " phan tu: " + string.Join(" ", a));
        }
    }
}

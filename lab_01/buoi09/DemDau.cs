namespace NMLT.Buoi09
{
    public static class DemDau
    {
        public static void Main()
        {
            Console.Write("Nhap day so thuc, cach nhau boi khoang trang: ");
            double[] a = (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            Console.WriteLine($"So am: {a.Count(x => x < 0)}, so khong: {a.Count(x => x == 0)}, so duong: {a.Count(x => x > 0)}.");
        }
    }
}

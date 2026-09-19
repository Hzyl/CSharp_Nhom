namespace NMLT.Buoi10
{
    public static class DayDanDau
    {
        public static void Main()
        {
            Console.Write("Nhap day so thuc: ");
            double[] a = (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            bool ok = a.Zip(a.Skip(1), (x, y) => x * y < 0).All(x => x);
            Console.WriteLine(ok ? "Day la day dan dau." : "Day khong phai day dan dau.");
        }
    }
}

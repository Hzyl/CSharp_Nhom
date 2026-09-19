namespace NMLT.Buoi02
{
    public static class BieuThucNhanh1
    {
        public static void Main()
        {
            Console.Write("Nhap so thuc x: ");
            double x = double.Parse(Console.ReadLine()!);
            double f = 1 + x * (2 + x * (3 - 4 * x));
            Console.WriteLine($"f({x}) = {f:F2}");
        }
    }
}

namespace NMLT.Buoi03
{
    public static class GiaTriHamSo1
    {
        public static void Main()
        {
            Console.Write("Nhap so thuc x: ");
            double x = double.Parse(Console.ReadLine()!);
            double f1 = x <= 0 ? 0 : x <= 1 ? x : Math.Pow(x, 4);
            double f2 = x <= 2 ? x * x + 4 * x + 5 : 1 / (x * x + 4 * x + 5);
            Console.WriteLine($"f1({x}) = {f1:F2}");
            Console.WriteLine($"f2({x}) = {f2:F2}");
        }
    }
}

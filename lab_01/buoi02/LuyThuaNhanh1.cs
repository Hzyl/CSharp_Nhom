namespace NMLT.Buoi02
{
    public static class LuyThuaNhanh1
    {
        public static void Main()
        {
            Console.Write("Nhap so thuc a: ");
            double a = double.Parse(Console.ReadLine()!);
            double a2 = a * a, a4 = a2 * a2, a5 = a4 * a, a8 = a4 * a4, a16 = a8 * a8, a17 = a16 * a;
            Console.WriteLine($"Ket qua: {a}^2={a2:F2}, {a}^5={a5:F2}, {a}^17={a17:F2}.");
        }
    }
}

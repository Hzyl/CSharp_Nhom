namespace NMLT.Buoi10
{
    public static class KeNhauTraiDau
    {
        public static void Main()
        {
            Console.Write("Nhap day so thuc: ");
            double[] a = (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            int dem = 0;
            for (int i = 0; i < a.Length - 1; i++) if (a[i] * a[i + 1] < 0) dem++;
            Console.WriteLine($"So luong cap ke nhau trai dau: {dem}.");
        }
    }
}

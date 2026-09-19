namespace NMLT.Buoi03
{
    public static class PhuongTrinhBac2
    {
        public static void Main()
        {
            Console.Write("Nhap he so a, b, c (cach nhau boi khoang trang): ");
            double[] v = (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            double a = v[0], b = v[1], c = v[2];
            const double e = 1e-12;
            if (Math.Abs(a) < e)
            {
                if (Math.Abs(b) < e) Console.WriteLine(Math.Abs(c) < e ? "Phuong trinh vo so nghiem." : "Phuong trinh vo nghiem.");
                else Console.WriteLine($"Phuong trinh co 1 nghiem x = {-c / b:F2}.");
                return;
            }
            double d = b * b - 4 * a * c;
            if (d < -e) Console.WriteLine("Phuong trinh vo nghiem thuc.");
            else if (Math.Abs(d) < e) Console.WriteLine($"Phuong trinh co nghiem kep x = {-b / (2 * a):F2}.");
            else
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a), x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine($"Phuong trinh co 2 nghiem: x1 = {x1:F2}, x2 = {x2:F2}.");
            }
        }
    }
}

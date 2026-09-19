namespace NMLT.Buoi07
{
    public static class TinhSoPi
    {
        public static void Main()
        {
            Console.Write("Nhap epsilon: ");
            double e = double.Parse(Console.ReadLine()!);
            double s = 0;
            int i = 0;
            double term;
            do
            {
                term = 4.0 * (i % 2 == 0 ? 1 : -1) / (2 * i + 1);
                s += term;
                i++;
            }
            while (Math.Abs(term) >= e);
            Console.WriteLine($"Pi = {s:F10}, sai so so voi Math.PI = {Math.Abs(Math.PI - s):G6}");
        }
    }
}

namespace NMLT.Buoi12
{
    public static class DemSoTrenBienMang2C
    {
        public static void Main()
        {
            Console.Write("Nhap so dong va cot: ");
            int[] d = (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int duong = 0, am = 0, khong = 0;
            for (int i = 0; i < d[0]; i++)
            {
                Console.Write($"Dong {i}: ");
                double[] a = (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                for (int j = 0; j < d[1]; j++) if (i == 0 || j == 0 || i == d[0] - 1 || j == d[1] - 1)
                {
                    if (a[j] > 0) duong++;
                    else if (a[j] < 0) am++;
                    else khong++;
                }
            }
            Console.WriteLine($"Tren duong bien co {duong} so duong, {am} so am va {khong} so khong.");
        }
    }
}

namespace NMLT.Buoi08
{
    public static class GiaiThua
    {
        // Ham tinh giai thua, dung LINQ Aggregate
        static long GiaiThuaCuaN(int n) => Enumerable.Range(1, n).Aggregate(1L, (tich, i) => tich * i);

        public static void Main()
        {
            Console.Write("Moi ban nhap k: ");
            int k = int.Parse(Console.ReadLine()!);

            Console.Write("Moi ban nhap n: ");
            int n = int.Parse(Console.ReadLine()!);

            long ketQua = GiaiThuaCuaN(n) / (GiaiThuaCuaN(k) * GiaiThuaCuaN(n - k));

            Console.WriteLine($"C({k}, {n}) = {ketQua}.");
        }
    }
}

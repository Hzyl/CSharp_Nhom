namespace NMLT.Buoi10
{
    public static class TimDoan
    {
        public static void Main()
        {
            Console.Write("Nhap day so thuc: ");
            double[] a = (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            Console.Write("Nhap so k: ");
            double k = double.Parse(Console.ReadLine()!);

            var doan = (from i in Enumerable.Range(0, a.Length)
                        from j in Enumerable.Range(i, a.Length - i)
                        where a.Skip(i).Take(j - i + 1).Sum() == k
                        orderby j - i descending
                        select new { i, j }).FirstOrDefault();

            if (doan == null)
                Console.WriteLine($"Khong tim thay doan nao co tong bang {k}.");
            else
                Console.WriteLine($"Doan [{doan.i}, {doan.j}] dai nhat co tong bang {k}: {string.Join(" ", a.Skip(doan.i).Take(doan.j - doan.i + 1))}");
        }
    }
}

namespace NMLT.Buoi12
{
    public static class MaTranToanLe
    {
        public static void Main()
        {
            Console.Write("Nhap so dong va cot: ");
            int[] d = (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            bool toanLe = true;
            for (int i = 0; i < d[0]; i++)
            {
                Console.Write($"Dong {i}: ");
                int[] a = (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                if (a.Length != d[1] || a.Any(x => x % 2 == 0)) toanLe = false;
            }
            Console.WriteLine(toanLe ? "Mang A toan le!" : "Mang A khong toan le.");
        }
    }
}

namespace NMLT.Buoi11
{
    public static class SapChanLe
    {
        public static void Main()
        {
            Console.Write("Nhap day so nguyen: ");
            List<int> a = (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Console.WriteLine("Mang truoc khi sap xep: " + string.Join(" ", a));

            for (int i = 0; i < a.Count - 1; i++)
                for (int j = 0; j < a.Count - 1 - i; j++)
                {
                    bool chanJ = a[j] % 2 == 0, chanJ1 = a[j + 1] % 2 == 0;
                    bool doiCho = chanJ && chanJ1 ? a[j] > a[j + 1] : !chanJ && !chanJ1 ? a[j] < a[j + 1] : !chanJ;
                    if (doiCho) (a[j], a[j + 1]) = (a[j + 1], a[j]);
                }

            Console.WriteLine("Mang sau khi sap xep: " + string.Join(" ", a));
        }
    }
}

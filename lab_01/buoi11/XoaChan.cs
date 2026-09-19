namespace NMLT.Buoi11
{
    public static class XoaChan
    {
        public static void Main()
        {
            Console.Write("Nhap day so nguyen: ");
            int[] a = (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Console.WriteLine("Mang sau khi xoa so chan: " + string.Join(" ", a.Where(x => x % 2 != 0)));
        }
    }
}

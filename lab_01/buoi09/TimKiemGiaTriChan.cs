namespace NMLT.Buoi09
{
    public static class TimKiemGiaTriChan
    {
        public static void Main()
        {
            Console.Write("Nhap day so nguyen, cach nhau boi khoang trang: ");
            int[] a = (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int dau = Array.FindIndex(a, x => x % 2 == 0), cuoi = Array.FindLastIndex(a, x => x % 2 == 0);
            Console.WriteLine(dau < 0 ? "Day khong co so chan." : $"Chan dau tien: a[{dau}] = {a[dau]}; chan cuoi cung: a[{cuoi}] = {a[cuoi]}.");
        }
    }
}

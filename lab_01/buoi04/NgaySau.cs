namespace NMLT.Buoi04
{
    public static class NgaySau
    {
        public static void Main()
        {
            Console.Write("Nhap ngay, thang, nam: ");
            int[] v = (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            try
            {
                DateTime sau = new DateTime(v[2], v[1], v[0]).AddDays(1);
                Console.WriteLine($"Ngay sau la ngay {sau.Day}/{sau.Month}/{sau.Year}.");
            }
            catch
            {
                Console.WriteLine("Ngay thang nam khong hop le.");
            }
        }
    }
}

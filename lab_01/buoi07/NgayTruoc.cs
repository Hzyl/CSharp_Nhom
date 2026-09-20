namespace NMLT.Buoi07
{
    public static class NgayTruoc
    {
        public static void Main()
        {
            Console.Write("Nhap ngay: ");
            int ngay = int.Parse(Console.ReadLine()!);
            Console.Write("Nhap thang: ");
            int thang = int.Parse(Console.ReadLine()!);
            Console.Write("Nhap nam: ");
            int nam = int.Parse(Console.ReadLine()!);

            DateTime d = new DateTime(nam, thang, ngay).AddDays(-1);
            Console.WriteLine($"Ngay truoc ngay {ngay}/{thang}/{nam} la ngay {d.Day}/{d.Month}/{d.Year}.");
        }
    }
}

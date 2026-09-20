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

            int ngayTruoc, thangTruoc, namTruoc;

            if (ngay > 1)
            {
                ngayTruoc = ngay - 1;
                thangTruoc = thang;
                namTruoc = nam;
            }
            else
            {
                thangTruoc = thang > 1 ? thang - 1 : 12;
                namTruoc = thang > 1 ? nam : nam - 1;

                int[] soNgay = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                bool namNhuan = (namTruoc % 4 == 0 && namTruoc % 100 != 0) || (namTruoc % 400 == 0);
                ngayTruoc = (thangTruoc == 2 && namNhuan) ? 29 : soNgay[thangTruoc - 1];
            }

            Console.WriteLine($"Ngay truoc ngay {ngay}/{thang}/{nam} la ngay {ngayTruoc}/{thangTruoc}/{namTruoc}.");
        }
    }
}

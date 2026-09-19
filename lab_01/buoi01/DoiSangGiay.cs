namespace NMLT.Buoi01
{
    public static class DoiSangGiay
    {
    public static void Main()
        {
            Console.Write("Nhap so gio: ");
            int gio = int.Parse(Console.ReadLine()!);
            Console.Write("Nhap so phut: ");
            int phut = int.Parse(Console.ReadLine()!);
            Console.Write("Nhap so giay: ");
            int giay = int.Parse(Console.ReadLine()!);
            int tongGiay = gio * 3600 + phut * 60 + giay;
            Console.WriteLine($"Tong so giay cua {gio}:{phut:D2}:{giay:D2} la {tongGiay} giay.");
        }
    }
}

using System;
class Program
{
    static void ThangTiengAnh()
    {
        Console.Write("Nhap so thang (1-12): ");
        int thang = int.Parse(Console.ReadLine());
        string tenThang;
        switch (thang)
        {
            case 1: tenThang = "January"; break;
            case 2: tenThang = "February"; break;
            case 3: tenThang = "March"; break;
            case 4: tenThang = "April"; break;
            case 5: tenThang = "May"; break;
            case 6: tenThang = "June"; break;
            case 7: tenThang = "July"; break;
            case 8: tenThang = "August"; break;
            case 9: tenThang = "September"; break;
            case 10: tenThang = "October"; break;
            case 11: tenThang = "November"; break;
            case 12: tenThang = "December"; break;
            default: tenThang = "So thang khong hop le!"; break;
        }
        Console.WriteLine("Ten thang: " + tenThang);
    }
    static void Main(string[] args)
    {
        ThangTiengAnh();
    }
}
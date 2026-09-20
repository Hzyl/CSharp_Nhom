using System;
class Program
{
    static void DoiSangGioPhutGiay() 
    {
        int soGiay;
        Console.Write("Nhap vao so giay: ");
        soGiay = int.Parse(Console.ReadLine());
        int soGio = soGiay / 3600;
        int soPhut = (soGiay % 3600) / 60;
        int soGiayConLai = soGiay % 60;
        Console.WriteLine("{0} giay co dang {1}:{2}:{3}", soGiay, soGio, soPhut, soGiayConLai);
    }
    static void Main(string[] args)
    {
        DoiSangGioPhutGiay();
    }
}
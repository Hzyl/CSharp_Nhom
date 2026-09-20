using System;
class Program
{
    static void TinhGiaiThua()
    {
        Console.Write("Moi ban nhap so nguyen n: ");
        int n = int.Parse(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine("Khong tinh giai thua cua so am");
            return;
        }
        long giaiThua = 1;
        for (int i = 1; i <= n; i++)
        {
            giaiThua *= i;
        }
        Console.WriteLine($"Giai thua cua {n} la: {giaiThua}");
    }
    static void Main(string[] args)
    {
        TinhGiaiThua();
    }
}
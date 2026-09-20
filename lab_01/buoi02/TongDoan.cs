using System;
class Program
{
    static void TongDoan() 
    {
        int a, b;
        Console.Write("Nhap a va b: ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());

        int tong = 0;

        for (int i = a; i <= b; i++)
        {
            tong += i;
        }
        Console.WriteLine("Tong cua cac so trong doan [{0}, {1}] la: {2}", a, b, tong);
    }
    static void Main(string[] args)
    {
        TongDoan();
    }
}
using System;
class Program
{
    static void KiemTraSoHoanHao()
    {
        Console.Write("Moi ban nhap mot so nguyen duong: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Vui long nhap mot so nguyen duong!");
            return;
        }
        int sum = 0;
        for (int i = 1; i < n; i++)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }
        if (sum == n)
        {
            Console.WriteLine($"{n} la so hoan hao.");
        }
        else
        {
            Console.WriteLine($"{n} khong phai la so hoan hao.");
        }
    }
    static void Main(string[] args)
    {
        KiemTraSoHoanHao();
    }
}
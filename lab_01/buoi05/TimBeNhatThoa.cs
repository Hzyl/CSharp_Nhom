using System;

class Program
{
    static void Main()
    {
        double a;
        Console.Write("Nhap a: ");
        a = double.Parse(Console.ReadLine());

        int n = 0;
        double s = 0;

        while (s <= a)
        {
            n++;
            s += 1.0 / n;
        }

        Console.WriteLine("n nho nhat = " + n);
        Console.WriteLine("Tong S = " + s);
    }
}
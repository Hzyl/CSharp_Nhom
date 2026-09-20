using System;
class Program
{
    static void PhanLoaiTamGiac()
    {
        Console.Write("Moi ban nhap 3 canh cua tam giac: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        if (a <= 0 || b <= 0 || c <= 0)
        {
            Console.WriteLine("Khong phai la tam giac");
            return;
        }
        if (a + b > c && a + c > b && b + c > a)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("Tam giac deu");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Tam giac can");
            }
            else if (a*a + b*b == c*c || a*a + c*c == b*b || b*b + c*c == a*a) // fixed compile error from source
            {
                Console.WriteLine("Tam giac vuong");
            }
            else
            {
                Console.WriteLine("Tam giac thuong");
            }
        }
        else
        {
            Console.WriteLine("Khong phai la tam giac");
        }
    }
    static void Main(string[] args)
    {
        PhanLoaiTamGiac();
    }
}
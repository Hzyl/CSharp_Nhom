using System;
class Program
{
    static void TimQuy()
    {
        int n;
        Console.Write("Nhap n: ");
        n = int.Parse(Console.ReadLine());
        switch (n)
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine("Quy I");
                break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine("Quy II");
                break;
            case 7:
            case 8:
            case 9:
                Console.WriteLine("Quy III");
                break;
            case 10:
            case 11:
            case 12:
                Console.WriteLine("Quy IV");
                break;
            default:
                Console.WriteLine("So thang khong hop le");
                break;
        }
    }
    static void Main(string[] args)
    {
        TimQuy();
    }
}
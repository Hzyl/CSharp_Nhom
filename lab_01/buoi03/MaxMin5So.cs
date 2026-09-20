using System;
class Program
{
    static void MaxMin5So()
    {
        Console.WriteLine("Nhap 5 so nguyen: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        
        int max = Math.Max(Math.Max(Math.Max(a, b), Math.Max(c, d)), e);
        int min = Math.Min(Math.Min(Math.Min(a, b), Math.Min(c, d)), e);
        Console.WriteLine("Max: " + max);
        Console.WriteLine("Min: " + min);
    }
    static void Main(string[] args)
    {
        MaxMin5So();
    }
}
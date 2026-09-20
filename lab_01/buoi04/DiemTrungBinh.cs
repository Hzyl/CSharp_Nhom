using System;
class Program
{
    static void DiemTrungBinh()
    {
        Console.Write("Moi ban nhap diem toan, ly, hoa: ");
        int toan = int.Parse(Console.ReadLine());
        int ly = int.Parse(Console.ReadLine());
        int hoa = int.Parse(Console.ReadLine());
        while (toan < 0 || toan > 10 || ly < 0 || ly > 10 || hoa < 0 || hoa > 10)
        {
            Console.WriteLine("Diem nhap vao khong hop le! Vui long nhap lai diem toan, ly, hoa (0-10): ");
            toan = int.Parse(Console.ReadLine());
            ly = int.Parse(Console.ReadLine());
            hoa = int.Parse(Console.ReadLine());
        }
        double dtb = (toan + ly + hoa) / 3.0;

        switch (dtb)
        {
            case double n when (n >= 8):
                Console.WriteLine("Xep loai: Gioi");
                break;
            case double n when (n >= 6.5 && n < 8):
                Console.WriteLine("Xep loai: Kha");
                break;
            case double n when (n >= 5 && n < 6.5):
                Console.WriteLine("Xep loai: Trung binh");
                break;
            case double n when (n < 5):
                Console.WriteLine("Xep loai: Yeu");
                break;
        }
    }
    static void Main(string[] args)
    {
        DiemTrungBinh();
    }
}
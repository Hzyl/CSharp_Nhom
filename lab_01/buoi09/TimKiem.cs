using System;

class Program
{
    static void Main()
    {
        Console.Write("Moi ban nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());

        double[] a = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Phan tu " + i + ": ");
            a[i] = double.Parse(Console.ReadLine());
        }

        Console.Write("Day so co " + n + " phan tu: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }

        Console.WriteLine();
        Console.WriteLine("* Tim kiem");

        Console.Write("Moi ban nhap gia tri x can tim: ");
        double x = double.Parse(Console.ReadLine());

        int viTriDau = -1;
        int viTriCuoi = -1;
        int dem = 0;

        for (int i = 0; i < n; i++)
        {
            if (a[i] == x)
            {
                dem++;

                if (viTriDau == -1)
                {
                    viTriDau = i;
                }

                viTriCuoi = i;
            }
        }

        if (dem == 0)
        {
            Console.WriteLine("Gia tri " + x + " khong ton tai trong day so.");
        }
        else
        {
            Console.WriteLine("Gia tri " + x + " xuat hien " + dem + " lan o vi tri dau tien " + viTriDau + " va cuoi cung " + viTriCuoi + ".");
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so dong n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Nhap so cot m: ");
        int m = int.Parse(Console.ReadLine());

        int[,] a = new int[n, m];

        Console.WriteLine("Nhap A:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("A[" + i + "," + j + "] = ");
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Mang co " + n + " dong x " + m + " cot:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(a[i, j] + " ");
            }

            Console.WriteLine();
        }

        int tongChan = 0;
        int tongLe = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (a[i, j] % 2 == 0)
                {
                    tongChan += a[i, j];
                }
                else
                {
                    tongLe += a[i, j];
                }
            }
        }

        Console.WriteLine("Tong cac so chan la " + tongChan + " va tong so le la " + tongLe + ".");
    }
}
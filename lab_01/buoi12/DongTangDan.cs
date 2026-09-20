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

        Console.Write("Cac dong tao thanh day tang: ");

        for (int i = 0; i < n; i++)
        {
            bool tang = true;

            for (int j = 0; j < m - 1; j++)
            {
                if (a[i, j] >= a[i, j + 1])
                {
                    tang = false;
                    break;
                }
            }

            if (tang)
            {
                Console.Write(i + " ");
            }
        }
    }
}
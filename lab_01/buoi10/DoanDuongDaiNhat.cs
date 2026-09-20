namespace NMLT.Buoi10
{
    public static class DoanDuongDaiNhat
    {
        public static void Main()
        {
            Console.Write("Moi ban nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine()!);

            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phan tu {i}: ");
                a[i] = double.Parse(Console.ReadLine()!);
            }

            Console.Write($"Day so co {n} phan tu:");
            for (int i = 0; i < n; i++)
                Console.Write(" " + a[i]);
            Console.WriteLine();
            
            int iKQ = -1, jKQ = -1;
            int idx = 0;
            while (idx < n)
            {
                if (a[idx] > 0)
                {
                    int j = idx;
                    while (j < n && a[j] > 0)
                        j++
                    if ((j - 1 - idx) > (jKQ - iKQ))
                    {
                        iKQ = idx;
                        jKQ = j - 1;
                    }
                    idx = j;
                }
                else
                {
                    idx++;
                }
            }

            if (iKQ == -1)
            {
                Console.WriteLine("Khong co doan duong nao trong day.");
            }
            else
            {
                Console.Write($"Doan duong [{iKQ}, {jKQ}] dai nhat:");
                for (int i = iKQ; i <= jKQ; i++)
                    Console.Write(" " + a[i]);
                Console.WriteLine();
            }
        }
    }
}

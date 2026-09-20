namespace NMLT.Buoi07
{
    public static class XuLyChuSo1
    {
        public static void Main()
        {
            Console.Write("Moi ban nhap so nguyen n: ");
            string n = Console.ReadLine()!;

            Console.Write("Moi ban nhap vi tri k: ");
            int k = int.Parse(Console.ReadLine()!);
            char chuSoK = n[k - 1];
            Console.WriteLine($"Chu so o vi tri {k} (tinh tu trai) cua {n} la {chuSoK}.");

            int tongLe = 0;
            foreach (char c in n)
            {
                int d = c - '0';
                if (d % 2 != 0)
                    tongLe += d;
            }
            Console.WriteLine($"Tong cac chu so le cua {n} la {tongLe}.");

            int min = 10, max = -1;
            foreach (char c in n)
            {
                int d = c - '0';
                if (d % 2 != 0)
                {
                    if (d < min) min = d;
                    if (d > max) max = d;
                }
            }
            Console.WriteLine($"{n} co chu so le nho nhat la {min} va lon nhat la {max}.");
        }
    }
}

namespace NMLT.Buoi08
{
    public static class RutGonPhanSo
    {
        static int Gcd(int a, int b)
        {
            while (b != 0)
            {
                int t = a % b;
                a = b;
                b = t;
            }
            return Math.Abs(a);
        }
        public static void Main()
        {
            Console.Write("Nhap tu so: ");
            int t = int.Parse(Console.ReadLine()!);
            Console.Write("Nhap mau so: ");
            int m = int.Parse(Console.ReadLine()!);
            if (m == 0)
            {
                Console.WriteLine("Mau so phai khac 0.");
                return;
            }
            int g = Gcd(t, m);
            t /= g;
            m /= g;
            if (m < 0)
            {
                t = -t;
                m = -m;
            }
            Console.WriteLine($"Phan so rut gon: {t}/{m}");
        }
    }
}

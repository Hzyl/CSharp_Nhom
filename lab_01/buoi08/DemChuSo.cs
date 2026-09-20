namespace NMLT.Buoi08
{
    public static class DemChuSo
    {
        static int DemSoLan(string n, char d) => n.Count(c => c == d);

        public static void Main()
        {
            Console.Write("Moi ban nhap so nguyen n: ");
            string n = Console.ReadLine()!;

            foreach (char d in "0123456789")
            {
                int soLan = DemSoLan(n, d);
                if (soLan > 0)
                    Console.WriteLine($"Chu so {d} xuat hien {soLan} lan.");
            }
        }
    }
}

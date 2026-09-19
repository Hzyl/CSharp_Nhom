namespace NMLT.Buoi01
{
    public class HinhTron
    {
        public static void Main()
        {
            Console.Write("Nhap ban kinh R: ");
            double r = double.Parse(Console.ReadLine()!);
            const double pi = 3.14;
            Console.WriteLine($"Dien tich S = {pi * r * r:F1}");
            Console.WriteLine($"Chu vi P = {2 * pi * r:F1}");
        }
    }
}
